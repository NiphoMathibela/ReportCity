using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{

    // Model class for an issue
    public class IssueModel
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; } // Path to the image file
        public string? Status { get; set; } // Status of the request (e.g., Open, In Progress, Closed)
    }

    // TreeNode class for the binary tree
    public class TreeNode
    {
        public IssueModel Issue { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(IssueModel issue)
        {
            Issue = issue;
            Left = null;
            Right = null;
        }
    }

    // Binary tree class for storing issues
    public class IssueBinaryTree
    {
        private TreeNode root;

        public IssueBinaryTree()
        {
            root = null;
        }

        public void Insert(IssueModel issue)
        {
            root = InsertRec(root, issue);
        }

        private TreeNode InsertRec(TreeNode root, IssueModel issue)
        {
            if (root == null)
            {
                return new TreeNode(issue);
            }

            if (issue.Id < root.Issue.Id) // Change this to another property if needed
            {
                root.Left = InsertRec(root.Left, issue);
            }
            else if (issue.Id > root.Issue.Id)
            {
                root.Right = InsertRec(root.Right, issue);
            }
            return root;
        }

        public TreeNode GetRoot()
        {
            return root;
        }

        // Optional: In-order traversal to get issues in sorted order
        public List<IssueModel> InOrderTraversal()
        {
            List<IssueModel> issues = new List<IssueModel>();
            InOrderRec(root, issues);
            return issues;
        }

        private void InOrderRec(TreeNode root, List<IssueModel> issues)
        {
            if (root != null)
            {
                InOrderRec(root.Left, issues);
                issues.Add(root.Issue);
                InOrderRec(root.Right, issues);
            }
        }
    }
}
