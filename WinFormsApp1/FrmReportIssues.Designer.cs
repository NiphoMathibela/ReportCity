namespace WinFormsApp1
{
    partial class FrmReportIssues
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
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            listCategory = new ListBox();
            lblDescription = new Label();
            txtDescription = new RichTextBox();
            lblFile = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnImage = new Button();
            btnSubmit = new Button();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            slctImage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(50, 46);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(76, 22);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(50, 68);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(369, 26);
            txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(50, 139);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(80, 22);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // listCategory
            // 
            listCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listCategory.FormattingEnabled = true;
            listCategory.ItemHeight = 18;
            listCategory.Location = new Point(50, 162);
            listCategory.Name = "listCategory";
            listCategory.Size = new Size(369, 112);
            listCategory.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(50, 320);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(97, 22);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(50, 345);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(369, 142);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "";
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFile.Location = new Point(50, 552);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(60, 22);
            lblFile.TabIndex = 6;
            lblFile.Text = "Image";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImage
            // 
            btnImage.BackColor = Color.Black;
            btnImage.FlatStyle = FlatStyle.Popup;
            btnImage.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImage.ForeColor = SystemColors.Control;
            btnImage.Location = new Point(50, 577);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(160, 31);
            btnImage.TabIndex = 7;
            btnImage.Text = "Select Image";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Black;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(50, 691);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(160, 31);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Black;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(240, 691);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(160, 31);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(509, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(579, 419);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // slctImage
            // 
            slctImage.AutoSize = true;
            slctImage.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slctImage.Location = new Point(500, 46);
            slctImage.Name = "slctImage";
            slctImage.Size = new Size(131, 22);
            slctImage.TabIndex = 11;
            slctImage.Text = "Selected Image";
            // 
            // FrmReportIssues
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 807);
            Controls.Add(slctImage);
            Controls.Add(pictureBox1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnImage);
            Controls.Add(lblFile);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(listCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmReportIssues";
            Text = "Report Issues";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ListBox listCategory;
        private Label lblDescription;
        private RichTextBox txtDescription;
        private Label lblFile;
        private OpenFileDialog openFileDialog1;
        private Button btnImage;
        private Button btnSubmit;
        private Button btnBack;
        private PictureBox pictureBox1;
        private Label slctImage;
    }
}