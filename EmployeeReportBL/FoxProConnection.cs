using System.Data.OleDb;
using System.Threading.Tasks;

namespace EmployeeReportBL
{
    public class FoxProConnection
    {
        public OleDbConnection DbConnection { get; set; }

        public OleDbConnection AsyncDbConnection { get; set; }

        public FoxProConnection(string path)
        {
            if (path == string.Empty)
            {
                throw new System.ArgumentNullException(nameof(path), "Не задан путь к БД Парус Бюджет 7.");
            }

            var connectionstring = $"Provider=Microsoft OLE DB Provider for Visual FoxPro;Data Source={path}";

            DbConnection = new OleDbConnection(connectionstring);
            DbConnection.Open();
        }

        private FoxProConnection(OleDbConnection AsyncDbConnection)
        {
            this.AsyncDbConnection = AsyncDbConnection;
        }

        public async Task<FoxProConnection> GetOleDbConnection(string path)
        {
            if (path == string.Empty)
            {
                throw new System.ArgumentNullException(nameof(path), "Не задан путь к БД Парус Бюджет 7.");
            }

            var connectionstring = $"Provider=Microsoft OLE DB Provider for Visual FoxPro;Data Source={path}";

            AsyncDbConnection = new OleDbConnection(connectionstring);
            await AsyncDbConnection.OpenAsync();

            return new FoxProConnection(AsyncDbConnection);
        }
    }
}
