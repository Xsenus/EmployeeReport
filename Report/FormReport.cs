using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using EmployeeReportBL.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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

            var currentDate = DateTime.Now;

            cmbMonth.SelectedIndex = currentDate.Month - 1;
            cmbYear.Text = currentDate.Year.ToString();
            
            txtPathP7.Text = ReportSettings.settings.path;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (ReportSettings.readingDataBase == null || ReportSettings.readingDataBase.dbConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Установите соединение c базой данных.", "Установите соединение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConnectParus.Focus();
                return;
            }

            if (cmbMonth.SelectedIndex == -1 || cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Задайте месяц и год для отчета.", "Задайте временной интервал", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbMonth.Focus();
                return;
            }

            var employees = ReportSettings.readingDataBase.GetEmployees(Convert.ToInt32(cmbYear.Text), (Month)cmbMonth.SelectedIndex + 1);

            if (employees != null)
            {
                var personalAccountReport = new PersonalAccountReport(employees);      
                var report = personalAccountReport.GetPersonalAccountReport((Month)cmbMonth.SelectedIndex + 1);
                dataGridView.DataSource = report;
            }
        }

        private void BtnMenuItemExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMenuItemSettings_Click(object sender, EventArgs e)
        {
            if (ReportSettings.readingDataBase == null || ReportSettings.readingDataBase.dbConnection.State != ConnectionState.Open)
            {
                MessageBox.Show("Для настройки установите соединение c базой данных.", "Установите соединение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnConnectParus.Focus();
                return;
            }

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

                    txtPathP7.Text = path;
                    ReportSettings.settings.path = path;
                    Serialization.Serialize(ReportSettings.settings);
                }
            }
        }

        private void BtnMenuItemImportExcel_Click(object sender, EventArgs e)
        {
            dataGridView.SelectAll();
            DataObject dataObj = dataGridView.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }

            StartExport();
        }

        private async void StartExport()
        {
            await Task.Run(() => Export());
        }

        private void Export( )
        {
            if (dataGridView.DataSource == null)
            {
                return;
            }

            var templateDirectory = $"{Environment.CurrentDirectory}\\template\\Report.xlsx";
            var reportDirectory = $"{Path.GetTempPath()}{Guid.NewGuid().ToString().Substring(0, 6).ToUpper()}.xlsx";

            File.Copy(templateDirectory, reportDirectory);

            Excel.Application xlexcel;
            Workbook xlWorkBook;

            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Open(reportDirectory);
            var xlWorkSheet1 = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet1.Activate();
            Range CR = (Range)xlWorkSheet1.Cells[4, 1];
            CR.Select();
            xlWorkSheet1.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            xlWorkSheet1.UsedRange.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;

            var xlWorkSheet2 = (Worksheet)xlWorkBook.Worksheets[2];
            xlWorkSheet2.Activate();
            xlWorkSheet2.Cells[2, 1].Value = ReportSettings.settings.organization;
            xlWorkSheet2.Cells[2, 2].Value = ReportSettings.settings.inn;
            xlWorkSheet2.Cells[2, 3].Value = ReportSettings.settings.region;           

            var positions = (ReportSettings.settings == null || ReportSettings.settings.Positions == null || ReportSettings.settings.Positions.Count == 0) ? 
                ReportSettings.readingDataBase?.Positions ?? null : 
                ReportSettings.readingDataBase?.Positions?.Where(w => ReportSettings.settings.Positions.Contains(w.Mnemo)).ToList();

            if (positions != null)
            {
                var xlWorkSheet4 = (Worksheet)xlWorkBook.Worksheets[4];
                xlWorkSheet4.Activate();

                for (int i = 0; i < positions.Count; i++)
                {
                    xlWorkSheet4.Cells[i + 2, 1].Value = positions[i].Mnemo;
                    xlWorkSheet4.Cells[i + 2, 2].Value = positions[i].Name;
                }
            }

            xlWorkSheet1.Activate();
        }

        private void btnConnectParus_Click(object sender, EventArgs e)
        {
            var path = ReportSettings.settings.path;

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Для соединения укажите путь до базы данных.", "Укажите путь", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ReportSettings.readingDataBase = new ReadingDataBase(path);

            if (ReportSettings.readingDataBase.dbConnection.State == ConnectionState.Open)
            {
                toolStripStatusLabelBool.Text = "активно";
                toolStripStatusLabelBool.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabelBool.Text = "неактивно";
                toolStripStatusLabelBool.ForeColor = Color.DarkRed;
            }
        }
    }
}
