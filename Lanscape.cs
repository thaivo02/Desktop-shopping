using Guna.UI2.WinForms;
using Sneakerz.Entity;
using System.Windows.Forms;
using Sneakerz.Repository.Item;

namespace Sneakerz
{
    public partial class Lanscape : Form
    {
        private readonly IItemRepository _itemRepository;
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private String[] running = { "freerun_5", "pegasus_39", "pegasus_turbo_", "pegasus_trial_4", "react_infinity_run_flyknit_3", "zoom_fly", "zoomx_varpofly", "4dfwd_2", "adistar_1", "adizero_adios_pro_3", "adizero_prime_x", "pureboost_22", "supernova_2", "ultraboost_22" };
        private String[] lifestyle = { "air_force_1", "air_max_90", "air_max_97", "air_max_flyknit_racer", "airmax_plus", "blazer_mid_77", "vapormax_2021_flyknit", "hoops_3.0_low", "nmd_r1_v2", "ozella", "questar_flow_nxt", "stan_smith", "swift_run", "ultraboost_dna" };
        private String[] basketball = { "cosmic_unity_2", "jordan_why_not_5", "kd15", "lebron_xx", "pg6", "zoom_freak_4", "zoom_gt_cut_2", "don_issue_3", "don_issue_4", "drose_son_of_chi", "harden_stepback_3", "harden_vol_6", "super_dame_8", "trae_young_2.0" };
        private String[] nike_running = { "freerun_5", "pegasus_39", "pegasus_turbo_", "pegasus_trial_4", "react_infinity_run_flyknit_3", "zoom_fly", "zoomx_varpofly" };
        private String[] nike_lifestyle = { "air_force_1_", "air_max_90", "air_max_97", "air_max_flyknit_racer", "airmax_plus", "blazer_mid_77", "vapormax_2021_flyknit" };
        private String[] nike_basketball = { "cosmic_unity_2", "jordan_why_not_5", "kd15", "lebron_xx", "pg6", "zoom_freak_4", "zoom_gt_cut_2" };
        private String[] adidas_running = { "4dfwd_2", "adistar_1", "adizero_adios_pro_3", "adizero_prime_x", "pureboost_22", "supernove_2", "ultraboost_22" };
        private String[] adidas_lifestyle = { "hoops_3.0_low", "nmd_r1_v2", "ozella", "questar_flow_nxt", "stan_smith", "swift_run", "ultraboost_dna" };
        private String[] adidas_basketball = { "don_issue_3", "don_issue_4", "drose_son_of_chi", "harden_stepback_3", "harden_vol_6", "super_dame_8", "trae_young_2.0" };

        private void shuffleImages(String[] items)
        {
            Random _random = new Random();
            for (int i = 0; i < items.Length; i++)
                swap(ref items[i], ref items[i + _random.Next(items.Length - i)]);
        }

        private void swap(ref String a, ref String b)
        {
            String temp = a;
            a = b;
            b = temp;
        }

        public Lanscape(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            InitializeComponent();
            this.Home();

            //if (OnKeyPress)
            //{
            //    var searchitem = _itemservice.search
            //    Search frm = new Search(searchitem);
            //    Form search.show();
            //}
        }

        public Lanscape()
        {
            
        }
        
        private void Home()
        {
            List<Item> items = new List<Item>();
            shuffleImages(running);
            shuffleImages(lifestyle);
            shuffleImages(basketball);
            for (int i = 0; i < 14; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + running[i] + ".png", Name = "Sneaker", ReleaseDate = 2021 });
            for (int i = 14; i < 28; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + lifestyle[i - 14] + ".png", Name = "Sneaker", ReleaseDate = 2021 });
            for (int i = 28; i < 42; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + basketball[i - 28] + ".png", Name = "Sneaker", ReleaseDate = 2021 });

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
            List<Item> items = new List<Item>();
            shuffleImages(nike_running);
            shuffleImages(nike_lifestyle);
            shuffleImages(nike_basketball);
            for (int i = 0; i < 7; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + nike_running[i] + ".png", Name = "Nike", ReleaseDate = 2021 });
            for (int i = 7; i < 14; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + nike_lifestyle[i - 7] + ".png", Name = "Nike", ReleaseDate = 2021 });
            for (int i = 14; i < 21; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + nike_basketball[i - 14] + ".png", Name = "Nike", ReleaseDate = 2021 });

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
            List<Item> items = new List<Item>();
            shuffleImages(adidas_running);
            shuffleImages(adidas_lifestyle);
            shuffleImages(adidas_basketball);
            for (int i = 0; i < 7; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + adidas_running[i] + ".png", Name = "Adidas", ReleaseDate = 2021 });
            for (int i = 7; i < 14; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + adidas_lifestyle[i - 7] + ".png", Name = "Adidas", ReleaseDate = 2021 });
            for (int i = 14; i < 21; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + adidas_basketball[i - 14] + ".png", Name = "Adidas", ReleaseDate = 2021 });

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