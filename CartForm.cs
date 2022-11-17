using Guna.UI2.WinForms;

namespace Sneakerz
{
    public partial class CartForm : Form
    {
        public CartForm(String location)
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Lanscape frm = new Lanscape() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
