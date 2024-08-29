using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataClass
    {
        static string connectionString = "server=localhost;database=report_city;uid=root;pwd='';";

        SqlConnection conn = new(connectionString);

        SqlCommand? cmd;

        void OpenCloseDatabase()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
            {
                conn.Close();
            }
        }
    }
}
