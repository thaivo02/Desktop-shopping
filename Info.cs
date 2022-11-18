using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;

namespace Sneakerz
{
    public partial class Info : Form
    {
        public Info(Guna2PictureBox pressed)
        {
            InitializeComponent();
            int space = pressed.Name.IndexOf(' ');
            //String brand = pressed.Name.Substring(0, space);
            //String name = pressed.Name.Substring(space + 1, pressed.Name.Length - space);
            String location = pressed.ImageLocation;
            picDefault.Image = Image.FromFile(location);
            String first = location.Insert(location.Length - 4, "(1)");
            String second = location.Insert(location.Length - 4, "(2)");
            //labelBrand.Text= brand;
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

        private void mouseDown(object sender, MouseEventArgs e)
        {
            size1.FillColor = Color.Transparent;
            size2.FillColor = Color.Transparent;
            size3.FillColor = Color.Transparent;
            size4.FillColor = Color.Transparent;
            size5.FillColor = Color.Transparent;
            size6.FillColor = Color.Transparent;
            size7.FillColor = Color.Transparent;
            size8.FillColor = Color.Transparent;
            size9.FillColor = Color.Transparent;
            size10.FillColor = Color.Transparent;
            size11.FillColor = Color.Transparent;
            size12.FillColor = Color.Transparent;
            size13.FillColor = Color.Transparent;
            size14.FillColor = Color.Transparent;

            Guna2Button sizeChosen = (Guna2Button)sender;
            sizeChosen.FillColor= Color.Black;
        }

        private void btnAdd_to_cart_Click(object sender, EventArgs e)
        {

        }
    }
}
