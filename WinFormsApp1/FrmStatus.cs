using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TreeNode = DataAccessLayer.Models.TreeNode;

namespace WinFormsApp1
{
    public partial class FrmStatus : Form
    {
        private IssueBinaryTree issueTree;
        private DataClass dataClass;

        public FrmStatus()
        {
            InitializeComponent();
            dataClass = new DataClass();
            issueTree = new IssueBinaryTree();

            LoadIssues();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Set the ListView properties
            listViewIssues.View = View.Details;
            listViewIssues.FullRowSelect = true;
            listViewIssues.Columns.Add("Location", 100);
            listViewIssues.Columns.Add("Category", 100);
            listViewIssues.Columns.Add("Description", 200);
            listViewIssues.Columns.Add("Image Path", 150);
            listViewIssues.Columns.Add("Status", 100);
        }

        private void LoadIssues()
        {
            var issues = dataClass.GetIssues(); // Retrieve issues from the database
            foreach (var issue in issues)
            {
                issueTree.Insert(issue); // Insert each issue into the binary tree
                AddIssueToListView(issue); // Add the issue to the ListView
            }
        }

        private void AddIssueToListView(IssueModel issue)
        {
            // Create a ListViewItem for each issue
            var item = new ListViewItem(issue.Location);
            item.SubItems.Add(issue.Category);
            item.SubItems.Add(issue.Description);
            item.SubItems.Add(issue.ImagePath);
            item.SubItems.Add(issue.Status);

            // Add the item to the ListView
            listViewIssues.Items.Add(item);
        }

        private void lblEvents_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatus_Load(object sender, EventArgs e)
        {

        }
    }
}