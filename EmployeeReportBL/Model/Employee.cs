using System.Collections.Generic;
using System.ComponentModel;

namespace EmployeeReportBL.Model
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public string rn;

        /// <summary>
        /// Имя.
        /// </summary>
        [DisplayName("Имя")]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        /// <summary>
        /// Подразделение.
        /// </summary>
        [DisplayName("Подразделение")]
        public string Subdivision { get; set; }

        /// <summary>
        /// СНИЛС.
        /// </summary>
        [DisplayName("СНИЛС")]
        public string Snails { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        [DisplayName("Должность")]
        public string Position { get; set; }

        /// <summary>
        /// Тип лицевого счета.
        /// </summary>
        [DisplayName("Тип ЛС")]
        public string TypePersonalAccount { get; set; }

        /// <summary>
        /// Источник финансирования.
        /// </summary>
        [DisplayName("Источник финансирования")]
        public string SourceOfFinancing { get; set; }

        /// <summary>
        /// Норма рабочего времени.
        /// </summary>
        [DisplayName("Норма рабочего времени")]
        public decimal WorkingTime { get; set; }

        /// <summary>
        /// Фактическое количество отработанного времени.
        /// </summary>
        [DisplayName("Отработанное время")]
        public decimal ActualHoursWorked { get; set; }

        /// <summary>
        /// Должностной оклад.
        /// </summary>
        [DisplayName("Должностной оклад")]
        public decimal OfficialSalary { get; set; }

        /// <summary>
        /// Начисления и удержания.
        /// </summary>
        public List<Accrual> Accruals { get; set; }
    }
}