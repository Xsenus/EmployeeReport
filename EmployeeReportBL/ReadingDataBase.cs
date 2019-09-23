using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EmployeeReportBL
{
    public class ReadingDataBase
    {
        private readonly OleDbConnection dbConnection;
        public List<Pay> Pays { get; set; } = new List<Pay>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Accrual> Accruals { get; set; } = new List<Accrual>();

        public ReadingDataBase(OleDbConnection dbConnection)
        {
            if (dbConnection.State != ConnectionState.Open)
            {
                return;
            }

            this.dbConnection = dbConnection;

            Pays = GetPay();
            Employees = GetEmployees();
            //Accruals = GetAccruals();
        }

        private List<Accrual> GetAccruals()
        {
            var sql = $"SELECT * FROM Zhis as His JOIN Zsnu As Snu ON His.Snu_rn = Snu.Snu_rn JOIN Zfcac As Fcac ON Fcac.Fcac_rn = His.Fcac_rn";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = @"", Connection = dbConnection })
            {
                int allRecords = Convert.ToInt32(cmd.ExecuteScalar());
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

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
            var sql =   $"SELECT P.Surname, P.Firstname, P.Secondname, Subdiv.Name, Ank.Pf_id, Dol.Name, Vid.Name, Sost.Name, Fcac.Fcac_rn " +
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

                        Employees.Add(new Employee()
                        {
                            rn = rn,
                            Name = name,
                            Surname = surname,
                            Patronymic = patronymic,
                            Subdivision = subdivision,
                            Snails = snails,
                            Position = position,
                            TypePersonalAccount = typePersonalAccount,
                            SourceOfFinancing = sourceOfFinancing
                        });
                    }
                }
            }

            return Employees;
        }
    }
}
