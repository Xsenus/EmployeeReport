using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EmployeeReportBL.PropertyGrid
{
    public partial class PayControl : UserControl
   {
        private bool firstLoading = true;

        public PayControl()
        {
            InitializeComponent();

            if (ReportSettings.readingDataBase != null)
            {
                checkedListPay.Items.AddRange(ReportSettings.readingDataBase.Pays.ToArray());

                if (ReportSettings.settings.OtherIncentivePayments != null)
                {
                    for (int i = 0; i < checkedListPay.Items.Count; i++)
                    {
                        if (ReportSettings.settings.OtherIncentivePayments.Contains(checkedListPay.Items[i].ToString()))
                        {
                            checkedListPay.SetItemChecked(i, true);
                        }
                    }
                }
            }

            firstLoading = false;
        }

        private void checkedListPay_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (firstLoading == false)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    ReportSettings.settings.OtherIncentivePayments.Add(checkedListPay.Items[e.Index].ToString());
                }
                else
                {
                    ReportSettings.settings.OtherIncentivePayments.Remove(checkedListPay.Items[e.Index].ToString());
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)Tag).CloseDropDown();
        }
   }
}
