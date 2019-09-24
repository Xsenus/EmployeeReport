using EmployeeReportBL;
using System.Windows.Forms;

namespace Report
{
    public partial class FormSettings : Form
    {
        private bool firstLoading = true;

        public FormSettings()
        {
            InitializeComponent();

            propertyGridSettings.SelectedObject = ReportSettings.settings;

            checkedList.Items.AddRange(ReportSettings.ReadingDataBase.Positions.ToArray());

            for (int i = 0; i < checkedList.Items.Count; i++)
            {
                if (ReportSettings.settings.Positions.Contains(checkedList.Items[i].ToString()))
                {
                    checkedList.SetItemChecked(i, true);
                }
            }

            txtRegion.Text = ReportSettings.settings.region;
            txtOrganization.Text = ReportSettings.settings.organization;
            txtINN.Text = ReportSettings.settings.inn;

            firstLoading = false;
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Применить настройки и выйти?", "Применение настроек", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ReportSettings.settings.region = txtRegion.Text;
                ReportSettings.settings.organization = txtOrganization.Text;
                ReportSettings.settings.inn = txtINN.Text;

                Serialization.Serialize(ReportSettings.settings);
                Close();
            }
        }

        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            ReportSettings.settings = Serialization.Deserialize();
            Close();
        }

        private void PropertyGridSettings_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            propertyGridSettings.Refresh();
        }

        private void CheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (firstLoading == false)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    ReportSettings.settings.Positions.Add(checkedList.Items[e.Index].ToString());
                }
                else
                {
                    ReportSettings.settings.Positions.Remove(checkedList.Items[e.Index].ToString());
                }
            }            
        }
    }
}
