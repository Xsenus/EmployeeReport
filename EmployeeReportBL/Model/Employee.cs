﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        /// OID структурного подразделения
        /// </summary>
        [DisplayName("OID структурного подразделения")]
        public string SubdivisionOid{ get; set; }

        /// <summary>
        /// Ставка
        /// </summary>
        [DisplayName("Ставка")]
        public string Rate { get; set; }

        string snails;
        /// <summary>
        /// СНИЛС.
        /// </summary>
        [DisplayName("СНИЛС"), DataType(DataType.Text)]
        public string Snails
        {
            get
            {
                return snails;
            }
            set
            {
                var result = value.Replace("-", "").Replace(" ", "").Trim();

                if (!string.IsNullOrWhiteSpace(result))
                {
                    if (result.Length != 11)
                    {
                        while (result.Length != 11)
                        {
                            result = snails.Insert(0, "0");
                        }
                    }

                    snails = result;
                }
                else
                {
                    snails = string.Empty;
                }
            }
        }

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
        /// Норма рабочего времени.
        /// </summary>
        [DisplayName("Норма рабочего времени")]
        public decimal? WorkingTime { get; set; }

        /// <summary>
        /// Фактическое количество отработанного времени.
        /// </summary>
        [DisplayName("Отработанное время")]
        public decimal? ActualHoursWorked { get; set; }

        /// <summary>
        /// Должностной оклад.
        /// </summary>
        //[DisplayName("Должностной оклад")]
        //public decimal OfficialSalary { get; set; }

        /// <summary>
        /// Начисления и удержания.
        /// </summary>
        public List<Accrual> Accruals { get; set; }

        /// <summary>
        /// ФОТ.
        /// </summary>
        public List<Payroll> Payroll { get; set; }
    }
}