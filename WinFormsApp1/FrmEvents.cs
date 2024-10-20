using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmEvents : Form
    {
        public Dictionary<DateTime, string> announcementList = new Dictionary<DateTime, string>();
        public FrmEvents()
        {
            InitializeComponent();

            // Populate the dictionary with sample announcements
            announcementList.Add(DateTime.Now.AddDays(-2), "Community meeting tomorrow at 10 AM.");
            announcementList.Add(DateTime.Now.AddDays(-2), "Road closure on the R21 from 2 PM.");
            announcementList.Add(DateTime.Now.AddDays(-2), "Community council meeting at 4 PM.");

            // Bind the dictionary to the DataGridView
            dataGridView1.DataSource = new BindingSource(announcementList, null);
            dataGridView1.Columns[0].HeaderText = "Date";
            dataGridView1.Columns[1].HeaderText = "Announcement";

            //Business class object
            BusinessClass businessObject = new BusinessClass();

            //Displaying all events 
            //List<EventModel> events = businessObject.GetEvents();

            //dataGridEvents.DataSource = events;

            //Displaying announcements using a Stack
            Stack<AnnouncementModel> announcements = new Stack<AnnouncementModel>();

            //Looping and Creating instances of Announcements
            for (int i = 0; i < 5; i++)
            {
                AnnouncementModel announcement = new AnnouncementModel();
                announcement.Date = DateTime.Now;
                announcement.AnnouncementText = "Something happening in the Community: " + i.ToString();

                //Pushing the instance of the announcement
                announcements.Push(announcement);
            }

            //Display Stack List
            dataGridView2.DataSource = announcements.ToList();
        }

        //Business class object
        BusinessClass businessObject = new BusinessClass();

        //Event list for Search
        List<EventModel> eventSearch = new List<EventModel>();

        //Event List
        HashSet<string> eventHashSet = new HashSet<string>();

        private void lblEvents_Click(object sender, EventArgs e)
        {

        }

        //Search Function
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search functionality
            string searchText = txtSearch.Text;

            HashSet<string> searchSet = new HashSet<string>();

            // Assuming eventHashSet is already populated
            eventHashSet.Add("Malebo community meeting 28/10/2024");
            eventHashSet.Add("Kempton Park community meeting 28/11/2024");
            eventHashSet.Add("Park clean up 28/10/2024");

            // Search using Contains
            foreach (var item in eventHashSet)
            {
                if (item.ToLower().Contains(searchText.ToLower()))
                {
                    searchSet.Add(item);
                }
            }

            dataGridViewResults.DataSource = searchSet.Select(x => new { Event = x }).ToList();
        }
    }
}
