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

        //Creating an issue
        public void CreateIssue(string location, string category, string description, string image)
        {
            OpenCloseDatabase();
            string sql = $"insert into Issues(location, category, description, image) values('{location}', '{category}', '{description}', '{image}')";\
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
