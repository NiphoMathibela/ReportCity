namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FrmReportIssues form = new FrmReportIssues();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
