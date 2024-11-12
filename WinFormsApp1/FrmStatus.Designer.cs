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
            SuspendLayout();
            // 
            // listViewIssues
            // 
            listViewIssues.Location = new Point(186, 29);
            listViewIssues.Name = "listViewIssues";
            listViewIssues.Size = new Size(607, 363);
            listViewIssues.TabIndex = 0;
            listViewIssues.UseCompatibleStateImageBehavior = false;
            // 
            // FrmStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 674);
            Controls.Add(listViewIssues);
            Name = "FrmStatus";
            Text = "FrmStatus";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewIssues;
    }
}