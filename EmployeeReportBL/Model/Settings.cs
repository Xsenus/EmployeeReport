﻿using EmployeeReportBL.PropertyGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;

namespace EmployeeReportBL.Model
{
    [Serializable]
    [TypeConverter(typeof(PropertySorter))]
    public class Settings
    {
        /// <summary>
        /// Путь до используемой БД Парус Бюджет 7.
        /// </summary>
        public string path;

        /// <summary>
        /// Регион.
        /// </summary>
        public string region;

        /// <summary>
        /// Полное наименование МО (Организация).
        /// </summary>
        public string organization;

        /// <summary>
        /// Полное наименование МО (Организация).
        /// </summary>
        public string organizationOid;

        /// <summary>
        /// Полное наименование МО (Организация).
        /// </summary>
        public string inn;

        /// <summary>
        /// Основной источник финансирования.
        /// </summary>
        public string sourceOfFinancing;

        /// <summary>
        /// Список выбранных должностей.
        /// </summary>
        public List<string> Positions = new List<string>();

        /// <summary>
        /// Список видов расчетов, которые выносятся отдельно
        /// </summary>
        public List<string> TypeOfCalculations = new List<string>();

        /// <summary>
        /// Типы рабочего дня.
        /// </summary>
        public List<string> TypeOfDays = new List<string>();

