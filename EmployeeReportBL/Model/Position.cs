using System.ComponentModel;

namespace EmployeeReportBL.Model
{
    /// <summary>
    /// Должность.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public string Rn { get; set; }

        /// <summary>
        /// Номер должности.
        /// </summary>
        [DisplayName("Номер")]
        public int Number { get; set; }

        /// <summary>
        /// Мнемокод должности.
        /// </summary>
        [DisplayName("Мнемокод")]
        public string Mnemo { get; set; }

        /// <summary>
        /// Наименование должности.
        /// </summary>
        [DisplayName("Наименование")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Mnemo;
        }
    }
}
