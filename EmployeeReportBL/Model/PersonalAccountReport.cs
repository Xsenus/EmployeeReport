using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EmployeeReportBL.Model
{
    /// <summary>
    /// Отчет по лицевым счетам.
    /// </summary>
    public class PersonalAccountReport
    {
        private List<Employee> Employees { get; set; }

        public PersonalAccountReport() { }

        public PersonalAccountReport(List<Employee> employees)
        {
            Employees = employees;
        }

        /// <summary>
        /// Регион.
        /// </summary>
        [DisplayName("Регион")]
        public string Region { get; set; }

        /// <summary>
        /// Полное наименование МО.
        /// </summary>
        [DisplayName("Полное наименование МО")]
        public string Organization { get; set; }

        /// <summary>
        /// Подразделение.
        /// </summary>
        [DisplayName("Подразделение")]
        public string Subdivision { get; set; }

        /// <summary>
        /// Месяц.
        /// </summary>
        [DisplayName("Месяц")]
        public string Month { get; set; }

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
        [DisplayName("Лицевой счет")]
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
        public decimal? WorkingTime { get; set; }

        /// <summary>
        /// Фактическое количество отработанного времени.
        /// </summary>
        [DisplayName("Отработанное время")]
        public decimal? ActualHoursWorked { get; set; }

        /// <summary>
        /// Должностной оклад.
        /// </summary>
        [DisplayName("Должностной оклад")]
        public decimal? OfficialSalary { get; set; }

        /// <summary>
        /// Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.
        /// </summary>
        [DisplayName("Тяжелые и вредные работы")]
        public decimal? SeverePayments { get; set; }

        /// <summary>
        /// Районный коэффициент.
        /// </summary>
        [DisplayName("Районный коэффициент")]
        public decimal? DistrictCoefficient { get; set; }

        /// <summary>
        /// Коэффициент за работу в пустынных и безводных местностях.
        /// </summary>
        [DisplayName("Пустыни и безводные участки")]
        public decimal? CoefficientWorkDesertAndWaterlessAreas { get; set; }

        /// <summary>
        /// Коэффициент за работу в высокогорных районах.
        /// </summary>
        [DisplayName("Высокогорье")]
        public decimal? CoefficientWorkHighMountainRegions { get; set; }

        /// <summary>
        /// Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.
        /// </summary>
        [DisplayName("Крайний север")]
        public decimal? AllowanceWorkExperienceNorthEquivalentAreas { get; set; }

        /// <summary>
        /// Доплата за совмещение профессий (должностей).
        /// </summary>
        [DisplayName("Совмещение")]
        public decimal? SupplementCombiningProfessions { get; set; }

        /// <summary>
        /// Доплата за работу в сельской местности.
        /// </summary>
        [DisplayName("Сельская местность")]
        public decimal? SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Доплата за расширение зон обслуживания.
        /// </summary>
        [DisplayName("Расширение зон обслуживания")]
        public decimal? SurchargeExpansionServiceAreas { get; set; }

        /// <summary>
        /// Доплата за увеличение объема работы.
        /// </summary>
        [DisplayName("Объем работ")]
        public decimal? SurchargeIncreasingAmountWork { get; set; }

        /// <summary>
        /// Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.
        /// </summary>
        [DisplayName("Отсутствующий работник")]
        public decimal? SupplementPerformanceDutiesTemporarilyAbsentEmployee { get; set; }

        /// <summary>
        /// Доплата за выполнение работ различной квалификации.
        /// </summary>
        [DisplayName("Различная квалификация работы")]
        public decimal? SurchargePerformanceWorkVariousQualifications { get; set; }

        /// <summary>
        /// Доплата за работу в выходные и праздничные дни.
        /// </summary>
        [DisplayName("Выходные и праздничные")]
        public decimal? WeekendAndHolidaysWorkSupplement { get; set; }

        /// <summary>
        /// Доплата за работу в ночное время.
        /// </summary>
        [DisplayName("Ночное время")]
        public decimal? SurchargeNightWork { get; set; }

        /// <summary>
        /// Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.
        /// </summary>
        [DisplayName("Гос тайна")]
        public decimal? AllowanceWorkInformationConstituting { get; set; }

        /// <summary>
        /// Иные выплаты компенсационного характера.
        /// </summary>
        [DisplayName("Компенсация")]
        public decimal? OtherCompensatoryPayments { get; set; }

        /// <summary>
        /// Надбавка за интенсивность труда.
        /// </summary>
        [DisplayName("Интенсивность труда")]
        public decimal? LaborAllowance { get; set; }

        /// <summary>
        /// Премия за высокие результаты работы.
        /// </summary>
        [DisplayName("Высокие результаты")]
        public decimal? PerformanceAward { get; set; }

        /// <summary>
        /// Премия за выполнение особо важных и ответственных работ.
        /// </summary>
        [DisplayName("Особо важная работа")]
        public decimal? AwardPerformanceParticularlyImportantResponsibleWork { get; set; }

        /// <summary>
        /// Надбавка за наличие квалификационной категории.
        /// </summary>
        [DisplayName("Квалификационная категория")]
        public decimal? QualificationAllowance { get; set; }

        /// <summary>
        /// Премия за образцовое выполнение государственного (муниципального) задания.
        /// </summary>
        [DisplayName("Муниципальное задание")]
        public decimal? PremiumExemplaryPerformanceStateAssignment { get; set; }

        /// <summary>
        /// надбавка за выслугу лет в организации
        /// </summary>
        [DisplayName("Выслуга лет")]
        public decimal? OrganizationServiceBonus { get; set; }

        /// <summary>
        /// Надбавка за стаж непрерывной работы (медицинский стаж).
        /// </summary>
        [DisplayName("Непрерывный стаж")]
        public decimal? AllowanceContinuousWorkExperience { get; set; }

        /// <summary>
        /// Премия по итогам работы за месяц
        /// </summary>
        [DisplayName("Премия за месяц")]
        public decimal? MonthlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за квартал.
        /// </summary>
        [DisplayName("Премия за квартал")]
        public decimal? QuarterlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за год.
        /// </summary>
        [DisplayName("Премия за год")]
        public decimal? AnnualPerformanceBonus { get; set; }

        /// <summary>
        /// Надбавка молодому специалисту.
        /// </summary>
        [DisplayName("Молодой специалист")]
        public decimal? PremiumYoungSpecialist { get; set; }

        /// <summary>
        /// Надбавка за почётное звание.
        /// </summary>
        [DisplayName("Звание")]
        public decimal? HonoraryBonus { get; set; }

        /// <summary>
        /// Надбавка за наличие учёной степени.
        /// </summary>
        [DisplayName("Ученая степень")]
        public decimal? GraduateBonus { get; set; }

        /// <summary>
        /// Доплата за работу в сельской местности.
        /// </summary>
        [DisplayName("Сельская местность2")]
        public decimal? SurchargeWorkRuralAreas2 { get; set; }

        /// <summary>
        /// Надбавка за участки.
        /// </summary>
        [DisplayName("Участки")]
        public decimal? AllowanceForPrecinct { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера.
        /// </summary>
        [DisplayName("Стимулирующая")]
        public decimal? OtherIncentivePayments { get; set; }

        /// <summary>
        /// Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер 
        /// в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.
        /// </summary>
        [DisplayName("Не отработанное время")]
        public decimal? PaymentUnWorkedTimeAndOtherPayments { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        public List<PersonalAccountReport> GetPersonalAccountReport(Month month)
        {
            var result = new List<PersonalAccountReport>();

            var employee = new List<Employee>();

            if (ReportSettings.settings.Positions == null || ReportSettings.settings.Positions.Count == 0)
            {
                employee = Employees;
            }
            else
            {
                employee = Employees.Where(w => ReportSettings.settings.Positions.Contains(w.Position)).ToList();
            }

            if (ReportSettings.settings.TypeOfCalculations == null || ReportSettings.settings.TypeOfCalculations.Count == 0)
            {
                AddPersonalAccountReport(month, result, employee);
            }
            else
            {
                for (int i = 0; i < ReportSettings.settings.TypeOfCalculations.Count; i++)
                {
                    var employeeTypeOfCalculations = employee.Where(w => w.Accruals.Where(type => string.Compare(ReportSettings.settings.TypeOfCalculations[i], type.TypeOfCalculation, StringComparison.Ordinal) == 0) != null).ToList();
                    AddPersonalAccountReport(month, result, employeeTypeOfCalculations, ReportSettings.settings.TypeOfCalculations[i]);
                }

                AddPersonalAccountReport(month, result, employee);
            }

            return result;
        }

        private static void AddPersonalAccountReport(Month month, List<PersonalAccountReport> result, List<Employee> employee, string typeOfCalculations = null)
        {
            foreach (var item in employee)
            {
                if (!item.Accruals.Any())
                {
                    continue;
                }

                var accrual = (string.IsNullOrEmpty(typeOfCalculations) ? item.Accruals : item.Accruals.Where(w => string.Compare(w.TypeOfCalculation, typeOfCalculations, StringComparison.Ordinal) == 0).ToList());

                if (accrual.Count == 0)
                {
                    continue;
                }

                var officialSalary = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.OfficialSalary, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var severePayments = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SeverePayments, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var districtCoefficient = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.DistrictCoefficient, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var coefficientWorkDesertAndWaterlessAreas = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.CoefficientWorkDesertAndWaterlessAreas, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var coefficientWorkHighMountainRegions = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.CoefficientWorkHighMountainRegions, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var allowanceWorkExperienceNorthEquivalentAreas = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AllowanceWorkExperienceNorthEquivalentAreas, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var supplementCombiningProfessions = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SupplementCombiningProfessions, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargeWorkRuralAreas = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargeWorkRuralAreas, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargeExpansionServiceAreas = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargeExpansionServiceAreas, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargeIncreasingAmountWork = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargeIncreasingAmountWork, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var supplementPerformanceDutiesTemporarilyAbsentEmployee = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SupplementPerformanceDutiesTemporarilyAbsentEmployee, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargePerformanceWorkVariousQualifications = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargePerformanceWorkVariousQualifications, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var weekendAndHolidaysWorkSupplement = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.WeekendAndHolidaysWorkSupplement, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargeNightWork = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargeNightWork, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var allowanceWorkInformationConstituting = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AllowanceWorkInformationConstituting, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var otherCompensatoryPayments = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.OtherCompensatoryPayments, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var laborAllowance = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.LaborAllowance, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var performanceAward = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.PerformanceAward, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var awardPerformanceParticularlyImportantResponsibleWork = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AwardPerformanceParticularlyImportantResponsibleWork, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var qualificationAllowance = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.QualificationAllowance, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var premiumExemplaryPerformanceStateAssignment = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.PremiumExemplaryPerformanceStateAssignment, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var organizationServiceBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.OrganizationServiceBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var allowanceContinuousWorkExperience = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AllowanceContinuousWorkExperience, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var monthlyPerformanceBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.MonthlyPerformanceBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var quarterlyPerformanceBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.QuarterlyPerformanceBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var annualPerformanceBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AnnualPerformanceBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var premiumYoungSpecialist = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.PremiumYoungSpecialist, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var honoraryBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.HonoraryBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var graduateBonus = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.GraduateBonus, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var surchargeWorkRuralAreas2 = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.SurchargeWorkRuralAreas, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var allowanceForPrecinct = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.AllowanceForPrecinct, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var otherIncentivePayments = accrual?.Where(w => ReportSettings.settings.OtherIncentivePayments.Contains(w.Memo))?.Sum(s => s.Value);
                var paymentUnWorkedTimeAndOtherPayments = accrual?.Where(w => string.Compare(w.Memo, ReportSettings.settings.PaymentUnWorkedTimeAndOtherPayments, StringComparison.Ordinal) == 0)?.Sum(s => s.Value);
                var name = $"{item.Name} {item.Surname} {item.Patronymic}";

                var sourceOfFinancing = (typeOfCalculations == null) ? item.SourceOfFinancing : typeOfCalculations;

                result.Add(new PersonalAccountReport()
                {
                    Region = ReportSettings.settings.region,
                    Organization = ReportSettings.settings.organization,
                    Subdivision = item.Subdivision,
                    Month = month.GetDescription(),
                    Snails = item.Snails,
                    Position = item.Position,
                    TypePersonalAccount = item.TypePersonalAccount,
                    SourceOfFinancing = sourceOfFinancing,
                    WorkingTime = item.WorkingTime,
                    ActualHoursWorked = item.ActualHoursWorked,
                    OfficialSalary = officialSalary == 0 ? null : officialSalary,
                    SeverePayments = severePayments == 0 ? null : severePayments,
                    DistrictCoefficient = districtCoefficient == 0 ? null : districtCoefficient,
                    CoefficientWorkDesertAndWaterlessAreas = coefficientWorkDesertAndWaterlessAreas == 0 ? null : coefficientWorkDesertAndWaterlessAreas,
                    CoefficientWorkHighMountainRegions = coefficientWorkHighMountainRegions == 0 ? null : coefficientWorkHighMountainRegions,
                    AllowanceWorkExperienceNorthEquivalentAreas = allowanceWorkExperienceNorthEquivalentAreas == 0 ? null : allowanceWorkExperienceNorthEquivalentAreas,
                    SupplementCombiningProfessions = supplementCombiningProfessions == 0 ? null : supplementCombiningProfessions,
                    SurchargeWorkRuralAreas = surchargeWorkRuralAreas == 0 ? null : surchargeWorkRuralAreas,
                    SurchargeExpansionServiceAreas = surchargeExpansionServiceAreas == 0 ? null : surchargeExpansionServiceAreas,
                    SurchargeIncreasingAmountWork = surchargeIncreasingAmountWork == 0 ? null : surchargeIncreasingAmountWork,
                    SupplementPerformanceDutiesTemporarilyAbsentEmployee = supplementPerformanceDutiesTemporarilyAbsentEmployee == 0 ? null : supplementPerformanceDutiesTemporarilyAbsentEmployee,
                    SurchargePerformanceWorkVariousQualifications = surchargePerformanceWorkVariousQualifications == 0 ? null : surchargePerformanceWorkVariousQualifications,
                    WeekendAndHolidaysWorkSupplement = weekendAndHolidaysWorkSupplement == 0 ? null : weekendAndHolidaysWorkSupplement,
                    SurchargeNightWork = surchargeNightWork == 0 ? null : surchargeNightWork,
                    AllowanceWorkInformationConstituting = allowanceWorkInformationConstituting == 0 ? null : allowanceWorkInformationConstituting,
                    OtherCompensatoryPayments = otherCompensatoryPayments == 0 ? null : otherCompensatoryPayments,
                    LaborAllowance = laborAllowance == 0 ? null : laborAllowance,
                    PerformanceAward = performanceAward == 0 ? null : performanceAward,
                    AwardPerformanceParticularlyImportantResponsibleWork = awardPerformanceParticularlyImportantResponsibleWork == 0 ? null : awardPerformanceParticularlyImportantResponsibleWork,
                    QualificationAllowance = qualificationAllowance == 0 ? null : qualificationAllowance,
                    PremiumExemplaryPerformanceStateAssignment = premiumExemplaryPerformanceStateAssignment == 0 ? null : premiumExemplaryPerformanceStateAssignment,
                    OrganizationServiceBonus = organizationServiceBonus == 0 ? null : organizationServiceBonus,
                    AllowanceContinuousWorkExperience = allowanceContinuousWorkExperience == 0 ? null : allowanceContinuousWorkExperience,
                    MonthlyPerformanceBonus = monthlyPerformanceBonus == 0 ? null : monthlyPerformanceBonus,
                    QuarterlyPerformanceBonus = quarterlyPerformanceBonus == 0 ? null : quarterlyPerformanceBonus,
                    AnnualPerformanceBonus = annualPerformanceBonus == 0 ? null : annualPerformanceBonus,
                    PremiumYoungSpecialist = premiumYoungSpecialist == 0 ? null : premiumYoungSpecialist,
                    HonoraryBonus = honoraryBonus == 0 ? null : honoraryBonus,
                    GraduateBonus = graduateBonus == 0 ? null : graduateBonus,
                    SurchargeWorkRuralAreas2 = surchargeWorkRuralAreas2 == 0 ? null : surchargeWorkRuralAreas2,
                    AllowanceForPrecinct = allowanceForPrecinct == 0 ? null : allowanceForPrecinct,
                    OtherIncentivePayments = otherIncentivePayments == 0 ? null : otherIncentivePayments,
                    PaymentUnWorkedTimeAndOtherPayments = paymentUnWorkedTimeAndOtherPayments == 0 ? null : paymentUnWorkedTimeAndOtherPayments,
                    Name = name
                });

                if (!string.IsNullOrEmpty(typeOfCalculations))
                {
                    item.Accruals.RemoveAll(r => string.Compare(r.TypeOfCalculation, typeOfCalculations, StringComparison.Ordinal) == 0);
                }
            }
        }
    }
}
