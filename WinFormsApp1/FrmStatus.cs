﻿using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FrmStatus : Form
    {
        private IssueBinaryTree issueTree;
        private DataClass dataClass;
        private MinHeap issueHeap;

        public FrmStatus()
        {
            InitializeComponent();
            dataClass = new DataClass();
            issueTree = new IssueBinaryTree();

            LoadIssues();
            InitializeListView();
            LoadAndDisplayIssues(); // Load and display issues in the heap
        }

        private void InitializeListView()
        {
            // Set the ListView properties for the binary tree
            listViewIssues.View = View.Details;
            listViewIssues.FullRowSelect = true;
            listViewIssues.Columns.Add("Location", 100);
            listViewIssues.Columns.Add("Category", 100);
            listViewIssues.Columns.Add("Description", 200);
            listViewIssues.Columns.Add("Image Path", 150);
            listViewIssues.Columns.Add("Status", 100);

            // Set the ListView properties for the heap
            listViewHeap.View = View.Details; // Assuming listViewHeap is already declared and initialized
            listViewHeap.FullRowSelect = true;
            listViewHeap.Columns.Add("Location", 100);
            listViewHeap.Columns.Add("Category", 100);
            listViewHeap.Columns.Add("Description", 200);
            listViewHeap.Columns.Add("Image Path", 150);
            listViewHeap.Columns.Add("Status", 100);
        }

        private void LoadIssues()
        {
            var issues = dataClass.GetIssues(); // Retrieve issues from the database
            foreach (var issue in issues)
            {
                issueTree.Insert(issue); // Insert each issue into the binary tree
                AddIssueToTreeView(issue); // Add the issue to the binary tree ListView
            }
        }

        private void AddIssueToTreeView(IssueModel issue)
        {
            // Create a ListViewItem for each issue
            var item = new ListViewItem(issue.Location);
            item.SubItems.Add(issue.Category);
            item.SubItems.Add(issue.Description);
            item.SubItems.Add(issue.ImagePath);
            item.SubItems.Add(issue.Status);

            // Add the item to the ListView for the binary tree
            listViewIssues.Items.Add(item);
        }

        private void LoadAndDisplayIssues()
        {
            issueHeap = PopulateHeapWithIssues(); // Populate the heap with issues
            DisplayHeapInListView(issueHeap); // Display the heap in the ListView for the heap
        }

        private MinHeap PopulateHeapWithIssues()
        {
            List<IssueModel> issues = dataClass.GetIssues(); // Fetch issues from the database
            MinHeap issueHeap = new MinHeap();

            // Insert all issues into the heap
            foreach (var issue in issues)
            {
                issueHeap.Insert(issue);
            }

            return issueHeap;
        }

        private void DisplayHeapInListView(MinHeap issueHeap)
        {
            listViewHeap.Items.Clear(); // Clear existing items in the heap ListView

            // Extract elements from the heap until it's empty
            while (true)
            {
                try
                {
                    IssueModel issue = issueHeap.RemoveMin(); // Get the issue with the highest priority
                    var item = new ListViewItem(issue.Location);
                    item.SubItems.Add(issue.Category);
                    item.SubItems.Add(issue.Description);
                    item.SubItems.Add(issue.ImagePath);
                    item.SubItems.Add(issue.Status);

                    // Add the item to the ListView for the heap
                    listViewHeap.Items.Add(item);
                }
                catch (InvalidOperationException)
                {
                    // Break the loop if the heap is empty
                    break;
                }
            }
        }

        private void lblEvents_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }

        private void FrmStatus_Load(object sender, EventArgs e)
        {
            // Handle form load if needed
        }
    }
}