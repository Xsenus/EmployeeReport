using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Extension;
using EmployeeReportBL.Model;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Report
{
    public partial class FormReport : Form
    {
        /// <summary>
        /// Региональная или федеральная форма.
        /// </summary>
        private static bool IsRegion { get; set; }
        private List<PersonalAccountReport> PersonalAccountReports { get; set; }
        private SpinningCircles SpinningCircles { get; set; }

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

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportSettings.readingDataBase == null || ReportSettings.readingDataBase.dbConnectionAsync?.State != ConnectionState.Open)
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

                btnStart.Enabled = false;
                dataGridView.Enabled = false;

                var tokenSource = new CancellationTokenSource();
                CancellationToken ct = tokenSource.Token;

                var year = Convert.ToInt32(cmbYear.Text);
                var month = (Month)cmbMonth.SelectedIndex + 1;

                SpinningCircles = new SpinningCircles();
                dataGridView.Controls.Add(SpinningCircles);
                SpinningCircles.Top = dataGridView.Height / 2 - SpinningCircles.Height;
                SpinningCircles.Left = dataGridView.Width / 2 - SpinningCircles.Width / 2;
                SpinningCircles.Refresh();

                var flagZeroCharges = checkBoxZeroCharges.Checked;
                dataGridView.DataSource = await GetReportAsync(year, month, flagZeroCharges, ct);

                dataGridView.Columns[nameof(PersonalAccountReport.Snails)].ValueType = typeof(String);

                if (IsRegion)
                {
                    dataGridView.Columns[nameof(PersonalAccountReport.OrganizationOid)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.SubdivisionOid)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.ActualHoursWorkedPP415)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.ActualHoursWorkedPP484)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.Year)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.Rate)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.CoefficientWorkDesertAndWaterlessAreas415)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.AllowanceWorkExperienceNorthEquivalentAreas415)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.IncentivePayment415)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.SummaIncentivePayment415)].Visible = false; 
                    dataGridView.Columns[nameof(PersonalAccountReport.CoefficientWorkDesertAndWaterlessAreas484)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.IncentivePayment484)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.SummaIncentivePayment484)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePayments)].Visible = false;


                    dataGridView.Columns[nameof(PersonalAccountReport.OtherCompensatoryPaymentsSubjectRussianFederation)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherCompensatoryPaymentsEntity)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePaymentsSubjectRussianFederation)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePaymentsEntity)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.OneTimeIncentivePayments)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.Covid19)].Visible = true;
                }
                else
                {
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherCompensatoryPaymentsSubjectRussianFederation)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherCompensatoryPaymentsEntity)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePaymentsSubjectRussianFederation)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePaymentsEntity)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.OneTimeIncentivePayments)].Visible = false;
                    dataGridView.Columns[nameof(PersonalAccountReport.Covid19)].Visible = false;


                    dataGridView.Columns[nameof(PersonalAccountReport.OrganizationOid)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.SubdivisionOid)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.ActualHoursWorkedPP415)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.ActualHoursWorkedPP484)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.Year)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.Rate)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.CoefficientWorkDesertAndWaterlessAreas415)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.AllowanceWorkExperienceNorthEquivalentAreas415)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.IncentivePayment415)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.SummaIncentivePayment415)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.CoefficientWorkDesertAndWaterlessAreas484)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.IncentivePayment484)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.SummaIncentivePayment484)].Visible = true;
                    dataGridView.Columns[nameof(PersonalAccountReport.OtherIncentivePayments)].Visible = true;
                }

                SpinningCircles.Dispose();
                btnStart.Enabled = true;
                dataGridView.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<List<PersonalAccountReport>> GetReportAsync(int year, Month month, bool flagZeroCharges, CancellationToken token)
        {
            return await Task.Run(() => GetReport(year, month, flagZeroCharges, token)).ConfigureAwait(false);
        }

        private List<PersonalAccountReport> GetReport(int year, Month month, bool flagZeroCharges, CancellationToken token)
        {
            var employees = ReportSettings.readingDataBase.GetEmployeesAsync(year, month, token).Result;

            if (employees != null)
            {
                var personalAccountReport = new PersonalAccountReport(employees, flagZeroCharges, checkIsAllEmployees.Checked, IsRegion);
                PersonalAccountReports = personalAccountReport.GetPersonalAccountReport(month, year);
                return PersonalAccountReports;
            }

            return null;
        }

        private void BtnMenuItemExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BtnMenuItemSettings_Click(object sender, EventArgs e)
        {
            if (ReportSettings.readingDataBase == null || ReportSettings.readingDataBase?.dbConnectionAsync?.State != ConnectionState.Open)
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

        private async void BtnMenuItemImportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var tokenSource = new CancellationTokenSource();
                CancellationToken ct = tokenSource.Token;

                dataGridView.SelectAll();
                DataObject dataObj = dataGridView.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);
                }

                await Task.Run(() => Export(ct, IsRegion)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Export(CancellationToken token, bool isRegion)
        {
            token.ThrowIfCancellationRequested();
            if (dataGridView.DataSource == null)
            {
                return;
            }

            var templateDirectory = default(string);

            if (isRegion)
            {
                templateDirectory = $"{Environment.CurrentDirectory}\\template\\Regional payroll analysis.xlsx";
            }
            else
            {
                templateDirectory = $"{Environment.CurrentDirectory}\\template\\Federal payroll analysis.xlsx";
            }
            
            var reportDirectory = $"{Path.GetTempPath()}{Guid.NewGuid().ToString().Substring(0, 6).ToUpper()}.xlsx";

            File.Copy(templateDirectory, reportDirectory);

            Excel.Application xlexcel;
            Workbook xlWorkBook;

            xlexcel = new Excel.Application();
            xlWorkBook = xlexcel.Workbooks.Open(reportDirectory);
            var xlWorkSheet1 = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet1.Activate();

            Range CR = (Range)xlWorkSheet1.Cells[5, 1];
            CR.Select();            
            xlWorkSheet1.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            //xlWorkSheet1.UsedRange.Cells.Borders.LineStyle = XlLineStyle.xlContinuous;

            var xlWorkSheet2 = (Worksheet)xlWorkBook.Worksheets[2];
            xlWorkSheet2.Activate();
            xlWorkSheet2.Cells[2, 1].Value = ReportSettings.settings.organization;
            xlWorkSheet2.Cells[2, 2].Value = ReportSettings.settings.inn;
            xlWorkSheet2.Cells[2, 3].Value = ReportSettings.settings.region;

            if (PersonalAccountReports != null && PersonalAccountReports.Count > 0)
            {
                var xlWorkSheet3 = (Worksheet)xlWorkBook.Worksheets[3];
                xlWorkSheet3.Activate();

                var personSubdivision = PersonalAccountReports.Select(a => a.Subdivision).GroupBy(g => g).ToList();

                for (int i = 0; i < personSubdivision.Count; i++)
                {
                    xlWorkSheet3.Cells[i + 2, 1].Value = personSubdivision[i].Key;
                    xlWorkSheet3.Cells[i + 2, 2].Value = ReportSettings.settings.organization;
                    xlWorkSheet3.Cells[i + 2, 3].Value = ReportSettings.settings.inn;
                    xlWorkSheet3.Cells[i + 2, 4].Value = ReportSettings.settings.region;
                }
            }            
            
            var positions = (ReportSettings.settings == null || ReportSettings.settings.Positions == null || ReportSettings.settings.Positions.Count == 0) ? 
                ReportSettings.readingDataBase?.Positions ?? null : 
                ReportSettings.readingDataBase?.Positions?.Where(w => ReportSettings.settings.Positions.Contains(w.Name)).ToList();

            if (positions != null)
            {
                var xlWorkSheet4 = (Worksheet)xlWorkBook.Worksheets[4];
                xlWorkSheet4.Activate();

                for (int i = 0; i < positions.Count; i++)
                {
                    xlWorkSheet4.Cells[i + 2, 1].Value = positions[i].Memo;
                    xlWorkSheet4.Cells[i + 2, 2].Value = positions[i].Name;
                }
            }

            xlWorkSheet1.Activate();

            xlexcel.Visible = true;
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
            ReportSettings.readingDataBase.ReaderEvent += ReadingDataBase_ReaderEvent;
            ReportSettings.readingDataBase.LoadData += ReadingDataBase_LoadData;
            ReportSettings.readingDataBase.GetInformation();

            if (ReportSettings.readingDataBase?.dbConnectionAsync?.State == ConnectionState.Open)
            {
                toolStripStatusLabelBool.Text = "активно";
                toolStripStatusLabelBool.ForeColor = Color.Green;
                btnConnectParus.Enabled = false;
            }
            else
            {
                toolStripStatusLabelBool.Text = "неактивно";
                toolStripStatusLabelBool.ForeColor = Color.DarkRed;
            }
        }

        private void ReadingDataBase_LoadData(object sender, Tuple<string, int, bool> e)
        {
            this?.Invoke((System.Action)delegate {
                toolStripStatusLabel1.Text = e.Item1;
                toolStripProgressBar.Maximum = e.Item2;
                toolStripProgressBar.Visible = e.Item3;
            });            
        }

        private void ReadingDataBase_ReaderEvent(object sender, int e)
        {
            this?.Invoke((System.Action)delegate {
                if (toolStripProgressBar.Maximum < e)
                {
                    toolStripProgressBar.Maximum = toolStripProgressBar.Maximum = e + 1;
                }

                toolStripProgressBar.Value = e;
            });
        }

        private void btnMenuItemInfo_Click(object sender, EventArgs e)
        {
            var form = new FormInfo();
            form.ShowDialog();
        }

        private void FormReport_Resize(object sender, EventArgs e)
        {
            if (SpinningCircles != null)
            {
                SpinningCircles.Top = dataGridView.Height / 2 - SpinningCircles.Height;
                SpinningCircles.Left = dataGridView.Width / 2 - SpinningCircles.Width / 2;
                SpinningCircles.Refresh();
            }
        }

        private void checkIsRegion_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as System.Windows.Forms.CheckBox;

            if (checkBox != null)
            {
                if (checkBox.Checked)
                {
                    IsRegion = true;
                }
                else
                {
                    IsRegion = false;
                }
            }
        }
    }
}
