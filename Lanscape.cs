using Guna.UI2.WinForms;
using Sneakerz.Entity;
using System.Windows.Forms;
using Sneakerz.Model;
using Sneakerz.Repository.Item;
using Sneakerz.Services.Item;

namespace Sneakerz
{
    public partial class Lanscape : Form
    {
        private readonly IItemServices _itemServices;
        private readonly List<Item> items = new List<Item>();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void swap(ref String a, ref String b)
        {
            String temp = a;
            a = b;
            b = temp;
        }

        public Lanscape(IItemServices itemServices)
        {
            _itemServices = itemServices;
            items = _itemServices.GetListItem(new ItemQuery());
            InitializeComponent();
            this.Home();
        }

        private void Home()
        {
            picRun1.Image = Image.FromFile(picRun1.ImageLocation = items[0].ImageUrl);
            picRun2.Image = Image.FromFile(picRun2.ImageLocation = items[1].ImageUrl);
            picRun3.Image = Image.FromFile(picRun3.ImageLocation = items[2].ImageUrl);
            picRun4.Image = Image.FromFile(picRun4.ImageLocation = items[3].ImageUrl);
            picRun5.Image = Image.FromFile(picRun5.ImageLocation = items[4].ImageUrl);
            picRun6.Image = Image.FromFile(picRun6.ImageLocation = items[5].ImageUrl);
            picRun7.Image = Image.FromFile(picRun7.ImageLocation = items[6].ImageUrl);
            picLife1.Image = Image.FromFile(picLife1.ImageLocation = items[14].ImageUrl);
            picLife2.Image = Image.FromFile(picLife2.ImageLocation = items[15].ImageUrl);
            picLife3.Image = Image.FromFile(picLife3.ImageLocation = items[16].ImageUrl);
            picLife4.Image = Image.FromFile(picLife4.ImageLocation = items[17].ImageUrl);
            picLife5.Image = Image.FromFile(picLife5.ImageLocation = items[18].ImageUrl);
            picLife6.Image = Image.FromFile(picLife6.ImageLocation = items[19].ImageUrl);
            picLife7.Image = Image.FromFile(picLife7.ImageLocation = items[20].ImageUrl);
            picBall1.Image = Image.FromFile(picBall1.ImageLocation = items[28].ImageUrl);
            picBall2.Image = Image.FromFile(picBall2.ImageLocation = items[29].ImageUrl);
            picBall3.Image = Image.FromFile(picBall3.ImageLocation = items[30].ImageUrl);
            picBall4.Image = Image.FromFile(picBall4.ImageLocation = items[31].ImageUrl);
            picBall5.Image = Image.FromFile(picBall5.ImageLocation = items[32].ImageUrl);
            picBall6.Image = Image.FromFile(picBall6.ImageLocation = items[33].ImageUrl);
            picBall7.Image = Image.FromFile(picBall7.ImageLocation = items[34].ImageUrl);

            // items.ForEach(i =>
            // {
            //     _itemServices.AddItem(i);
            // });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            Guna2PictureBox pressed = (Guna2PictureBox)sender;
            String location = pressed.ImageLocation;
            Info frm = new Info(location) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            btnSearch.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Home();
        }

        private void btnNike_Click(object sender, EventArgs e)
        {
            picRun1.Image = Image.FromFile(picRun1.ImageLocation = items[0].ImageUrl);
            picRun2.Image = Image.FromFile(picRun2.ImageLocation = items[1].ImageUrl);
            picRun3.Image = Image.FromFile(picRun3.ImageLocation = items[2].ImageUrl);
            picRun4.Image = Image.FromFile(picRun4.ImageLocation = items[3].ImageUrl);
            picRun5.Image = Image.FromFile(picRun5.ImageLocation = items[4].ImageUrl);
            picRun6.Image = Image.FromFile(picRun6.ImageLocation = items[5].ImageUrl);
            picRun7.Image = Image.FromFile(picRun7.ImageLocation = items[6].ImageUrl);
            picLife1.Image = Image.FromFile(picLife1.ImageLocation = items[7].ImageUrl);
            picLife2.Image = Image.FromFile(picLife2.ImageLocation = items[8].ImageUrl);
            picLife3.Image = Image.FromFile(picLife3.ImageLocation = items[9].ImageUrl);
            picLife4.Image = Image.FromFile(picLife4.ImageLocation = items[10].ImageUrl);
            picLife5.Image = Image.FromFile(picLife5.ImageLocation = items[11].ImageUrl);
            picLife6.Image = Image.FromFile(picLife6.ImageLocation = items[12].ImageUrl);
            picLife7.Image = Image.FromFile(picLife7.ImageLocation = items[13].ImageUrl);
            picBall1.Image = Image.FromFile(picBall1.ImageLocation = items[14].ImageUrl);
            picBall2.Image = Image.FromFile(picBall2.ImageLocation = items[15].ImageUrl);
            picBall3.Image = Image.FromFile(picBall3.ImageLocation = items[16].ImageUrl);
            picBall4.Image = Image.FromFile(picBall4.ImageLocation = items[17].ImageUrl);
            picBall5.Image = Image.FromFile(picBall5.ImageLocation = items[18].ImageUrl);
            picBall6.Image = Image.FromFile(picBall6.ImageLocation = items[19].ImageUrl);
            picBall7.Image = Image.FromFile(picBall7.ImageLocation = items[20].ImageUrl);
        }

        private void btnAdidas_Click(object sender, EventArgs e)
        {
            picRun1.Image = Image.FromFile(picRun1.ImageLocation = items[0].ImageUrl);
            picRun2.Image = Image.FromFile(picRun2.ImageLocation = items[1].ImageUrl);
            picRun3.Image = Image.FromFile(picRun3.ImageLocation = items[2].ImageUrl);
            picRun4.Image = Image.FromFile(picRun4.ImageLocation = items[3].ImageUrl);
            picRun5.Image = Image.FromFile(picRun5.ImageLocation = items[4].ImageUrl);
            picRun6.Image = Image.FromFile(picRun6.ImageLocation = items[5].ImageUrl);
            picRun7.Image = Image.FromFile(picRun7.ImageLocation = items[6].ImageUrl);
            picLife1.Image = Image.FromFile(picLife1.ImageLocation = items[7].ImageUrl);
            picLife2.Image = Image.FromFile(picLife2.ImageLocation = items[8].ImageUrl);
            picLife3.Image = Image.FromFile(picLife3.ImageLocation = items[9].ImageUrl);
            picLife4.Image = Image.FromFile(picLife4.ImageLocation = items[10].ImageUrl);
            picLife5.Image = Image.FromFile(picLife5.ImageLocation = items[11].ImageUrl);
            picLife6.Image = Image.FromFile(picLife6.ImageLocation = items[12].ImageUrl);
            picLife7.Image = Image.FromFile(picLife7.ImageLocation = items[13].ImageUrl);
            picBall1.Image = Image.FromFile(picBall1.ImageLocation = items[14].ImageUrl);
            picBall2.Image = Image.FromFile(picBall2.ImageLocation = items[15].ImageUrl);
            picBall3.Image = Image.FromFile(picBall3.ImageLocation = items[16].ImageUrl);
            picBall4.Image = Image.FromFile(picBall4.ImageLocation = items[17].ImageUrl);
            picBall5.Image = Image.FromFile(picBall5.ImageLocation = items[18].ImageUrl);
            picBall6.Image = Image.FromFile(picBall6.ImageLocation = items[19].ImageUrl);
            picBall7.Image = Image.FromFile(picBall7.ImageLocation = items[20].ImageUrl);
        }
    }
}