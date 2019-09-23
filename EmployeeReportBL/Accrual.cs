using EmployeeReportBL.Enumeration;

namespace EmployeeReportBL
{
    public class Accrual
    {
        public string Mnemo { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }

        public int Year { get; set; }

        public Month Month { get; set; }

        public bool Storno { get; set; }
    }
}
