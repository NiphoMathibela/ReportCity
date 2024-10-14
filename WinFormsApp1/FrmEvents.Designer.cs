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
            lblEvents = new Label();
            SuspendLayout();
            // 
            // lblEvents
            // 
            lblEvents.AutoSize = true;
            lblEvents.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold);
            lblEvents.Location = new Point(131, 9);
            lblEvents.Name = "lblEvents";
            lblEvents.Size = new Size(666, 46);
            lblEvents.TabIndex = 0;
            lblEvents.Text = "Upcoming Events And Announcements";
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 523);
            Controls.Add(lblEvents);
            Name = "Events";
            Text = "Events";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEvents;
    }
}