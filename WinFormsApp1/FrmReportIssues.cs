﻿using BusinessLayer;
using Microsoft.Data.SqlClient;
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp\"";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            //Show opendialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // get the selected file path
                string filePath = openFileDialog1.FileName;
                // do something with the file path
                pictureBox1.Image = Image.FromFile(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
