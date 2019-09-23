using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Report
{
    public partial class Report : Form
    {
        private readonly OleDbConnection dbConnection;

        public Report()
        {
            InitializeComponent();

            foreach (Month item in Enum.GetValues(typeof(Month)))
            {
                cmbMonth.Items.Add(item.GetDescription());
            }

            cmbMonth.SelectedIndex = 0;

            var foxProConnection = new FoxProConnection(txtPathP7.Text);

            var reader = new ReadingDataBase(foxProConnection.DbConnection);

            cmbPay.Items.AddRange(reader.Pays.ToArray());

            dataGridView.DataSource = reader.Employees;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}
