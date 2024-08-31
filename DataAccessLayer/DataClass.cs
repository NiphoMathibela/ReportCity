using System.Data;
using MySqlConnector;

namespace DataAccessLayer
{
    public class DataClass
    {
        static string connectionString = "server=localhost;database=report_city;uid=root;pwd='';";

        MySqlConnection conn = new MySqlConnection(connectionString);

        MySqlCommand? cmd;

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
            string sql = $"insert into issues(location, category, description, image) values('{location}', '{category}', '{description}', '{image}')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
