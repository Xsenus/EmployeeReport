using EmployeeReportBL;
using EmployeeReportBL.Enumeration;
using EmployeeReportBL.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ReportWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<PersonalAccountReport> PersonalAccountReports;
        private async void button_Click(object sender, RoutedEventArgs e)
        {

            var path = ReportSettings.settings.path;

            path = textBox.Text;

            ReportSettings.readingDataBase = new ReadingDataBase(path);
            ReportSettings.readingDataBase.GetInformation();
            try
            {
                var tokenSource = new CancellationTokenSource();
                CancellationToken ct = tokenSource.Token;

                dataGrid.DataContext = await GetReportAsync(2019, (Month)9, ct);
                dataGrid.ItemsSource = await GetReportAsync(2019, (Month)9, ct);
                dataGrid.UpdateLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task<List<PersonalAccountReport>> GetReportAsync(int year, Month month, CancellationToken token)
        {
            return await Task.Run(() => GetReport(year, month, token)).ConfigureAwait(false);
        }

        private List<PersonalAccountReport> GetReport(int year, Month month, CancellationToken token)
        {
            var employees = ReportSettings.readingDataBase.GetEmployeesAsync(year, month, token).Result;

            if (employees != null)
            {
                var personalAccountReport = new PersonalAccountReport(employees);
                PersonalAccountReports = personalAccountReport.GetPersonalAccountReport(month);
                return PersonalAccountReports;
            }

            return null;
        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            button.Content = ReportSettings.settings.path;
        }
    }
}
