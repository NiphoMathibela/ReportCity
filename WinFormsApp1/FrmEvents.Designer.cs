namespace WinFormsApp1
{
    partial class FrmEvents
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblEvents = new Label();
            label1 = new Label();
            lblAnnouncements = new Label();
            dataGridView1 = new DataGridView();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            lblResults = new Label();
            dataGridViewResults = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            lblRecs = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblEvents.Location = new Point(455, 9);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(486, 46);
            lblEvents.TabIndex = 0;
            lblEvents.Text = "Events And Announcements";
            lblEvents.Click += lblEvents_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 235);
            label1.Name = "label1";
            label1.Size = new Size(129, 46);
            label1.TabIndex = 2;
            label1.Text = "Events";
            // 
            // lblAnnouncements
            // 
            lblAnnouncements.AutoSize = true;
            lblAnnouncements.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblAnnouncements.Location = new Point(12, 481);
            lblAnnouncements.Name = "lblAnnouncements";
            lblAnnouncements.Size = new Size(290, 46);
            lblAnnouncements.TabIndex = 3;
            lblAnnouncements.Text = "Announcements";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlText;
            dataGridView1.Location = new Point(12, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 154);
            dataGridView1.TabIndex = 4;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblResults.Location = new Point(741, 235);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(258, 46);
            lblResults.TabIndex = 6;
            lblResults.Text = "Search Results";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.BackgroundColor = SystemColors.Control;
            dataGridViewResults.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(741, 284);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewResults.Size = new Size(677, 154);
            dataGridViewResults.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(470, 144);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(333, 27);
            txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(809, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 530);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(677, 154);
            dataGridView2.TabIndex = 10;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.BorderStyle = BorderStyle.Fixed3D;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(741, 530);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(677, 154);
            dataGridView3.TabIndex = 12;
            // 
            // lblRecs
            // 
            lblRecs.AutoSize = true;
            lblRecs.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblRecs.Location = new Point(741, 481);
            lblRecs.Name = "lblRecs";
            lblRecs.Size = new Size(297, 46);
            lblRecs.TabIndex = 11;
            lblRecs.Text = "Recomendations";
            // 
            // FrmEvents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 832);
            Controls.Add(dataGridView3);
            Controls.Add(lblRecs);
            Controls.Add(dataGridView2);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dataGridViewResults);
            Controls.Add(lblResults);
            Controls.Add(dataGridView1);
            Controls.Add(lblAnnouncements);
            Controls.Add(label1);
            Controls.Add(lblEvents);
            Name = "FrmEvents";
            Text = "                ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEvents;
        private Label label1;
        private Label lblAnnouncements;
        private DataGridView dataGridView1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Label lblResults;
        private DataGridView dataGridViewResults;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Label lblRecs;
    }
}