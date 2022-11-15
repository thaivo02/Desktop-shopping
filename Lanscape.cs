namespace Sneakerz
{
    public partial class Lanscape : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public Lanscape()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picRun1_Click(object sender, EventArgs e)
        {
            Info frm = new Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}