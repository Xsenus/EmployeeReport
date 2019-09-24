using System.Data.OleDb;

namespace EmployeeReportBL
{
    public class FoxProConnection
    {
        public OleDbConnection DbConnection { get; set; }

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

        //private static async Task<OleDbConnection> GetOleDbConnection(string path)
        //{
        //    var connectString = string.Empty;

        //    if (Path.GetExtension(path).Equals(".xlsx"))
        //    {
        //        connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1;\"";
        //    }
        //    else
        //    {
        //        if (Path.GetExtension(path).Equals(".xls"))
        //        {
        //            connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0 Xml;HDR=YES;IMEX=1;\"";
        //        }
        //    }

        //    DbConnection = new OleDbConnection();
        //    await DbConnection.OpenAsync();

        //    return DbConnection;
        //}
    }
}
