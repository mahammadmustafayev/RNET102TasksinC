using System.Data;
using System.Data.OleDb;

namespace Req
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string path = "C:\\Users\\mahammadvm\\Desktop\\Req\\Req\\Data\\example_data.xlsx";
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mahammadvm\Desktop\Req\Req\Data\example_data.xlsx;Extended Properties=""Excel 8.0;HDR=YES"";";
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from [Sheet1$]", connection);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            
        }
    }
}