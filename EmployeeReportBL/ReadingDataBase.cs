using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeReportBL
{
    public class ReadingDataBase
    {
        /// <summary>
        /// Активное соединение с ДБ.
        /// </summary>
        public readonly OleDbConnection dbConnectionAsync;

        /// <summary>
        /// Список выплат и удержаний.
        /// </summary>
        public List<Pay> Pays { get; set; }

        /// <summary>
        /// Список должностей.
        /// </summary>
        public List<Position> Positions { get; set; }

        /// <summary>
        /// Список Категорий ФОТ.
        /// </summary>
        public List<string> Payrolls { get; set; }

        /// <summary>
        /// Список видов расчетов.
        /// </summary>
        public List<string> TypeOfCalculations { get; set; }

        /// <summary>
        /// Список типов рабочего дня.
        /// </summary>
        public List<TypeOfDay> TypeOfDays { get; set; }

        public event EventHandler<Tuple<string, int, bool>> LoadData;
        public event EventHandler<int> ReaderEvent;

        private int AddCount { get; set; } = 0;

        public ReadingDataBase() { }

        public ReadingDataBase(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var tokenSource = new CancellationTokenSource();
            CancellationToken ct = tokenSource.Token;
            dbConnectionAsync = GetOleDbConnectionAsync(path, ct).Result;            
        }

        public void GetInformation()
        {
            if (dbConnectionAsync.State == ConnectionState.Open)
            {
                var tokenSource = new CancellationTokenSource();
                CancellationToken ct = tokenSource.Token;

                TypeOfCalculations = GetTypeOfCalculationsAsync(dbConnectionAsync, ct).Result;
                Payrolls = GetPayrollsAsync(dbConnectionAsync, ct).Result;
                Pays = GetPayAsync(dbConnectionAsync, ct).Result;
                Positions = GetPositionAsync(dbConnectionAsync, ct).Result;
                TypeOfDays = GetTypesOfDaysAsync(dbConnectionAsync, ct).Result;
            }
        }

        /// <summary>
        /// Соединение с БД FoxPro
        /// </summary>
        public async Task<OleDbConnection> GetOleDbConnectionAsync(string path, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            if (string.Compare(path, string.Empty, StringComparison.Ordinal) == 0)
            {
                throw new ArgumentNullException(nameof(path), "Не задан путь к БД Парус Бюджет 7.");
            }

            var connectionstring = $"Provider=Microsoft OLE DB Provider for Visual FoxPro;Data Source={path}";

            var dbConnectionAsync = new OleDbConnection(connectionstring);
            await dbConnectionAsync.OpenAsync(token).ConfigureAwait(false);

            return dbConnectionAsync;
        }

        /// <summary>
        /// Получение видов расчета.
        /// </summary>
        private async Task<List<string>> GetTypeOfCalculationsAsync(OleDbConnection oleDbConnection, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();
            var sql = $"SELECT Code FROM Zrvdict";
            var result = new List<string>();

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = "SELECT COUNT(*) FROM Zrvdict", Connection = oleDbConnection })
            {
                AddCount = 0;
                int allRecords = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                LoadData?.Invoke(this, new Tuple<string, int, bool>("Виды расчета:", allRecords, true));
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = oleDbConnection })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var mnemo = reader[0].ToString().Trim();
                        result.Add(mnemo);

                        AddCount++;
                        ReaderEvent?.Invoke(this, AddCount);
                    }
                }
            }

            LoadData?.Invoke(this, new Tuple<string, int, bool>(string.Empty, 0, false));
            return result;
        }

        /// <summary>
        /// Получение Категорий ФОТ.
        /// </summary>
        private async Task<List<string>> GetPayrollsAsync(OleDbConnection oleDbConnection, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var sql = $"SELECT Code FROM Zkatfzp";

            var result = new List<string>();


            using (OleDbCommand cmd = new OleDbCommand() { CommandText = "SELECT COUNT(*) FROM Zkatfzp", Connection = oleDbConnection })
            {
                AddCount = 0;
                int allRecords = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                LoadData?.Invoke(this, new Tuple<string, int, bool>("Категорий ФОТ:", allRecords, true));
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = oleDbConnection })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var mnemo = reader[0].ToString().Trim();
                        result.Add(mnemo);

                        AddCount++;
                        ReaderEvent?.Invoke(this, AddCount);
                    }
                }
            }

            LoadData?.Invoke(this, new Tuple<string, int, bool>(string.Empty, 0, false));
            return result;
        }

        /// <summary>
        /// Получение списка выплат и удержаний.
        /// </summary>
        private async Task<List<Pay>> GetPayAsync(OleDbConnection oleDbConnection, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var sql = $"SELECT Snu_rn, Num, Code, Nick, Name FROM Zsnu";

            var result = new List<Pay>();

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = "SELECT COUNT(*) FROM Zsnu", Connection = oleDbConnection })
            {
                AddCount = 0;
                int allRecords = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                LoadData?.Invoke(this, new Tuple<string, int, bool>("Выплаты и удержания:", allRecords, true));
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = oleDbConnection })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var rn = reader[0].ToString().Trim();
                        var number = Convert.ToInt32(reader[1]);
                        var mnemo = reader[2].ToString().Trim();
                        var abbreviatedName = reader[3].ToString().Trim();
                        var name = reader[4].ToString().Trim();

                        result.Add(new Pay()
                        {
                            Rn = rn,
                            Number = number,
                            Memo = mnemo,
                            AbbreviatedName = abbreviatedName,
                            Name = name
                        });

                        AddCount++;
                        ReaderEvent?.Invoke(this, AddCount);
                    }
                }
            }

            LoadData?.Invoke(this, new Tuple<string, int, bool>(string.Empty, 0, false));
            return result;
        }

        /// <summary>
        /// Получение списка должностей.
        /// </summary>
        private async Task<List<Position>> GetPositionAsync(OleDbConnection oleDbConnection, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var sql = $"SELECT Tipdol_rn, Num, Code, Name FROM Ztipdol";

            var result = new List<Position>();

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = "SELECT COUNT(*) FROM Ztipdol", Connection = oleDbConnection })
            {
                AddCount = 0;
                int allRecords = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                LoadData?.Invoke(this, new Tuple<string, int, bool>("Должности:", allRecords, true));
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = oleDbConnection })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var rn = reader[0].ToString().Trim();
                        var number = Convert.ToInt32(reader[1].ToString().Trim());
                        var mnemo = reader[2].ToString().Trim();
                        var name = reader[3].ToString().Trim();

                        result.Add(new Position()
                        {
                            Rn = rn,
                            Number = number,
                            Memo = mnemo,
                            Name = name
                        });

                        AddCount++;
                        ReaderEvent?.Invoke(this, AddCount);
                    }
                }
            }

            LoadData?.Invoke(this, new Tuple<string, int, bool>(string.Empty, 0, false));
            return result;
        }

        /// <summary>
        /// Получение списка лицевых счетов с начислениями.
        /// </summary>
        public async Task<List<Employee>> GetEmployeesAsync(int year, Month month, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var result = new List<Employee>();
            var dateSince = new DateTime(year, (int)month, 1);
            var dateTo = dateSince.AddMonths(1).AddDays(-1);

            var accrual = GetAccrualAsync(year, month, token).Result;

            var sqlCount = $"SELECT COUNT(*) " +
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

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sqlCount, Connection = dbConnectionAsync })
            {
                AddCount = 0;
                int allRecords = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                LoadData?.Invoke(this, new Tuple<string, int, bool>("Лицевые счета:", allRecords, true));
            }

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var rn = reader[8].ToString().Trim();

                        if (accrual.Any(a => string.Compare(a.EmployeeId, rn, StringComparison.Ordinal) == 0))
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
                                WorkingTime = GetWorkingTime(rn, year, month, token).Result,
                                ActualHoursWorked = GetActualHoursWorked(rn, year, month, token).Result
                            };

                            employee.Accruals = new List<Accrual>();
                            employee.Accruals.AddRange(accrual.Where(w => string.Compare(w.EmployeeId, rn, StringComparison.Ordinal) == 0));
                            result.Add(employee);

                            AddCount++;
                            ReaderEvent?.Invoke(this, AddCount);
                        }
                    }
                }
            }

            LoadData?.Invoke(this, new Tuple<string, int, bool>(string.Empty, 0, false));

            return result;
        }

        /// <summary>
        /// Получение фактически отработанного рабочего времени.
        /// </summary>
        private async Task<decimal?> GetActualHoursWorked(string fcacRn, int year, Month month, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var dateSince = new DateTime(year, (int)month, 1);
            var dateTo = dateSince.AddMonths(1).AddDays(-1);

            var starDate = $"DATE({dateSince.Year}, {dateSince.Month}, {dateSince.Day})";
            var endDate = $"DATE({dateTo.Year}, {dateTo.Month}, {dateTo.Day})";

            var result = 0.00;

            foreach (var item in ReportSettings.settings.TypeOfDays)
            {
                var sql = $"SELECT SUM(hourqnt) AS ssum FROM zfcacwth " +
                    $"WHERE fcac_rn = '{fcacRn}' AND hrtype_rn = '{item.Substring(0, 4)}' AND date >= {starDate} AND date <= {endDate} " +
                    $"AND date NOT IN (SELECT date FROM zfcacwtd WHERE fcac_rn = '{fcacRn}' AND date >= {starDate} AND date <= {endDate}) AND NOT DELETED()";

                using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
                {
                    var execute = await cmd.ExecuteScalarAsync();

                    if (execute == DBNull.Value)
                    {
                        continue;
                    }

                    result = result + Convert.ToDouble(execute);
                }
            }

            if (result == 0)
            {
                return default;
            }

            return Convert.ToDecimal(result);
        }

        /// <summary>
        /// Получение нормы рабочего времени.
        /// </summary>
        private async Task<decimal?> GetWorkingTime(string fcacRn, int year, Month month, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var sql = $"SELECT z1.hourall AS hn FROM zgrmonth z1, zfcacch z2 " +
                    $"WHERE z2.fcacbs_rn = '{fcacRn}' AND z2.grrbdc_rn = z1.grrbdc_rn AND z1.year = {year} AND z1.month = {(int)month}";

            var result = 0.00;

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
            {
                var execute = await cmd.ExecuteScalarAsync();

                if (execute == DBNull.Value)
                {
                    return null;
                }

                result = result + Convert.ToDouble(execute);

                if (result == 0)
                {
                    return default;
                }

                return Convert.ToDecimal(result);
            }
        }

        /// <summary>
        /// Получение списка начислений.
        /// </summary>
        /// <param name="year">Год начислений</param>
        /// <param name="month">Месяц начислений</param>
        private async Task<List<Accrual>> GetAccrualAsync(int year, Month month, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var result = new List<Accrual>();

            var sql = $"SELECT Snu.Code, His.Sum, His.Year, His.Month, His.Storno, His.Fcac_rn, Rvdict.Code " +
                        $"FROM Zhis AS His " +
                        $"JOIN Zsnu AS Snu ON His.Snu_rn = Snu.Snu_rn " +
                        $"JOIN Zrvlist AS Rvlist ON His.Rvlist_rn = Rvlist.Rvlist_rn " +
                        $"JOIN Zrvdict AS Rvdict ON Rvlist.Rvdict_rn = Rvdict.Rvdict_rn " +
                        $"WHERE His.Year = {year} AND His.Month = {(int)month}";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
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
                            EmployeeId = fcacRn,
                            Memo = mnemo,
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

        /// <summary>
        /// Получение списка Категорий ФОТ для лицевого счета.
        /// </summary>
        /// <param name="fcacRn">Уникальный идентификатор ЛС.</param>
        /// <param name="date">Дата с актуальным значением.</param>
        /// <param name="mnemoPayroll">Мнемокод Категории ФОТ.</param>
        /// <returns></returns>
        private async Task<List<Payroll>> GetPayrollAsync(string fcacRn, DateTime date, string mnemoPayroll, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            if (string.IsNullOrEmpty(mnemoPayroll))
            {
                return null;
            }

            var result = new List<Payroll>();

            var startdate = $"DATE({date.Year}, {date.Month}, {date.Day})";

            var sql = $"SELECT Cfzp.Fcac_rn, Kfzp.Code, Cfzp.Stavka, Cfzp.Startdate, Cfzp.Enddate " +
                        $"FROM Zfcacfzp AS Cfzp " +
                        $"JOIN Zkatfzp as Kfzp ON Cfzp.Katfzp_rn = Kfzp.Katfzp_rn " +
                        $"WHERE Kfzp.Code = '{mnemoPayroll}' AND Cfzp.Fcac_rn = '{fcacRn}' " +
                        $"AND Cfzp.Startdate <= {startdate} AND Cfzp.Enddate >= {startdate}";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var rn = reader[0].ToString().Trim();
                        var mnemo = reader[1].ToString().Trim();
                        var value = Convert.ToDecimal(reader[2].ToString().Trim());
                        var dateSincePayroll = Convert.ToDateTime(reader[3].ToString().Trim());
                        var dateToPayroll = Convert.ToDateTime(reader[4].ToString().Trim());

                        result.Add(new Payroll()
                        {
                            Id = rn,
                            Memo = mnemo,
                            Value = value,
                            DateSince = dateSincePayroll,
                            DateTo = dateToPayroll
                        });
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Получение списка типов рабочих дней.
        /// </summary>
        private async Task<List<TypeOfDay>> GetTypesOfDaysAsync(OleDbConnection oleDbConnection, CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            var result = new List<TypeOfDay>();

            var sql = $"SELECT Hrtype_rn, Num, Code, Name FROM Zhrtype";

            using (OleDbCommand cmd = new OleDbCommand() { CommandText = sql, Connection = dbConnectionAsync })
            {
                using (var reader = await cmd.ExecuteReaderAsync(token).ConfigureAwait(false))
                {
                    while (await reader.ReadAsync(token).ConfigureAwait(false))
                    {
                        var rn = reader[0].ToString().Trim();
                        var number = Convert.ToInt32(reader[1].ToString().Trim());
                        var mnemo = reader[2].ToString().Trim();
                        var name = reader[3].ToString().Trim();

                        result.Add(new TypeOfDay()
                        {
                            TypeDayRn = rn,
                            Number = number,
                            Memo = mnemo,
                            Name = name
                        });
                    }
                }
            }

            return result;
        }
    }
}
