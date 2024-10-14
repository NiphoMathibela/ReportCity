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

        private void btnEvents_Click(object sender, EventArgs e)
        {
            FrmEvents form = new FrmEvents();
            this.Hide();
            form.ShowDialog();
            this.Visible = true;
        }
    }
}
