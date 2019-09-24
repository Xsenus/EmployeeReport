﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using static EmployeeReportBL.PropertySorter;

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
        public string inn;

        /// <summary>
        /// Список выбранных должностей.
        /// </summary>
        public List<string> Positions;

        /// <summary>
        /// Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.
        /// </summary>
        [DisplayName("Тяжелые и вредные условия")]
        [Description("Выплаты работникам, занятым на тяжелых работах, работах с вредными и (или) опасными и иными особыми условиями труда.")]
        [PropertyOrder(10)]
        [TypeConverter(typeof(PayConverter))]
        public string SeverePayments { get; set; }

        /// <summary>
        /// Районный коэффициент.
        /// </summary>
        [DisplayName("Районный коэффициент")]
        [Description("Районный коэффициент.")]
        [PropertyOrder(20)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [TypeConverter(typeof(PayConverter))]
        public string DistrictCoefficient { get; set; }

        /// <summary>
        /// Коэффициент за работу в пустынных и безводных местностях.
        /// </summary>
        [DisplayName("Пустыни и безводная местность")]
        [Description("Коэффициент за работу в пустынных и безводных местностях.")]
        [PropertyOrder(30)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [TypeConverter(typeof(PayConverter))]
        public string CoefficientWorkDesertAndWaterlessAreas { get; set; }

        /// <summary>
        /// Коэффициент за работу в высокогорных районах.
        /// </summary>
        [DisplayName("Высокогорье")]
        [Description("Коэффициент за работу в высокогорных районах.")]
        [PropertyOrder(40)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [TypeConverter(typeof(PayConverter))]
        public string CoefficientWorkHighMountainRegions { get; set; }

        /// <summary>
        /// Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.
        /// </summary>
        [DisplayName("Крайний север")]
        [Description("Надбавка за стаж работы в районах Крайнего Севера и приравненных к ним местностях.")]
        [PropertyOrder(50)]
        [Category("Выплаты за работу в местностях с особыми климатическими условиями")]
        [TypeConverter(typeof(PayConverter))]
        public string AllowanceWorkExperienceNorthEquivalentAreas { get; set; }

        /// <summary>
        /// Доплата за совмещение профессий (должностей).
        /// </summary>
        [DisplayName("Совмещение")]
        [Description("Доплата за совмещение профессий (должностей).")]
        [PropertyOrder(60)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SupplementCombiningProfessions { get; set; }

        /// <summary>
        /// Доплата за работу в сельской местности.
        /// </summary>
        [DisplayName("Сельская местность")]
        [Description("Доплата за работу в сельской местности.")]
        [PropertyOrder(70)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Доплата за расширение зон обслуживания.
        /// </summary>
        [DisplayName("Расширение зон обслуживания")]
        [Description("Доплата за расширение зон обслуживания.")]
        [PropertyOrder(80)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SurchargeExpansionServiceAreas { get; set; }

        /// <summary>
        /// Доплата за увеличение объема работы.
        /// </summary>
        [DisplayName("Объем работ")]
        [Description("Доплата за увеличение объема работы.")]
        [PropertyOrder(90)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SurchargeIncreasingAmountWork { get; set; }

        /// <summary>
        /// Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.
        /// </summary>
        [DisplayName("За отсутствующего работника")]
        [Description("Доплата за исполнение обязанностей временно отсутствующего работника без освобождения от работы.")]
        [PropertyOrder(100)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SupplementPerformanceDutiesTemporarilyAbsentEmployee { get; set; }

        /// <summary>
        /// Доплата за выполнение работ различной квалификации.
        /// </summary>
        [DisplayName("Различная квалификация")]
        [Description("Доплата за выполнение работ различной квалификации.")]
        [PropertyOrder(110)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SurchargePerformanceWorkVariousQualifications { get; set; }

        /// <summary>
        /// Доплата за работу в выходные и праздничные дни.
        /// </summary>
        [DisplayName("Выходные и праздничные")]
        [Description("Доплата за работу в выходные и праздничные дни.")]
        [PropertyOrder(120)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string WeekendAndHolidaysWorkSupplement { get; set; }

        /// <summary>
        /// Доплата за работу в ночное время.
        /// </summary>
        [DisplayName("Ночное время")]
        [Description("Доплата за работу в ночное время.")]
        [PropertyOrder(130)]
        [Category("Выплаты за работу в условиях, отклоняющихся от нормальных")]
        [TypeConverter(typeof(PayConverter))]
        public string SurchargeNightWork { get; set; }

        /// <summary>
        /// Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.
        /// </summary>
        [DisplayName("Государственная тайна")]
        [Description("Надбавка за работу со сведениями, составляющими государственную тайну, их засекречиванием и рассекречиванием, а также за работу с шифрами.")]
        [PropertyOrder(140)]
        [TypeConverter(typeof(PayConverter))]
        public string AllowanceWorkInformationConstituting { get; set; }

        /// <summary>
        /// Иные выплаты компенсационного характера.
        /// </summary>
        [DisplayName("Компенсации")]
        [Description("Иные выплаты компенсационного характера.")]
        [PropertyOrder(150)]
        [TypeConverter(typeof(PayConverter))]
        public string OtherCompensatoryPayments { get; set; }

        /// <summary>
        /// Надбавка за интенсивность труда.
        /// </summary>
        [DisplayName("Интенсивность труда")]
        [Description("Надбавка за интенсивность труда.")]
        [PropertyOrder(160)]
        [Category("Интенсивность и высокие результаты работы")]
        [TypeConverter(typeof(PayConverter))]
        public string LaborAllowance { get; set; }

        /// <summary>
        /// Премия за высокие результаты работы.
        /// </summary>
        [DisplayName("Высокие результаты")]
        [Description("Премия за высокие результаты работы.")]
        [PropertyOrder(170)]
        [Category("Интенсивность и высокие результаты работы")]
        [TypeConverter(typeof(PayConverter))]
        public string PerformanceAward { get; set; }

        /// <summary>
        /// Премия за выполнение особо важных и ответственных работ.
        /// </summary>
        [DisplayName("Особо важная работа")]
        [Description("Премия за выполнение особо важных и ответственных работ.")]
        [PropertyOrder(180)]
        [Category("Интенсивность и высокие результаты работы")]
        [TypeConverter(typeof(PayConverter))]
        public string AwardPerformanceParticularlyImportantResponsibleWork { get; set; }

        /// <summary>
        /// Надбавка за наличие квалификационной категории.
        /// </summary>
        [DisplayName("Квалификационная категория")]
        [Description("Надбавка за наличие квалификационной категории.")]
        [PropertyOrder(190)]
        [Category("Качество выполняемых работ")]
        [TypeConverter(typeof(PayConverter))]
        public string QualificationAllowance { get; set; }

        /// <summary>
        /// Премия за образцовое выполнение государственного (муниципального) задания.
        /// </summary>
        [DisplayName("Муниципальное задание")]
        [Description("Премия за образцовое выполнение государственного (муниципального) задания.")]
        [PropertyOrder(200)]
        [Category("Качество выполняемых работ")]
        [TypeConverter(typeof(PayConverter))]
        public string PremiumExemplaryPerformanceStateAssignment { get; set; }

        /// <summary>
        /// Надбавка за выслугу лет в организации.
        /// </summary>
        [DisplayName("Выслуга лет")]
        [Description("Надбавка за выслугу лет в организации.")]
        [PropertyOrder(210)]
        [Category("Выплаты за стаж работы, выслугу лет")]
        [TypeConverter(typeof(PayConverter))]
        public string OrganizationServiceBonus { get; set; }

        /// <summary>
        /// Надбавка за стаж непрерывной работы (медицинский стаж).
        /// </summary>
        [DisplayName("Стаж непрерывной работы")]
        [Description("Надбавка за стаж непрерывной работы (медицинский стаж).")]
        [PropertyOrder(220)]
        [Category("Выплаты за стаж работы, выслугу лет")]
        [TypeConverter(typeof(PayConverter))]
        public string AllowanceContinuousWorkExperience { get; set; }

        /// <summary>
        /// Премия по итогам работы за месяц.
        /// </summary>
        [DisplayName("Премия за месяц")]
        [Description("Премия по итогам работы за месяц.")]
        [PropertyOrder(230)]
        [Category("Премиальные выплаты по итогам работы")]
        [TypeConverter(typeof(PayConverter))]
        public string MonthlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за квартал.
        /// </summary>
        [DisplayName("Премия за квартал")]
        [Description("Премия по итогам работы за квартал.")]
        [PropertyOrder(240)]
        [Category("Премиальные выплаты по итогам работы")]
        [TypeConverter(typeof(PayConverter))]
        public string QuarterlyPerformanceBonus { get; set; }

        /// <summary>
        /// Премия по итогам работы за год.
        /// </summary>
        [DisplayName("Премия за год")]
        [Description("Премия по итогам работы за год.")]
        [PropertyOrder(250)]
        [Category("Премиальные выплаты по итогам работы")]
        [TypeConverter(typeof(PayConverter))]
        public string AnnualPerformanceBonus { get; set; }

        /// <summary>
        /// Надбавка молодому специалисту.
        /// </summary>
        [DisplayName("Молодой специалист")]
        [Description("Надбавка молодому специалисту.")]
        [PropertyOrder(260)]
        [TypeConverter(typeof(PayConverter))]
        public string PremiumYoungSpecialist { get; set; }

        /// <summary>
        /// Надбавка за почётное звание.
        /// </summary>
        [DisplayName("Почетное звание")]
        [Description("Надбавка за почётное звание.")]
        [PropertyOrder(270)]
        [TypeConverter(typeof(PayConverter))]
        public string HonoraryBonus { get; set; }

        /// <summary>
        /// Надбавка за наличие учёной степени.
        /// </summary>
        [DisplayName("Ученая степень")]
        [Description("Надбавка за наличие учёной степени.")]
        [PropertyOrder(280)]
        [TypeConverter(typeof(PayConverter))]
        public string GraduateBonus { get; set; }

        // TODO: Такая выплата есть выше. Чем различаются?
        //public string SurchargeWorkRuralAreas { get; set; }

        /// <summary>
        /// Надбавка за [Участковость].
        /// </summary>
        [DisplayName("Надбавка за [Участковость]")]
        [Description("Надбавка за [Участковость].")]
        [PropertyOrder(290)]
        [TypeConverter(typeof(PayConverter))]
        public string AllowanceForPrecinct { get; set; }

        /// <summary>
        /// Иные выплаты стимулирующего характера.
        /// </summary>
        [DisplayName("Стимулирующие выплаты")]
        [Description("Иные выплаты стимулирующего характера.")]
        [PropertyOrder(300)]
        [TypeConverter(typeof(PayConverter))]
        public string OtherIncentivePayments { get; set; }

        /// <summary>
        /// Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер 
        /// в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.
        /// </summary>
        [DisplayName("Не отработанное время")]
        [Description("Оплата за не отработанное время, единовременные поощрительные и другие выплаты, оплата питания и проживания, имеющая систематический характер в соответствии с пунктами 84.2.,84.3,84.4 приказа федеральной службы государственной статистики от 22.11.2017 №772.")]
        [PropertyOrder(310)]
        [TypeConverter(typeof(PayConverter))]
        public string PaymentUnWorkedTimeAndOtherPayments { get; set; }
    }
}