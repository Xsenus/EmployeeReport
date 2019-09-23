using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Report
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();

            foreach (Month item in Enum.GetValues(typeof(Month)))
            {
                cmbMonth.Items.Add(item.GetDescription());
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            var foxProConnection = new FoxProConnection(txtPathP7.Text);

            var reader = new ReadingDataBase(foxProConnection.DbConnection);

            dataGridView.DataSource = reader.Employees;
        }

        private void BtnMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMenuItemSettings_Click(object sender, EventArgs e)
        {
            var form = new FormSettings();
            form.ShowDialog();
        }
    }
}
