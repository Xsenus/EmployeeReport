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

            if (ReportSettings.readingDataBase != null)
            {
                checkedListPositions.Items.AddRange(ReportSettings.readingDataBase.Positions.ToArray());

                if (ReportSettings.settings.Positions != null)
                {
                    for (int i = 0; i < checkedListPositions.Items.Count; i++)
                    {
                        if (ReportSettings.settings.Positions.Contains(checkedListPositions.Items[i].ToString()))
                        {
                            checkedListPositions.SetItemChecked(i, true);
                        }
                    }
                }

                checkedListTypeOfCalculations.Items.AddRange(ReportSettings.readingDataBase.TypeOfCalculations.ToArray());

                if (ReportSettings.settings.TypeOfCalculations != null)
                {
                    for (int i = 0; i < checkedListTypeOfCalculations.Items.Count; i++)
                    {
                        if (ReportSettings.settings.TypeOfCalculations.Contains(checkedListTypeOfCalculations.Items[i].ToString()))
                        {
                            checkedListTypeOfCalculations.SetItemChecked(i, true);
                        }
                    }
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

        private void CheckedListPositions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (firstLoading == false)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    ReportSettings.settings.Positions.Add(checkedListPositions.Items[e.Index].ToString());
                }
                else
                {
                    ReportSettings.settings.Positions.Remove(checkedListPositions.Items[e.Index].ToString());
                }
            }            
        }

        private void CheckedListTypeOfCalculations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (firstLoading == false)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    ReportSettings.settings.TypeOfCalculations.Add(checkedListTypeOfCalculations.Items[e.Index].ToString());
                }
                else
                {
                    ReportSettings.settings.TypeOfCalculations.Remove(checkedListTypeOfCalculations.Items[e.Index].ToString());
                }
            }
        }
    }
}
