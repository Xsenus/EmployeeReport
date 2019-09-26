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
        public List<Position> Positions { get; set; } = new List<Position>();
        public List<string> Payrolls { get; set; } = new List<string>();
        public List<string> TypeOfCalculations { get; set; } = new List<string>();


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
                Payrolls = GetPayrolls();
                TypeOfCalculations = GetTypeOfCalculations();
            }
        }

        private List<string> GetTypeOfCalculations()
        {
            var sql = $"SELECT Code FROM Zrvdict";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mnemo = reader[0].ToString().Trim();
                        TypeOfCalculations.Add(mnemo);
                    }
                }
            }

            return TypeOfCalculations;
        }

        private List<string> GetPayrolls()
        {
            var sql = $"SELECT Code FROM Zkatfzp";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var mnemo = reader[0].ToString().Trim();
                        Payrolls.Add(mnemo);
                    }
                }
            }

            return Payrolls;
        }

        private List<Accrual> GetAccrual(int year, Month month)
        {
            var result = new List<Accrual>();

            var sql = $"SELECT Snu.Code, His.Sum, His.Year, His.Month, His.Storno, His.Fcac_rn, Rvdict.Code " +
                        $"FROM Zhis AS His " +
                        $"JOIN Zsnu AS Snu ON His.Snu_rn = Snu.Snu_rn " +
                        $"JOIN Zrvlist AS Rvlist ON His.Rvlist_rn = Rvlist.Rvlist_rn " +
                        $"JOIN Zrvdict AS Rvdict ON Rvlist.Rvdict_rn = Rvdict.Rvdict_rn " +
                        $"WHERE His.Year = {year} AND His.Month = {(int)month}";

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

                        var fcacRn = reader[5].ToString().Trim();
                        var typeOfCalculation = reader[6].ToString().Trim();

                        result.Add(new Accrual()
                        {
                            FcacRn = fcacRn,
                            Mnemo = mnemo,
                            Value = value,
                            Year = year,
                            Month = month,
                            TypeOfCalculation = typeOfCalculation
                        });
                    }
                }
            }

            return result;
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

        public List<Employee> GetEmployees(int year, Month month)
        {
            var accrual = GetAccrual(year, month);

            var result = new List<Employee>();

            var dateSince = new DateTime(year, (int)month, 1);
            var dateTo = dateSince.AddMonths(1).AddDays(-1);

            var sql = $"SELECT P.Surname, P.Firstname, P.Secondname, Subdiv.Name, Ank.Pf_id, Dol.Code, Vid.Name, Sost.Name, Fcac.Fcac_rn, Fcac.Startdate, Fcac.Enddate " +
                        $"FROM Zfcac AS Fcac " +
                        $"JOIN Zank AS Ank ON Fcac.Ank_rn = Ank.Ank_rn " +
                        $"JOIN Zsubdiv AS Subdiv ON Fcac.Subdiv_rn = Subdiv.Subdiv_rn " +
                        $"JOIN Zvidisp AS Vid ON Fcac.Vidisp_rn = Vid.Vidisp_rn " +
                        $"JOIN Ztipdol AS Dol ON Fcac.Tipdol_rn = Dol.Tipdol_rn " +
                        $"JOIN Orgbase AS Org ON Org.Rn = Ank.Orgbase_rn " +
                        $"JOIN Person AS P ON P.Orbase_rn = Org.Rn " +
                        $"JOIN Zfcacch AS Zfc ON Fcac.Fcac_rn = Zfc.Fcacbs_rn " +
                        $"JOIN Zsostzat AS Sost ON Sost.Sostzat_rn = Zfc.Sostzat_rn " +
                        $"WHERE Fcac.Startdate <= DATE({dateTo.Year}, {dateTo.Month}, {dateTo.Day}) AND Fcac.Enddate >= DATE({dateSince.Year}, {dateSince.Month}, {dateSince.Day})";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rn = reader[8].ToString().Trim();

                        if (accrual.Any(a => a.FcacRn == rn))
                        {
                            var name = reader[0].ToString().Trim();
                            var surname = reader[1].ToString().Trim();
                            var patronymic = reader[2].ToString().Trim();
                            var subdivision = reader[3].ToString().Trim();
                            var snails = reader[4].ToString().Trim();
                            var position = reader[5].ToString().Trim();

                            var typePersonalAccount = reader[6].ToString().Trim();
                            typePersonalAccount = $"{char.ToUpper(typePersonalAccount[0])}{typePersonalAccount.Substring(1).ToLower()}";

                            var sourceOfFinancing = reader[7].ToString().Trim();

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
                                Payroll = GetPayroll(rn, dateSince, ReportSettings.settings.OfficialSalary)
                            };

                            employee.Accruals = new List<Accrual>();
                            employee.Accruals.AddRange(accrual.Where(w => w.FcacRn == rn));
                            result.Add(employee);
                        }
                    }
                }
            }

            return result;
        }

        private List<Payroll> GetPayroll(string fcacRn, DateTime dateSince, string mnemoPayroll)
        {
            if (string.IsNullOrEmpty(mnemoPayroll))
            {
                return null;
            }
            var result = new List<Payroll>();

            var startdate = $"DATE({dateSince.Year}, {dateSince.Month}, {dateSince.Day})";

            var sql = $"SELECT Cfzp.Fcac_rn, Kfzp.Code, Cfzp.Stavka, Cfzp.Startdate, Cfzp.Enddate " +
                        $"FROM Zfcacfzp AS Cfzp " +
                        $"JOIN Zkatfzp as Kfzp ON Cfzp.Katfzp_rn = Kfzp.Katfzp_rn " +
                        $"WHERE Kfzp.Code = '{mnemoPayroll}' AND Cfzp.Fcac_rn = '{fcacRn}' " +
                        $"AND Cfzp.Startdate <= {startdate} AND Cfzp.Enddate >= {startdate}";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnection })
            {
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rn = reader[0].ToString().Trim();
                        var mnemo = reader[1].ToString().Trim();
                        var value = Convert.ToDecimal(reader[2].ToString().Trim());
                        var dateSincePayroll = Convert.ToDateTime(reader[3].ToString().Trim());
                        var dateToPayroll = Convert.ToDateTime(reader[4].ToString().Trim());

                        result.Add(new Payroll()
                        {
                            FcacRn = rn,
                            Mnemo = mnemo,
                            Value = value,
                            DateSince = dateSincePayroll,
                            DateTo = dateToPayroll
                        });
                    }
                }
            }

            return result;
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
    }
}
