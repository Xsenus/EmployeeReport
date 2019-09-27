using EmployeeReportBL.Enumeration;

namespace EmployeeReportBL.Model
{
    public class Accrual
    {
        /// <summary>
        /// Уникальный идентификатор лицевого счета в FoxPro.
        /// </summary>
        public string EmployeeId { get; set; }

        /// <summary>
        /// Мнемокод.
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Год.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Месяц.
        /// </summary>
        public Month Month { get; set; }

        /// <summary>
        /// Вид расчета.
        /// </summary>
        public string TypeOfCalculation { get; set; }
    }
}
