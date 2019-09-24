using EmployeeReportBL.Enumeration;

namespace EmployeeReportBL.Model
{
    public class Accrual
    {
        /// <summary>
        /// Уникальный идентификатор лицевого счета.
        /// </summary>
        public string FcacRn { get; set; }

        /// <summary>
        /// Мнемокод.
        /// </summary>
        public string Mnemo { get; set; }

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
        /// Сторно.
        /// </summary>
        public bool Storno { get; set; }
    }
}
