using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using EmployeeReportBL.Model;
using System;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

            foreach (var item in ReportSettings.ReadingDataBase.Years)
            {
                cmbYear.Items.Add(item);
            }

            txtPathP7.Text = ReportSettings.settings.path;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Задайте месяц и год для отчета.", "Задайте временной интервал", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMonth.Focus();
                return;
            }

            dataGridView.DataSource = null;
        }

        private void BtnMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMenuItemSettings_Click(object sender, EventArgs e)
        {
            var form = new FormSettings();
            form.ShowDialog();
        }

        private void TxtPathP7_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog() { RestoreDirectory = true, Filter = "Парус Бюджет 7|Parus.dbc" })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var path = fileDialog.FileName;

                    if (ReportSettings.ReadingDataBase.dbConnection == null || ReportSettings.settings.path != path)
                    {
                        ReportSettings.ReadingDataBase = new ReadingDataBase(path);
                    }

                    txtPathP7.Text = path;
                    ReportSettings.settings.path = path;
                    Serialization.Serialize(ReportSettings.settings);
                }
            }
        }

        private void BtnMenuItemImportExcel_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void Export()
        {
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }

            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }
    }
}
