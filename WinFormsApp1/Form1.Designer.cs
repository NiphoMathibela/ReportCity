namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReport = new Button();
            btnEvents = new Button();
            btnService = new Button();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.Location = new Point(34, 21);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(231, 183);
            btnReport.TabIndex = 0;
            btnReport.Text = "Report Issues";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnEvents
            // 
            btnEvents.Location = new Point(299, 21);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(227, 183);
            btnEvents.TabIndex = 1;
            btnEvents.Text = "Events and Announcements";
            btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnService
            // 
            btnService.Location = new Point(561, 21);
            btnService.Name = "btnService";
            btnService.Size = new Size(227, 183);
            btnService.TabIndex = 2;
            btnService.Text = "Service Request Status";
            btnService.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 617);
            Controls.Add(btnService);
            Controls.Add(btnEvents);
            Controls.Add(btnReport);
            Name = "Form1";
            Text = "Report City";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReport;
        private Button btnEvents;
        private Button btnService;
    }
}
