using System;

namespace EmployeeReportBL.Model
{
    public class Payroll
    {
        /// <summary>
        /// Уникальный идентификатор лицевого счета.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Мнемокод.
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Значение.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Дата с..
        /// </summary>
        public DateTime DateSince { get; set; }

        /// <summary>
        /// Дата по..
        /// </summary>
        public DateTime DateTo { get; set; }
    }
}
