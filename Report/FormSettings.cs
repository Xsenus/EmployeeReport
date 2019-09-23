using System.Windows.Forms;

namespace Report
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            var settings = new Settings();
            propertyGridSettings.SelectedObject = settings;
        }
    }
}
