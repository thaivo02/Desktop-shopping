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

        private void picChange(object sender, EventArgs e)
        {
            this.picDefault.Image = ((GunaPictureBox)sender).Image;
        }
    }
}
