using System.Data;
using DataAccessLayer.Models;
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

        //Retrieving events
        public List<EventModel> GetEvents()
        {
            OpenCloseDatabase();
            string sql = $"select * from events;";
            cmd = new MySqlCommand(sql, conn);

            //List of events
            List<EventModel> eventList = new List<EventModel>();

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    EventModel model = new EventModel();

                    model.Id = reader.GetInt32(0);
                    model.Title = reader.GetString(1);
                    model.Description = reader.GetString(2);
                    model.Date = reader.GetDateTime(3);
                    model.Location = reader.GetString(4);
                    model.Priority = reader.GetString(5);

                    //Adding instance of event to List of events
                    eventList.Add(model);
                }
            }

            return eventList;
        }
    }
}
