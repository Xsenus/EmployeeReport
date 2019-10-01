namespace EmployeeReportBL.Model
{
    /// <summary>
    /// Типы дней.
    /// </summary>
    public class TypeOfDay
    {
        /// <summary>
        /// Уникальный идентификатор типа дня.
        /// </summary>
        public string TypeDayRn { get; set; }

        /// <summary>
        /// Номер.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Мнемокод.
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{TypeDayRn} | {Name}";
        }
    }
}
