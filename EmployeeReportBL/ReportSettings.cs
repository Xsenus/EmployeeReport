using EmployeeReportBL.Model;

namespace EmployeeReportBL
{
    public static class ReportSettings
    {
        public static Settings settings = Serialization.Deserialize();
        public static ReadingDataBase readingDataBase;
    }
}
