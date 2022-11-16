using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneakerz
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic1(object sender, EventArgs e)
        {
            Image image = picDefault.Image;
            picDefault.Image = picChange1.Image;
            picChange1.Image = image;
        }
        private void pic2(object sender, EventArgs e)
        {
            Image image = picDefault.Image;
            picDefault.Image = picChange2.Image;
            picChange2.Image = image;
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
