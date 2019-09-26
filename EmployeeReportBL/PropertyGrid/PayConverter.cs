using System.ComponentModel;

namespace EmployeeReportBL.PropertyGrid
{
    class PayConverter : StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return false;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            if (ReportSettings.readingDataBase == null)
            {
                return null;
            }

            return new StandardValuesCollection(ReportSettings.readingDataBase.Pays);
        }
    }
}
