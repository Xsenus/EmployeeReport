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
        private bool IsAllEmployees;
        private bool IsRegion;
        private bool flagZeroCharges;
        private List<Employee> Employees { get; set; }

        public PersonalAccountReport() { }

        public PersonalAccountReport(List<Employee> employees, bool flagZeroCharges, bool isAllEmployees, bool isRegion)
        {
            Employees = employees;
            this.flagZeroCharges = flagZeroCharges;
            IsAllEmployees = isAllEmployees;
            IsRegion = isRegion;
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
        /// OID медицинской организации.
        /// </summary>
        [DisplayName("OID медицинской организации")]
        public string OrganizationOid { get; set; }

        /// <summary>
        /// Подразделение.
        /// </summary>
        [DisplayName("Подразделение")]
        public string Subdivision { get; set; }

        /// <summary>
        /// OID структурного подразделения.
        /// </summary>
        [DisplayName("OID структурного подразделения")]
        public string SubdivisionOid { get; set; }

        /// <summary>
        /// Месяц.
        /// </summary>
        [DisplayName("Месяц")]
        public string Month { get; set; }

        /// <summary>
        /// Год.
        /// </summary>
        [DisplayName("Год")]
        public string Year { get; set; }

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
        /// Ставка
        /// </summary>
        [DisplayName("Ставка")]
        public string Rate { get; set; }

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
        /// Фактическое количество отработанного времени  для начисления выплат по ПП РФ 415 (часы)
        /// </summary>
        [DisplayName("ПП РФ 415 (часы)")]
        public decimal? ActualHoursWorkedPP415 { get; set; }

        /// <summary>
        /// Фактическое количество отработанного времени  для начисления выплат по ПП РФ 415 (часы)
        /// </summary>
        [DisplayName("ПП РФ 484 (часы)")]
        public decimal? ActualHoursWorkedPP484 { get; set; }

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
        /// Иные выплаты компенсационного характера, установленные субъектом Российской Федерации.
        /// </summary>
        [DisplayName("Компенсация установленная субъектом РФ")]
        public decimal? OtherCompensatoryPaymentsSubjectRussianFederation { get; set; }

        /// <summary>
        /// Иные выплаты компенсационного характера, установленные учреждением.
        /// </summary>
        [DisplayName("Компенсация установленная учреждением")]
        public decimal? OtherCompensatoryPaymentsEntity { get; set; }

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

        ///// <summary>
        ///// Надбавка за участки.
        ///// </summary>
        //[DisplayName("Участки")]
        //public decimal? AllowanceForPrecinct { get; set; }

        /// <summary>
        /// Надбавка врачам терапевтам (педиатрам) участковым, врачам общей практики и их медсестрам.
        /// </summary>
        [DisplayName("Надбавки врачам")]
        public decimal? MedicalAllowance { get; set; }

        /// <summary>
        /// Работу в пустынях и безводных местностях ПП РФ 415.
        /// </summary>
        [DisplayName("Работу в пустынях и безводных местностях ПП РФ 415")]
        public decimal? CoefficientWorkDesertAndWaterlessAreas415 { get; set; }

        /// <summary>
        /// Работа в районах Крайнего Севера ПП РФ 415.
        /// </summary>
        [DisplayName("Работа в районах Крайнего Севера ПП РФ 415")]
        public decimal? AllowanceWorkExperienceNorthEquivalentAreas415 { get; set; }

        /// <summary>
        /// Выплата стимулирующего характера ПП РФ 415.
        /// </summary>
        [DisplayName("Выплата стимулирующего характера ПП РФ 415")]
        public decimal? IncentivePayment415 { get; set; }

        /// <summary>
        /// Сумма страховых взносов с выплат стимулирующего характера ПП РФ 415.
        /// </summary>
        [DisplayName("Сумма страховых взносов с выплат стимулирующего характера ПП РФ 415")]
        public decimal? SummaIncentivePayment415 { get; set; }

        /// <summary>
        /// Работу в пустынях и безводных местностях ПП РФ 484.
        /// </summary>
        [DisplayName("Работу в пустынях и безводных местностях ПП РФ 484")]
        public decimal? CoefficientWorkDesertAndWaterlessAreas484 { get; set; }

        /// <summary>
        /// Выплата стимулирующего характера ПП РФ 484.
        /// </summary>
        [DisplayName("Выплата стимулирующего характера ПП РФ 484")]
        public decimal? IncentivePayment484 { get; set; }

        /// <summary>
        /// Сумма страховых взносов с выплат стимулирующего характера ПП РФ 484.
        /// </summary>
        [DisplayName("Сумма страховых взносов с выплат стимулирующего характера ПП РФ 484")]
        public decimal? SummaIncentivePayment484 { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера.
        /// </summary>
        [DisplayName("Стимулирующая")]
        public decimal? OtherIncentivePayments { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера, установленные субъектом Российской Федерации.
        /// </summary>
        [DisplayName("Стимулирующая установленная субъектом РФ")]
        public decimal? OtherIncentivePaymentsSubjectRussianFederation { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера, установленные учреждением.
        /// </summary>
        [DisplayName("Стимулирующая установленная учреждением")]
        public decimal? OtherIncentivePaymentsEntity { get; set; }

        /// <summary>
        /// Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер 
        /// в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.
        /// </summary>
        [DisplayName("Не отработанное время")]
        public decimal? PaymentUnWorkedTimeAndOtherPayments { get; set; }

        /// <summary>
        /// Единовременные поощрительные выплаты.
        /// </summary>
        [DisplayName("Единовременные поощрительные выплаты")]
        public decimal? OneTimeIncentivePayments { get; set; }

        /// <summary>
        /// Выплата стимулирующего характера за особые условия труда и дополнительную нагрузку медицинским работникам, оказывающим медицинскую помощь гражданам, 
        /// у которых выявлена новая коронавирусная инфекция, и лицам из групп риска заражения новой коронавирусной инфекцией 
        /// (в соответствии с постановлениями Правительства Российской Федерации № 415 от 2 апреля 2020 г. и № 484 от 12 апреля 2020 г.)
        /// </summary>
        [DisplayName("Covid19")]
        public decimal? Covid19 { get; set; }

        [DisplayName("ФИО")]
        public string Name { get; set; }

        public List<PersonalAccountReport> GetPersonalAccountReport(Month month, int year)
        {
            var result = new List<PersonalAccountReport>();

            var employee = new List<Employee>();

            if (IsAllEmployees || ReportSettings.settings.Positions == null || ReportSettings.settings.Positions.Count == 0)
            {
                employee = Employees;
            }
            else
            {
                employee = Employees.Where(w => ReportSettings.settings.Positions.Contains(w.Position)).ToList();
            }

            if (ReportSettings.settings.TypeOfCalculations == null || ReportSettings.settings.TypeOfCalculations.Count == 0)
            {
                AddPersonalAccountReport(month, result, employee, flagZeroCharges, year, IsRegion);
            }
            else
            {
                for (int i = 0; i < ReportSettings.settings.TypeOfCalculations.Count; i++)
                {
                    var employeeTypeOfCalculations = employee.Where(w => w.Accruals.Where(type => string.Compare(ReportSettings.settings.TypeOfCalculations[i], type.TypeOfCalculation, StringComparison.Ordinal) == 0) != null).ToList();
                    AddPersonalAccountReport(month, result, employeeTypeOfCalculations, flagZeroCharges, year, IsRegion, ReportSettings.settings.TypeOfCalculations[i]);
                }

                AddPersonalAccountReport(month, result, employee, flagZeroCharges, year, IsRegion);
            }

            return result.OrderBy(u => u.Name).ToList();
        }

        private static void AddPersonalAccountReport(Month month, 
            List<PersonalAccountReport> result, 
            List<Employee> employee, 
            bool flagZeroCharges, 
            int year, 
            bool isRegion,
            string typeOfCalculations = null)
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

                var officialSalary = accrual?.Where(w => ReportSettings.settings.OfficialSalary.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var severePayments = accrual?.Where(w => ReportSettings.settings.SeverePayments.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var districtCoefficient = accrual?.Where(w => ReportSettings.settings.DistrictCoefficient.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var coefficientWorkDesertAndWaterlessAreas = accrual?.Where(w => ReportSettings.settings.CoefficientWorkDesertAndWaterlessAreas.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var coefficientWorkHighMountainRegions = accrual?.Where(w => ReportSettings.settings.CoefficientWorkHighMountainRegions.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var allowanceWorkExperienceNorthEquivalentAreas = accrual?.Where(w => ReportSettings.settings.AllowanceWorkExperienceNorthEquivalentAreas.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var supplementCombiningProfessions = accrual?.Where(w => ReportSettings.settings.SupplementCombiningProfessions.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargeWorkRuralAreas = accrual?.Where(w => ReportSettings.settings.SurchargeWorkRuralAreas.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargeExpansionServiceAreas = accrual?.Where(w => ReportSettings.settings.SurchargeExpansionServiceAreas.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargeIncreasingAmountWork = accrual?.Where(w => ReportSettings.settings.SurchargeIncreasingAmountWork.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var supplementPerformanceDutiesTemporarilyAbsentEmployee = accrual?.Where(w => ReportSettings.settings.SupplementPerformanceDutiesTemporarilyAbsentEmployee.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargePerformanceWorkVariousQualifications = accrual?.Where(w => ReportSettings.settings.SurchargePerformanceWorkVariousQualifications.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var weekendAndHolidaysWorkSupplement = accrual?.Where(w => ReportSettings.settings.WeekendAndHolidaysWorkSupplement.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargeNightWork = accrual?.Where(w => ReportSettings.settings.SurchargeNightWork.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var allowanceWorkInformationConstituting = accrual?.Where(w => ReportSettings.settings.AllowanceWorkInformationConstituting.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var otherCompensatoryPayments = accrual?.Where(w => ReportSettings.settings.OtherCompensatoryPayments.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var laborAllowance = accrual?.Where(w => ReportSettings.settings.LaborAllowance.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var performanceAward = accrual?.Where(w => ReportSettings.settings.PerformanceAward.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var awardPerformanceParticularlyImportantResponsibleWork = accrual?.Where(w => ReportSettings.settings.AwardPerformanceParticularlyImportantResponsibleWork.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var qualificationAllowance = accrual?.Where(w => ReportSettings.settings.QualificationAllowance.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var premiumExemplaryPerformanceStateAssignment = accrual?.Where(w => ReportSettings.settings.PremiumExemplaryPerformanceStateAssignment.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var organizationServiceBonus = accrual?.Where(w => ReportSettings.settings.OrganizationServiceBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var allowanceContinuousWorkExperience = accrual?.Where(w => ReportSettings.settings.AllowanceContinuousWorkExperience.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var monthlyPerformanceBonus = accrual?.Where(w => ReportSettings.settings.MonthlyPerformanceBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var quarterlyPerformanceBonus = accrual?.Where(w => ReportSettings.settings.QuarterlyPerformanceBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var annualPerformanceBonus = accrual?.Where(w => ReportSettings.settings.AnnualPerformanceBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var premiumYoungSpecialist = accrual?.Where(w => ReportSettings.settings.PremiumYoungSpecialist.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var honoraryBonus = accrual?.Where(w => ReportSettings.settings.HonoraryBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var graduateBonus = accrual?.Where(w => ReportSettings.settings.GraduateBonus.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var surchargeWorkRuralAreas2 = accrual?.Where(w => ReportSettings.settings.SurchargeWorkRuralAreas.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var allowanceForPrecinct = accrual?.Where(w => ReportSettings.settings.AllowanceForPrecinct.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var otherIncentivePayments = accrual?.Where(w => ReportSettings.settings.OtherIncentivePayments.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var paymentUnWorkedTimeAndOtherPayments = accrual?.Where(w => ReportSettings.settings.PaymentUnWorkedTimeAndOtherPayments.PayLists.Contains(w.Memo))?.Sum(s => s.Value);

                var coefficientWorkDesertAndWaterlessAreas415 = accrual?.Where(w => ReportSettings.settings.CoefficientWorkDesertAndWaterlessAreas415.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var allowanceWorkExperienceNorthEquivalentAreas415 = accrual?.Where(w => ReportSettings.settings.AllowanceWorkExperienceNorthEquivalentAreas415.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var incentivePayment415 = accrual?.Where(w => ReportSettings.settings.IncentivePayment415.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var summaIncentivePayment415 = accrual?.Where(w => ReportSettings.settings.SummaIncentivePayment415.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var coefficientWorkDesertAndWaterlessAreas484 = accrual?.Where(w => ReportSettings.settings.CoefficientWorkDesertAndWaterlessAreas484.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var incentivePayment484 = accrual?.Where(w => ReportSettings.settings.IncentivePayment484.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var summaIncentivePayment484 = accrual?.Where(w => ReportSettings.settings.SummaIncentivePayment484.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                
                var otherCompensatoryPaymentsSubjectRussianFederation = accrual?.Where(w => ReportSettings.settings.OtherCompensatoryPaymentsSubjectRussianFederation.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var otherCompensatoryPaymentsEntity = accrual?.Where(w => ReportSettings.settings.OtherCompensatoryPaymentsEntity.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                
                var medicalAllowance = accrual?.Where(w => ReportSettings.settings.MedicalAllowance.PayLists.Contains(w.Memo))?.Sum(s => s.Value);

                var otherIncentivePaymentsSubjectRussianFederation = accrual?.Where(w => ReportSettings.settings.OtherIncentivePaymentsSubjectRussianFederation.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var otherIncentivePaymentsEntity = accrual?.Where(w => ReportSettings.settings.OtherIncentivePaymentsEntity.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var oneTimeIncentivePayments = accrual?.Where(w => ReportSettings.settings.OneTimeIncentivePayments.PayLists.Contains(w.Memo))?.Sum(s => s.Value);
                var covid19 = accrual?.Where(w => ReportSettings.settings.Covid19.PayLists.Contains(w.Memo))?.Sum(s => s.Value);

                var name = $"{item.Name} {item.Surname} {item.Patronymic}";

                var sourceOfFinancing = (typeOfCalculations == null) ? ReportSettings.settings.sourceOfFinancing : typeOfCalculations;

                if (flagZeroCharges)
                {
                    if (
                        (officialSalary == null || officialSalary == 0) &&
                        (severePayments == null || severePayments == 0) &&
                        (districtCoefficient == null || districtCoefficient == 0) &&
                        (coefficientWorkDesertAndWaterlessAreas == null || coefficientWorkDesertAndWaterlessAreas == 0) &&
                        (coefficientWorkHighMountainRegions == null || coefficientWorkHighMountainRegions == 0) &&
                        (allowanceWorkExperienceNorthEquivalentAreas == null || allowanceWorkExperienceNorthEquivalentAreas == 0) &&
                        (supplementCombiningProfessions == null || supplementCombiningProfessions == 0) &&
                        (surchargeWorkRuralAreas == null || surchargeWorkRuralAreas == 0) &&
                        (surchargeExpansionServiceAreas == null || surchargeExpansionServiceAreas == 0) &&
                        (surchargeIncreasingAmountWork == null || surchargeIncreasingAmountWork == 0) &&
                        (supplementPerformanceDutiesTemporarilyAbsentEmployee == null || supplementPerformanceDutiesTemporarilyAbsentEmployee == 0) &&
                        (surchargePerformanceWorkVariousQualifications == null || surchargePerformanceWorkVariousQualifications == 0) &&
                        (weekendAndHolidaysWorkSupplement == null || weekendAndHolidaysWorkSupplement == 0) &&
                        (surchargeNightWork == null || surchargeNightWork == 0) &&
                        (allowanceWorkInformationConstituting == null || allowanceWorkInformationConstituting == 0) &&
                        (otherCompensatoryPayments == null || otherCompensatoryPayments == 0) &&
                        (laborAllowance == null || laborAllowance == 0) &&
                        (performanceAward == null || performanceAward == 0) &&
                        (awardPerformanceParticularlyImportantResponsibleWork == null || awardPerformanceParticularlyImportantResponsibleWork == 0) &&
                        (qualificationAllowance == null || qualificationAllowance == 0) &&
                        (premiumExemplaryPerformanceStateAssignment == null || premiumExemplaryPerformanceStateAssignment == 0) &&
                        (organizationServiceBonus == null || organizationServiceBonus == 0) &&
                        (allowanceContinuousWorkExperience == null || allowanceContinuousWorkExperience == 0) &&
                        (monthlyPerformanceBonus == null || monthlyPerformanceBonus == 0) &&
                        (quarterlyPerformanceBonus == null || quarterlyPerformanceBonus == 0) &&
                        (annualPerformanceBonus == null || annualPerformanceBonus == 0) &&
                        (premiumYoungSpecialist == null || premiumYoungSpecialist == 0) &&
                        (honoraryBonus == null || honoraryBonus == 0) &&
                        (graduateBonus == null || graduateBonus == 0) &&
                        (surchargeWorkRuralAreas2 == null || surchargeWorkRuralAreas2 == 0) &&
                        (allowanceForPrecinct == null || allowanceForPrecinct == 0) &&
                        (otherIncentivePayments == null || otherIncentivePayments == 0) &&
                        (paymentUnWorkedTimeAndOtherPayments == null || paymentUnWorkedTimeAndOtherPayments == 0) &&

                        (coefficientWorkDesertAndWaterlessAreas415 == null || coefficientWorkDesertAndWaterlessAreas415 == 0) &&
                        (allowanceWorkExperienceNorthEquivalentAreas415 == null || allowanceWorkExperienceNorthEquivalentAreas415 == 0) &&
                        (incentivePayment415 == null || incentivePayment415 == 0) &&
                        (summaIncentivePayment415 == null || summaIncentivePayment415 == 0) &&
                        (coefficientWorkDesertAndWaterlessAreas484 == null || coefficientWorkDesertAndWaterlessAreas484 == 0) &&
                        (incentivePayment484 == null || incentivePayment484 == 0) &&
                        (summaIncentivePayment484 == null || summaIncentivePayment484 == 0) &&

                        (medicalAllowance == null || medicalAllowance == 0) &&

                        (otherIncentivePaymentsSubjectRussianFederation == null || otherIncentivePaymentsSubjectRussianFederation == 0) &&
                        (otherIncentivePaymentsEntity == null || otherIncentivePaymentsEntity == 0) &&
                        (oneTimeIncentivePayments == null || oneTimeIncentivePayments == 0) &&
                        (covid19 == null || covid19 == 0) &&

                        (otherCompensatoryPaymentsSubjectRussianFederation == null || otherCompensatoryPaymentsSubjectRussianFederation == 0) &&
                        (otherCompensatoryPaymentsEntity == null || otherCompensatoryPaymentsEntity == 0)
                        )
                    {
                        continue;
                    }
                }

                var monthString = default(string);
                var snails = default(string);

                if (isRegion)
                {
                    monthString = ((int)month).ToString().Trim();
                    snails = $"54{item.Snails.Replace("-", "").Replace(" ", "").Trim()}";
                }
                else
                {
                    monthString = month.GetDescription().ToString().Trim();
                    snails = $"{item.Snails.Replace("-", "").Replace(" ", "").Trim()}";
                }

                result.Add(new PersonalAccountReport()
                {
                    Region = ReportSettings.settings.region,
                    OrganizationOid = ReportSettings.settings.organizationOid,
                    Organization = ReportSettings.settings.organization,
                    Subdivision = item.Subdivision,
                    SubdivisionOid = item.SubdivisionOid,
                    Month = monthString,
                    Year = year.ToString(),
                    Snails = snails,
                    Position = item.Position,
                    Rate = item.Rate,
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
                    //AllowanceForPrecinct = allowanceForPrecinct == 0 ? null : allowanceForPrecinct,
                    OtherIncentivePayments = otherIncentivePayments == 0 ? null : otherIncentivePayments,
                    PaymentUnWorkedTimeAndOtherPayments = paymentUnWorkedTimeAndOtherPayments == 0 ? null : paymentUnWorkedTimeAndOtherPayments,

                    CoefficientWorkDesertAndWaterlessAreas415 = coefficientWorkDesertAndWaterlessAreas415 == 0 ? null : coefficientWorkDesertAndWaterlessAreas415,
                    AllowanceWorkExperienceNorthEquivalentAreas415 = allowanceWorkExperienceNorthEquivalentAreas415 == 0 ? null : allowanceWorkExperienceNorthEquivalentAreas415,
                    IncentivePayment415 = incentivePayment415 == 0 ? null : incentivePayment415,
                    SummaIncentivePayment415 = summaIncentivePayment415 == 0 ? null : summaIncentivePayment415,
                    CoefficientWorkDesertAndWaterlessAreas484 = coefficientWorkDesertAndWaterlessAreas484 == 0 ? null : coefficientWorkDesertAndWaterlessAreas484,
                    IncentivePayment484 = incentivePayment484 == 0 ? null : incentivePayment484,
                    SummaIncentivePayment484 = summaIncentivePayment484 == 0 ? null : summaIncentivePayment484,

                    OtherCompensatoryPaymentsSubjectRussianFederation = otherCompensatoryPaymentsSubjectRussianFederation == 0 ? null : otherCompensatoryPaymentsSubjectRussianFederation,
                    OtherCompensatoryPaymentsEntity = otherCompensatoryPaymentsEntity == 0 ? null : otherCompensatoryPaymentsEntity,

                    OtherIncentivePaymentsSubjectRussianFederation = otherIncentivePaymentsSubjectRussianFederation == 0 ? null : otherIncentivePaymentsSubjectRussianFederation,
                    OtherIncentivePaymentsEntity = otherIncentivePaymentsEntity == 0 ? null : otherIncentivePaymentsEntity,
                    OneTimeIncentivePayments = oneTimeIncentivePayments == 0 ? null : oneTimeIncentivePayments,
                    Covid19 = covid19 == 0 ? null : covid19,

                    MedicalAllowance = medicalAllowance == 0 ? null : medicalAllowance,

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
