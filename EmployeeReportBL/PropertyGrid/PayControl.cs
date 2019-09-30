using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EmployeeReportBL.PropertyGrid
{
    public partial class PayControl : UserControl
    {
        public PayList List { get; set; }

        public PayControl(PayList list)
        {
            InitializeComponent();

            List = list ?? new PayList();

            if (ReportSettings.readingDataBase != null)
            {
                checkedListPay.Items.AddRange(ReportSettings.readingDataBase.Pays.ToArray());
            }

            foreach (var pay in List.PayLists)
            {
                CheckPay(pay);
            }
        }

        public PayList PayList
        {
            get
            {
                List.PayLists.Clear();
                foreach (object it in checkedListPay.CheckedItems)
                {
                    List.PayLists.Add(it.ToString());
                }
                return List;
            }
            set { List = value; }
        }

        private void CheckPay(string pay)
        {
            int i = 0;
            foreach (object it in checkedListPay.Items)
            {
                if (pay == it.ToString())
                {
                    checkedListPay.SetItemChecked(i, true);
                    return;
                }
                i++;
            }
        }

        //private void checkedListPay_ItemCheck(object sender, ItemCheckEventArgs e)
        //{
        //    if (firstLoading == false)
        //    {
        //        if (e.NewValue == CheckState.Checked)
        //        {
        //            ReportSettings.settings.OtherIncentivePayments.Add(checkedListPay.Items[e.Index].ToString());
        //        }
        //        else
        //        {
        //            ReportSettings.settings.OtherIncentivePayments.Remove(checkedListPay.Items[e.Index].ToString());
        //        }
        //    }
        //}

        private void btnOK_Click(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)Tag).CloseDropDown();
        }
    }
}