        /// <summary>
        /// Должностной оклад.
        /// </summary>
        [DisplayName("Должностной оклад")]
        [Description("Должностной оклад.")]
        [PropertySorter.PropertyOrder(1)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OfficialSalary { get; set; } = new PayList();

        /// <summary>
        /// Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.
        /// </summary>
        [DisplayName("Тяжелые и вредные условия")]
        [Description("Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.")]
        [PropertySorter.PropertyOrder(10)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SeverePayments { get; set; } = new PayList();

        /// <summary>
        /// Районный коэффициент.
        /// </summary>
        [DisplayName("Районный коэффициент")]
        [Description("Районный коэффициент.")]
        [PropertySorter.PropertyOrder(20)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList DistrictCoefficient { get; set; } = new PayList();

        /// <summary>
        /// Коэффициент за работу в пустынных и безводных местностях.
        /// </summary>
        [DisplayName("Пустыни и безводная местность")]
        [Description("Коэффициент за работу в пустынных и безводных местностях.")]
        [PropertySorter.PropertyOrder(30)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList CoefficientWorkDesertAndWaterlessAreas { get; set; } = new PayList();

        /// <summary>
        /// Коэффициент за работу в высокогорных районах.
        /// </summary>
        [DisplayName("Высокогорье")]
        [Description("Коэффициент за работу в высокогорных районах.")]
        [PropertySorter.PropertyOrder(40)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList CoefficientWorkHighMountainRegions { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.
        /// </summary>
        [DisplayName("Крайний север")]
        [Description("Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.")]
        [PropertySorter.PropertyOrder(50)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AllowanceWorkExperienceNorthEquivalentAreas { get; set; } = new PayList();

        /// <summary>
        /// Доплата за совмещение профессий (должностей).
        /// </summary>
        [DisplayName("Совмещение")]
        [Description("Доплата за совмещение профессий (должностей).")]
        [PropertySorter.PropertyOrder(60)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SupplementCombiningProfessions { get; set; } = new PayList();

        /// <summary>
        /// Доплата за работу в сельской местности.
        /// </summary>
        [DisplayName("Сельская местность")]
        [Description("Доплата за работу в сельской местности.")]
        [PropertySorter.PropertyOrder(70)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SurchargeWorkRuralAreas { get; set; } = new PayList();

        /// <summary>
        /// Доплата за расширение зон обслуживания.
        /// </summary>
        [DisplayName("Расширение зон обслуживания")]
        [Description("Доплата за расширение зон обслуживания.")]
        [PropertySorter.PropertyOrder(80)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SurchargeExpansionServiceAreas { get; set; } = new PayList();

        /// <summary>
        /// Доплата за увеличение объема работы.
        /// </summary>
        [DisplayName("Объем работ")]
        [Description("Доплата за увеличение объема работы.")]
        [PropertySorter.PropertyOrder(90)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SurchargeIncreasingAmountWork { get; set; } = new PayList();

        /// <summary>
        /// Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.
        /// </summary>
        [DisplayName("За отсутствующего работника")]
        [Description("Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.")]
        [PropertySorter.PropertyOrder(100)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SupplementPerformanceDutiesTemporarilyAbsentEmployee { get; set; } = new PayList();

        /// <summary>
        /// Доплата за выполнение работ различной квалификации.
        /// </summary>
        [DisplayName("Различная квалификация")]
        [Description("Доплата за выполнение работ различной квалификации.")]
        [PropertySorter.PropertyOrder(110)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SurchargePerformanceWorkVariousQualifications { get; set; } = new PayList();

        /// <summary>
        /// Доплата за работу в выходные и праздничные дни.
        /// </summary>
        [DisplayName("Выходные и праздничные")]
        [Description("Доплата за работу в выходные и праздничные дни.")]
        [PropertySorter.PropertyOrder(120)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList WeekendAndHolidaysWorkSupplement { get; set; } = new PayList();

        /// <summary>
        /// Доплата за работу в ночное время.
        /// </summary>
        [DisplayName("Ночное время")]
        [Description("Доплата за работу в ночное время.")]
        [PropertySorter.PropertyOrder(130)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SurchargeNightWork { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.
        /// </summary>
        [DisplayName("Государственная тайна")]
        [Description("Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.")]
        [PropertySorter.PropertyOrder(140)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AllowanceWorkInformationConstituting { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты компенсационного характера.
        /// </summary>
        [DisplayName("Компенсации")]
        [Description("Иные выплаты компенсационного характера.")]
        [PropertySorter.PropertyOrder(150)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherCompensatoryPayments { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за интенсивность труда.
        /// </summary>
        [DisplayName("Интенсивность труда")]
        [Description("Надбавка за интенсивность труда.")]
        [PropertySorter.PropertyOrder(160)]
        [Category("Интенсивность и высокие результаты работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList LaborAllowance { get; set; } = new PayList();

        /// <summary>
        /// Премия за высокие результаты работы.
        /// </summary>
        [DisplayName("Высокие результаты")]
        [Description("Премия за высокие результаты работы.")]
        [PropertySorter.PropertyOrder(170)]
        [Category("Интенсивность и высокие результаты работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList PerformanceAward { get; set; } = new PayList();

        /// <summary>
        /// Премия за выполнение особо важных и ответственных работ.
        /// </summary>
        [DisplayName("Особо важная работа")]
        [Description("Премия за выполнение особо важных и ответственных работ.")]
        [PropertySorter.PropertyOrder(180)]
        [Category("Интенсивность и высокие результаты работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AwardPerformanceParticularlyImportantResponsibleWork { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за наличие квалификационной категории.
        /// </summary>
        [DisplayName("Квалификационная категория")]
        [Description("Надбавка за наличие квалификационной категории.")]
        [PropertySorter.PropertyOrder(190)]
        [Category("Качество выполняемых работ")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList QualificationAllowance { get; set; } = new PayList();

        /// <summary>
        /// Премия за образцовое выполнение государственного (муниципального) задания.
        /// </summary>
        [DisplayName("Муниципальное задание")]
        [Description("Премия за образцовое выполнение государственного (муниципального) задания.")]
        [PropertySorter.PropertyOrder(200)]
        [Category("Качество выполняемых работ")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList PremiumExemplaryPerformanceStateAssignment { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за выслугу лет в организации.
        /// </summary>
        [DisplayName("Выслуга лет")]
        [Description("Надбавка за выслугу лет в организации.")]
        [PropertySorter.PropertyOrder(210)]
        [Category("Выплаты за стаж работы, выслугу лет")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OrganizationServiceBonus { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за стаж непрерывной работы (медицинский стаж).
        /// </summary>
        [DisplayName("Стаж непрерывной работы")]
        [Description("Надбавка за стаж непрерывной работы (медицинский стаж).")]
        [PropertySorter.PropertyOrder(220)]
        [Category("Выплаты за стаж работы, выслугу лет")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AllowanceContinuousWorkExperience { get; set; } = new PayList();

        /// <summary>
        /// Премия по итогам работы за месяц.
        /// </summary>
        [DisplayName("Премия за месяц")]
        [Description("Премия по итогам работы за месяц.")]
        [PropertySorter.PropertyOrder(230)]
        [Category("Премиальные выплаты по итогам работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList MonthlyPerformanceBonus { get; set; } = new PayList();

        /// <summary>
        /// Премия по итогам работы за квартал.
        /// </summary>
        [DisplayName("Премия за квартал")]
        [Description("Премия по итогам работы за квартал.")]
        [PropertySorter.PropertyOrder(240)]
        [Category("Премиальные выплаты по итогам работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList QuarterlyPerformanceBonus { get; set; } = new PayList();

        /// <summary>
        /// Премия по итогам работы за год.
        /// </summary>
        [DisplayName("Премия за год")]
        [Description("Премия по итогам работы за год.")]
        [PropertySorter.PropertyOrder(250)]
        [Category("Премиальные выплаты по итогам работы")]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AnnualPerformanceBonus { get; set; } = new PayList();

        /// <summary>
        /// Надбавка молодому специалисту.
        /// </summary>
        [DisplayName("Молодой специалист")]
        [Description("Надбавка молодому специалисту.")]
        [PropertySorter.PropertyOrder(260)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList PremiumYoungSpecialist { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за почётное звание.
        /// </summary>
        [DisplayName("Почетное звание")]
        [Description("Надбавка за почётное звание.")]
        [PropertySorter.PropertyOrder(270)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList HonoraryBonus { get; set; } = new PayList();

        /// <summary>
        /// Надбавка за наличие учёной степени.
        /// </summary>
        [DisplayName("Ученая степень")]
        [Description("Надбавка за наличие учёной степени.")]
        [PropertySorter.PropertyOrder(280)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList GraduateBonus { get; set; } = new PayList();

        // TODO: Такая выплата есть выше. Чем различаются?
        //public string SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Надбавка за [Участковость].
        /// </summary>
        [DisplayName("Надбавка за [Участковость]")]
        [Description("Надбавка за [Участковость].")]
        [PropertySorter.PropertyOrder(290)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AllowanceForPrecinct { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты стимулирующего характера.
        /// </summary>
        [DisplayName("Стимулирующие выплаты")]
        [Description("Иные выплаты стимулирующего характера.")]
        [PropertySorter.PropertyOrder(300)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherIncentivePayments { get; set; } = new PayList();

        /// <summary>
        /// Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер 
        /// в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.
        /// </summary>
        [DisplayName("Не отработанное время")]
        [Description("Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.")]
        [PropertySorter.PropertyOrder(310)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList PaymentUnWorkedTimeAndOtherPayments { get; set; } = new PayList();

        /// <summary>
        /// Работу в пустынях и безводных местностях ПП РФ 415.
        /// </summary>
        [DisplayName("Работу в пустынях и безводных местностях ПП РФ 415")]
        [Description("Размер районного коэффициента к заработной плате, коэффициент за работу в пустынных и безводных местностях, высокогорных районах, применяемые к выплатам по ПП РФ №415, ед.")]
        [PropertySorter.PropertyOrder(320)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList CoefficientWorkDesertAndWaterlessAreas415 { get; set; } = new PayList();

        /// <summary>
        /// Работа в районах Крайнего Севера ПП РФ 415.
        /// </summary>
        [DisplayName("Работа в районах Крайнего Севера ПП РФ 415")]
        [Description("Размер процентной надбавки за работу в районах Крайнего Севера, приравненных к ним местностях, в южных районах Восточной Сибири и Дальнего Востока (в соответствии с НПА СССР, РСФСР), применяемый к выплатам по ПП РФ №415, %")]
        [PropertySorter.PropertyOrder(330)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList AllowanceWorkExperienceNorthEquivalentAreas415 { get; set; } = new PayList();

        /// <summary>
        /// Выплата стимулирующего характера ПП РФ 415.
        /// </summary>
        [DisplayName("Выплата стимулирующего характера ПП РФ 415")]
        [Description("Выплата стимулирующего характера, установленная медицинскому работнику в соответствии с ПП РФ №415 за фактически отработанное время.")]
        [PropertySorter.PropertyOrder(340)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList IncentivePayment415 { get; set; } = new PayList();

        /// <summary>
        /// Сумма страховых взносов с выплат стимулирующего характера ПП РФ 415.
        /// </summary>
        [DisplayName("Сумма страховых взносов с выплат стимулирующего характера ПП РФ 415")]
        [Description("Сумма страховых взносов с выплат стимулирующего характера, начисленных по ПП РФ 415, руб.")]
        [PropertySorter.PropertyOrder(350)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SummaIncentivePayment415 { get; set; } = new PayList();

        /// <summary>
        /// Работу в пустынях и безводных местностях ПП РФ 484.
        /// </summary>
        [DisplayName("Работу в пустынях и безводных местностях ПП РФ 484")]
        [Description("Размер районного коэффициента к заработной плате, коэффициент за работу в пустынных и безводных местностях, высокогорных районах, установленные федеральными НПА и применяемые к выплатам по ПП РФ №484, ед.")]
        [PropertySorter.PropertyOrder(360)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList CoefficientWorkDesertAndWaterlessAreas484 { get; set; } = new PayList();

        /// <summary>
        /// Выплата стимулирующего характера ПП РФ 484.
        /// </summary>
        [DisplayName("Выплата стимулирующего характера ПП РФ 484")]
        [Description("Выплата стимулирующего характера, установленная медицинскому работнику в соответствии с ПП РФ №484 за фактически отработанное время.")]
        [PropertySorter.PropertyOrder(370)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList IncentivePayment484 { get; set; } = new PayList();

        /// <summary>
        /// Сумма страховых взносов с выплат стимулирующего характера ПП РФ 484.
        /// </summary>
        [DisplayName("Сумма страховых взносов с выплат стимулирующего характера ПП РФ 484")]
        [Description("Сумма страховых взносов с выплат стимулирующего характера, начисленных по ПП РФ 484, руб.")]
        [PropertySorter.PropertyOrder(380)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList SummaIncentivePayment484 { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты компенсационного характера, установленные субъектом Российской Федерации.
        /// </summary>
        [DisplayName("Компенсация установленная субъектом РФ")]
        [Description("Иные выплаты компенсационного характера, установленные субъектом Российской Федерации.")]
        [PropertySorter.PropertyOrder(390)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherCompensatoryPaymentsSubjectRussianFederation { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты компенсационного характера, установленные учреждением.
        /// </summary>
        [DisplayName("Компенсация установленная учреждением")]
        [Description("Иные выплаты компенсационного характера, установленные учреждением.")]
        [PropertySorter.PropertyOrder(400)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherCompensatoryPaymentsEntity { get; set; } = new PayList();

        /// <summary>
        /// Надбавка врачам терапевтам (педиатрам) участковым, врачам общей практики и их медсестрам.
        /// </summary>
        [DisplayName("Надбавки врачам")]
        [Description("Надбавка врачам терапевтам (педиатрам) участковым, врачам общей практики и их медсестрам.")]
        [PropertySorter.PropertyOrder(410)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList MedicalAllowance { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты стимулирующего характера, установленные субъектом Российской Федерации..
        /// </summary>
        [DisplayName("Стимулирующая установленная субъектом РФ")]
        [Description("Иные выплаты стимулирующего характера, установленные субъектом Российской Федерации.")]
        [PropertySorter.PropertyOrder(410)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherIncentivePaymentsSubjectRussianFederation { get; set; } = new PayList();

        /// <summary>
        /// Иные выплаты стимулирующего характера, установленные учреждением.
        /// </summary>
        [DisplayName("Стимулирующая установленная учреждением")]
        [Description("Иные выплаты стимулирующего характера, установленные учреждением.")]
        [PropertySorter.PropertyOrder(410)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OtherIncentivePaymentsEntity { get; set; } = new PayList();

        /// <summary>
        /// Единовременные поощрительные выплаты.
        /// </summary>
        [DisplayName("Единовременные поощрительные выплаты")]
        [Description("Единовременные поощрительные выплаты.")]
        [PropertySorter.PropertyOrder(410)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList OneTimeIncentivePayments { get; set; } = new PayList();

        /// <summary>
        /// Выплата стимулирующего характера за особые условия труда и дополнительную нагрузку медицинским работникам, оказывающим медицинскую помощь гражданам, 
        /// у которых выявлена новая коронавирусная инфекция, и лицам из групп риска заражения новой коронавирусной инфекцией 
        /// (в соответствии с постановлениями Правительства Российской Федерации № 415 от 2 апреля 2020 г. и № 484 от 12 апреля 2020 г.).
        /// </summary>
        [DisplayName("Covid19")]
        [Description("Выплата стимулирующего характера за особые условия труда и дополнительную нагрузку медицинским работникам, оказывающим медицинскую помощь гражданам, у которых выявлена новая коронавирусная инфекция, и лицам из групп риска заражения новой коронавирусной инфекцией (в соответствии с постановлениями Правительства Российской Федерации № 415 от 2 апреля 2020 г. и № 484 от 12 апреля 2020 г.).")]
        [PropertySorter.PropertyOrder(410)]
        [Editor(typeof(PaysDropDownEditor), typeof(UITypeEditor))]
        public PayList Covid19 { get; set; } = new PayList();
    }
}
