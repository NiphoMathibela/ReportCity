namespace WinFormsApp1
{
    partial class FrmStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewIssues = new ListView();
            lblIssues = new Label();
            listViewHeap = new ListView();
            lblHeap = new Label();
            SuspendLayout();
            // 
            // listViewIssues
            // 
            listViewIssues.Location = new Point(55, 127);
            listViewIssues.Name = "listViewIssues";
            listViewIssues.Size = new Size(607, 363);
            listViewIssues.TabIndex = 0;
            listViewIssues.UseCompatibleStateImageBehavior = false;
            // 
            // lblIssues
            // 
            lblIssues.AutoSize = true;
            lblIssues.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblIssues.Location = new Point(55, 62);
            lblIssues.Name = "lblIssues";
            lblIssues.Size = new Size(285, 46);
            lblIssues.TabIndex = 1;
            lblIssues.Text = "Reported Issues";
            lblIssues.Click += lblEvents_Click;
            // 
            // listViewHeap
            // 
            listViewHeap.Location = new Point(701, 127);
            listViewHeap.Name = "listViewHeap";
            listViewHeap.Size = new Size(607, 363);
            listViewHeap.TabIndex = 2;
            listViewHeap.UseCompatibleStateImageBehavior = false;
            // 
            // lblHeap
            // 
            lblHeap.AutoSize = true;
            lblHeap.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblHeap.Location = new Point(701, 62);
            lblHeap.Name = "lblHeap";
            lblHeap.Size = new Size(391, 46);
            lblHeap.TabIndex = 3;
            lblHeap.Text = "Sorted by  importance";
            // 
            // FrmStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 674);
            Controls.Add(lblHeap);
            Controls.Add(listViewHeap);
            Controls.Add(lblIssues);
            Controls.Add(listViewIssues);
            Name = "FrmStatus";
            Text = "FrmStatus";
            Load += FrmStatus_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewIssues;
        private Label lblIssues;
        private ListView listViewHeap;
        private Label lblHeap;
    }
}