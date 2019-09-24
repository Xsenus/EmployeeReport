using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeReportBL.Model
{
    /// <summary>
    /// Отчет по лицевым счетам.
    /// </summary>
    public class PersonalAccountReport
    {
        private Month month;
        private List<Employee> employees;
        private int year;

        public PersonalAccountReport() { }

        public PersonalAccountReport(List<Employee> employees, Month month, int year)
        {
            this.employees = employees;
            this.month = month;
            this.year = year;
        }

        /// <summary>
        /// Регион.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Полное наименование МО.
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// Подразделение.
        /// </summary>
        public string Subdivision { get; set; }

        /// <summary>
        /// Месяц.
        /// </summary>
        public string Month { get; set; }

        /// <summary>
        /// СНИЛС.
        /// </summary>
        public string Snails { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Тип лицевого счета.
        /// </summary>
        public string TypePersonalAccount { get; set; }

        /// <summary>
        /// Источник финансирования.
        /// </summary>
        public string SourceOfFinancing { get; set; }

        /// <summary>
        /// Норма рабочего времени.
        /// </summary>
        public decimal WorkingTime { get; set; }

        /// <summary>
        /// Фактическое количество отработанного времени.
        /// </summary>
        public decimal? ActualHoursWorked { get; set; }

        /// <summary>
        /// Должностной оклад.
        /// </summary>
        public decimal? OfficialSalary { get; set; }

        /// <summary>
        /// Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.
        /// </summary>
        public decimal? SeverePayments { get; set; }

        /// <summary>
        /// Районный коэффициент.
        /// </summary>
        public decimal? DistrictCoefficient { get; set; }

        /// <summary>
        /// Коэффициент за работу в пустынных и безводных местностях.
        /// </summary>
        public decimal? CoefficientWorkDesertAndWaterlessAreas { get; set; }

        /// <summary>
        /// Коэффициент за работу в высокогорных районах.
        /// </summary>
        public decimal? CoefficientWorkHighMountainRegions { get; set; }

        /// <summary>
        /// Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.
        /// </summary>
        public decimal? AllowanceWorkExperienceNorthEquivalentAreas { get; set; }

        /// <summary>
        /// Доплата за совмещение профессий (должностей).
        /// </summary>
        public decimal? SupplementCombiningProfessions { get; set; }

        /// <summary>
        /// Доплата за работу в сельской местности.
        /// </summary>
        public decimal? SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Доплата за расширение зон обслуживания.
        /// </summary>
        public decimal? SurchargeExpansionServiceAreas { get; set; }

        /// <summary>
        /// Доплата за увеличение объема работы.
        /// </summary>
        public decimal? SurchargeIncreasingAmountWork { get; set; }

        /// <summary>
        /// Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.
        /// </summary>
        public decimal? SupplementPerformanceDutiesTemporarilyAbsentEmployee { get; set; }

        /// <summary>
        /// Доплата за выполнение работ различной квалификации.
        /// </summary>
        public decimal? SurchargePerformanceWorkVariousQualifications { get; set; }

        /// <summary>
        /// Доплата за работу в выходные и праздничные дни.
        /// </summary>
        public decimal? WeekendAndHolidaysWorkSupplement { get; set; }

        /// <summary>
        /// Доплата за работу в ночное время.
        /// </summary>
        public decimal? SurchargeNightWork { get; set; }

        /// <summary>
        /// Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.
        /// </summary>
        public decimal? AllowanceWorkInformationConstituting { get; set; }

        /// <summary>
        /// Иные выплаты компенсационного характера.
        /// </summary>
        public decimal? OtherCompensatoryPayments { get; set; }

        /// <summary>
        /// Надбавка за интенсивность труда.
        /// </summary>
        public decimal? LaborAllowance { get; set; }

        /// <summary>
        /// Премия за высокие результаты работы.
        /// </summary>
        public decimal? PerformanceAward { get; set; }

        /// <summary>
        /// Премия за выполнение особо важных и ответственных работ.
        /// </summary>
        public decimal? AwardPerformanceParticularlyImportantResponsibleWork { get; set; }

        /// <summary>
        /// Надбавка за наличие квалификационной категории.
        /// </summary>
        public decimal? QualificationAllowance { get; set; }

        /// <summary>
        /// Премия за образцовое выполнение государственного (муниципального) задания.
        /// </summary>
        public decimal? PremiumExemplaryPerformanceStateAssignment { get; set; }

        /// <summary>
        /// надбавка за выслугу лет в организации
        /// </summary>
        public decimal? OrganizationServiceBonus { get; set; }

        /// <summary>
        /// Надбавка за стаж непрерывной работы (медицинский стаж).
        /// </summary>
        public decimal? AllowanceContinuousWorkExperience { get; set; }

        /// <summary>
        /// Премия по итогам работы за месяц
        /// </summary>
        public decimal? MonthlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за квартал.
        /// </summary>
        public decimal? QuarterlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за год.
        /// </summary>
        public decimal? AnnualPerformanceBonus { get; set; }

        /// <summary>
        /// Надбавка молодому специалисту.
        /// </summary>
        public decimal? PremiumYoungSpecialist { get; set; }

        /// <summary>
        /// Надбавка за почётное звание.
        /// </summary>
        public decimal? HonoraryBonus { get; set; }

        /// <summary>
        /// Надбавка за наличие учёной степени.
        /// </summary>
        public decimal? GraduateBonus { get; set; }

        // TODO: Такая выплата есть выше. Чем различаются?
        //public decimal? SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Надбавка за участки.
        /// </summary>
        public decimal? AllowanceForPrecinct { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера.
        /// </summary>
        public decimal? OtherIncentivePayments { get; set; }

        /// <summary>
        /// Оплата за неотработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер 
        /// в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.
        /// </summary>
        public decimal? PaymentUnWorkedTimeAndOtherPayments { get; set; }

        public List<PersonalAccountReport> GetReport()
        {
            var result = new List<PersonalAccountReport>();

            foreach (var item in employees)
            {
                if (item.Accruals.Where(w => w.Year == year && w.Month == month).FirstOrDefault() == null)
                {
                    continue;
                }

                result.Add(new PersonalAccountReport()
                {
                    Region = ReportSettings.settings.region,
                    Organization = ReportSettings.settings.organization,
                    Subdivision = item.Subdivision,
                    Month = month.GetDescription(),
                    Snails = item.Snails,
                    Position = item.Position,
                    TypePersonalAccount = item.TypePersonalAccount,
                    SourceOfFinancing = item.SourceOfFinancing,
                    WorkingTime = item.WorkingTime,
                    ActualHoursWorked = item.ActualHoursWorked,
                    OfficialSalary = item.OfficialSalary,
                    SeverePayments = item.Accruals.Where(w => w.Mnemo == ReportSettings.settings.SeverePayments)?.Sum(s => s.Value),
                    DistrictCoefficient = item.Accruals.Where(w => w.Mnemo == ReportSettings.settings.DistrictCoefficient && w.Year == year && w.Month == month)?.Sum(s => s.Value),
                });
            }            

            return result;
        }
    }
}
