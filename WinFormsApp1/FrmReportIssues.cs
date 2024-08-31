using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmReportIssues : Form
    {
        public FrmReportIssues()
        {
            InitializeComponent();

            List<string> categories = new List<string> { "Roads & Traffic", "Waste Management", "Water & Sewage", "Electricity", "Transportation" };
            listCategory.DataSource = categories;
        }

        //Business Class Object
        BusinessLayer.BusinessClass BusinessObject = new BusinessLayer.BusinessClass();

        //Categories

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = listCategory.Text;
            string description = txtDescription.Text;
            string image = "An image";

            //Saves User Input To DB
            BusinessObject.CreateIssue(location, category, description, image);

            //Message box upon successful save
            MessageBox.Show("Your issue has been logged...");

            //Clear Inputs
            txtLocation.Text = "";
            listCategory.Text = "";
            txtDescription.Text = "";
            listCategory.Text = "";
        }
    }
}
