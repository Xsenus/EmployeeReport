using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace EmployeeReportBL
{
    public class ReadingDataBase
    {
        public readonly OleDbConnection dbConnection;
        public List<Pay> Pays { get; set; } = new List<Pay>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Position> Positions { get; set; } = new List<Position>();
        public List<Accrual> Accruals { get; set; } = new List<Accrual>();
        public List<int> Years { get; set; } = new List<int>();

        public ReadingDataBase(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var foxProConnection = new FoxProConnection(path);

            if (foxProConnection.DbConnection.State == ConnectionState.Open)
            {
                dbConnection = foxProConnection.DbConnection;

                Pays = GetPay();
                Positions = GetPosition();
                Years = GetYear();
                Accruals = GetAccrual();
                Employees = GetEmployees();
            }
        }

        private List<Accrual> GetAccrual()
        {
            var sql = $"SELECT Snu.Code, His.Sum, His.Year, His.Month, His.Storno, His.Fcac_rn " +
                        $"FROM Zhis AS His " +
                        $"JOIN Zsnu AS Snu ON His.Snu_rn = Snu.Snu_rn";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mnemo = reader[0].ToString().Trim();
                        var storno = Convert.ToBoolean(reader[4].ToString().Trim());
                        var value = Convert.ToDecimal(reader[1].ToString().Trim());

                        if (storno)
                        {
                            value = value * -1;
                        }

                        var year = Convert.ToInt32(reader[2].ToString().Trim());
                        var month = (Month)Convert.ToInt32(reader[3].ToString().Trim());                        
                        var fcacRn = reader[5].ToString().Trim();

                        Accruals.Add(new Accrual()
                        {
                            FcacRn = fcacRn,
                            Mnemo = mnemo,
                            Value = value,
                            Year = year,
                            Month = month,
                            Storno = storno
                        });
                    }
                }
            }

            return Accruals;
        }

        private List<Pay> GetPay()
        {
            var sql = $"SELECT Snu_rn, Num, Code, Nick, Name FROM Zsnu";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rn = reader[0].ToString().Trim();
                        var number = Convert.ToInt32(reader[1]);
                        var mnemo = reader[2].ToString().Trim();
                        var abbreviatedName = reader[3].ToString().Trim();
                        var name = reader[4].ToString().Trim();

                        Pays.Add(new Pay()
                        {
                            Rn = rn,
                            Number = number,
                            Mnemo = mnemo,
                            AbbreviatedName = abbreviatedName,
                            Name = name
                        });
                    }
                }
            }

            return Pays;
        }

        private List<Employee> GetEmployees()
        {
            var sql = $"SELECT P.Surname, P.Firstname, P.Secondname, Subdiv.Name, Ank.Pf_id, Dol.Name, Vid.Name, Sost.Name, Fcac.Fcac_rn " +
                        $"FROM Zfcac AS Fcac " +
                        $"JOIN Zank AS Ank ON Fcac.Ank_rn = Ank.Ank_rn " +
                        $"JOIN Zsubdiv AS Subdiv ON Fcac.Subdiv_rn = Subdiv.Subdiv_rn " +
                        $"JOIN Zvidisp AS Vid ON Fcac.Vidisp_rn = Vid.Vidisp_rn " +
                        $"JOIN Ztipdol AS Dol ON Fcac.Tipdol_rn = Dol.Tipdol_rn " +
                        $"JOIN Orgbase AS Org ON Org.Rn = Ank.Orgbase_rn " +
                        $"JOIN Person AS P ON P.Orbase_rn = Org.Rn " +
                        $"JOIN Zfcacch AS Zfc ON Fcac.Fcac_rn = Zfc.Fcacbs_rn " +
                        $"JOIN Zsostzat AS Sost ON Sost.Sostzat_rn = Zfc.Sostzat_rn";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var name = reader[0].ToString().Trim();
                        var surname = reader[1].ToString().Trim();
                        var patronymic = reader[2].ToString().Trim();
                        var subdivision = reader[3].ToString().Trim();
                        var snails = reader[4].ToString().Trim();
                        var position = reader[5].ToString().Trim();
                        var typePersonalAccount = reader[6].ToString().Trim();
                        var sourceOfFinancing = reader[7].ToString().Trim();
                        var rn = reader[8].ToString().Trim();                        

                        var employee = new Employee()
                        {
                            rn = rn,
                            Name = name,
                            Surname = surname,
                            Patronymic = patronymic,
                            Subdivision = subdivision,
                            Snails = snails,
                            Position = position,
                            TypePersonalAccount = typePersonalAccount,
                            SourceOfFinancing = sourceOfFinancing,
                        };

                        employee.Accruals = new List<Accrual>();
                        employee.Accruals.AddRange(Accruals.Where(w => w.FcacRn == rn));
                        Employees.Add(employee);
                    }
                }
            }

            return Employees;
        }

        private void GetAnnualsEmployee()
        {
            if (Employees != null)
            {
                foreach (var item in Employees)
                {
                    if (item.Accruals == null)
                    {
                        item.Accruals = new List<Accrual>();
                    }

                    var sql = $"SELECT Snu.Code, His.Sum, His.Year, His.Month, His.Storno FROM Zhis AS His JOIN Zsnu AS Snu ON His.Snu_rn = Snu.Snu_rn WHERE Fcac_rn = '{item.rn}'";

                    using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var mnemo = reader[0].ToString().Trim();
                                var value = Convert.ToDecimal(reader[1].ToString().Trim());
                                var year = Convert.ToInt32(reader[2].ToString().Trim());
                                var month = (Month)Convert.ToInt32(reader[3].ToString().Trim());
                                var storno = Convert.ToBoolean(reader[4].ToString().Trim());

                                item.Accruals.Add(new Accrual()
                                {
                                    Mnemo = mnemo,
                                    Value = value,
                                    Year = year,
                                    Month = month,
                                    Storno = storno
                                });
                            }
                        }
                    }
                }
            }
        }

        private List<Position> GetPosition()
        {
            var sql = $"SELECT Tipdol_rn, Num, Code, Name FROM Ztipdol";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rn = reader[0].ToString().Trim();
                        var number = Convert.ToInt32(reader[1].ToString().Trim());
                        var mnemo = reader[2].ToString().Trim();
                        var name = reader[3].ToString().Trim();

                        Positions.Add(new Position()
                        {
                            Rn = rn,
                            Number = number,
                            Mnemo = mnemo,
                            Name = name
                        });
                    }
                }
            }

            return Positions;
        }

        private List<int> GetYear()
        {
            var sql = $"SELECT Year FROM Zhis Group BY Year";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var year = Convert.ToInt32(reader[0].ToString().Trim());

                        Years.Add(year);
                    }
                }
            }

            return Years;
        }
    }
}
