
namespace EmployeeReportBL
{
    /// <summary>
    /// Выплаты и удержания.
    /// </summary>
    public class Pay
    {
        /// <summary>
        /// Уникальный модификатор FoxPro
        /// </summary>
        public string Rn { get; set; }

        /// <summary>
        /// Номер.
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Мнемокод.
        /// </summary>
        public string Mnemo { get; set; }

        /// <summary>
        /// Наименование.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Сокращенное наименование.
        /// </summary>
        public string AbbreviatedName { get; set; }

        public override string ToString()
        {
            return Mnemo; 
        }
    }
}
