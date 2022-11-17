using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace Sneakerz
{
    public partial class Info : Form
    {
        public Info(String location)
        {
            InitializeComponent();
            picDefault.Image = Image.FromFile(location);
            String first = location.Insert(location.Length - 4, "(1)");
            String second = location.Insert(location.Length - 4, "(2)");
            picChange1.Image = Image.FromFile(first);
            picChange2.Image = Image.FromFile(second);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picChange(object sender, EventArgs e)
        {
            Image image = picDefault.Image;
            picDefault.Image = ((Guna2PictureBox)sender).Image;
            ((Guna2PictureBox)sender).Image = image;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Lanscape frm = new Lanscape() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Lanscape frm = Program._host.Services.GetRequiredService<Lanscape>();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
