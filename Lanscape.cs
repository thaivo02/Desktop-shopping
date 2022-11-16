using Guna.UI2.WinForms;
using Sneakerz.Entity;
using System.Windows.Forms;

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

        private String[] running = { "nrunning_freerun_5", "nrunning_pegasus_39", "nrunning_pegasus_turbo_", "nrunning_pegasus_trial_4", "nrunning_react_infinity_run_flyknit_3", "nrunning_zoom_fly", "nrunning_zoomx_varpofly", "drunning_4dfwd_2", "drunning_adistar_1", "drunning_adizero_adios_pro_3", "drunning_adizero_prime_x", "drunning_pureboost_22", "drunning_supernove_2", "drunning_ultraboost_22" };
        private String[] lifestyle = { "nlifestyle_air_force_1_", "nlifestyle_air_max_90", "nlifestyle_air_max_97", "nlifestyle_air_max_flyknit_racer", "nlifestyle_airmax_plus", "nlifestyle_blazer_mid_77", "nlifestyle_vapormax_2021_flyknit", "dlifestyle_hoops_3.0_low", "dlifestyle_nmd_r1_v2", "dlifestyle_ozella", "dlifestyle_questar_flow_nxt", "dlifestyle_stan_smith", "dlifestyle_swift_run", "dlifestyle_ultraboost_dna" };
        private String[] basketball = { "nbasketball_cosmic_unity_2", "nbasketball_jordan_why_not_5", "nbasketball_kd15", "nbasketball_lebron_xx", "nbasketball_pg6", "nbasketball_zoom_freak_4", "nbasketball_zoom_gt_cut_2", "dbasketball_don_issue_3", "dbasketball_don_issue_4", "dbasketball_drose_son_of_chi", "dbasketball_harden_stepback_3", "dbasketball_harden_vol_6", "dbasketball_super_dame_8", "dbasketball_trae_young_2.0" };
        private String[] nike_running = { "nrunning_freerun_5", "nrunning_pegasus_39", "nrunning_pegasus_turbo_", "nrunning_pegasus_trial_4", "nrunning_react_infinity_run_flyknit_3", "nrunning_zoom_fly", "nrunning_zoomx_varpofly" };
        private String[] nike_lifestyle = { "nlifestyle_air_force_1_", "nlifestyle_air_max_90", "nlifestyle_air_max_97", "nlifestyle_air_max_flyknit_racer", "nlifestyle_airmax_plus", "nlifestyle_blazer_mid_77", "nlifestyle_vapormax_2021_flyknit" };
        private String[] nike_basketball = { "nbasketball_cosmic_unity_2", "nbasketball_jordan_why_not_5", "nbasketball_kd15", "nbasketball_lebron_xx", "nbasketball_pg6", "nbasketball_zoom_freak_4", "nbasketball_zoom_gt_cut_2" };
        private String[] adidas_running = { "drunning_4dfwd_2", "drunning_adistar_1", "drunning_adizero_adios_pro_3", "drunning_adizero_prime_x", "drunning_pureboost_22", "drunning_supernove_2", "drunning_ultraboost_22" };
        private String[] adidas_lifestyle = { "dlifestyle_hoops_3.0_low", "dlifestyle_nmd_r1_v2", "dlifestyle_ozella", "dlifestyle_questar_flow_nxt", "dlifestyle_stan_smith", "dlifestyle_swift_run", "dlifestyle_ultraboost_dna" };
        private String[] adidas_basketball = { "dbasketball_don_issue_3", "dbasketball_don_issue_4", "dbasketball_drose_son_of_chi", "dbasketball_harden_stepback_3", "dbasketball_harden_vol_6", "dbasketball_super_dame_8", "dbasketball_trae_young_2.0" };

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

        public Lanscape()
        {
            InitializeComponent();
            this.Home();

            //if (OnKeyPress)
            //{
            //    var searchitem = _itemservice.search
            //    Search frm = new Search(searchitem);
            //    Form search.show();
            //}
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

            picRun1.Image = Image.FromFile(items[0].ImageUrl);
            picRun2.Image = Image.FromFile(items[1].ImageUrl);
            picRun3.Image = Image.FromFile(items[2].ImageUrl);
            picRun4.Image = Image.FromFile(items[3].ImageUrl);
            picRun5.Image = Image.FromFile(items[4].ImageUrl);
            picRun6.Image = Image.FromFile(items[5].ImageUrl);
            picRun7.Image = Image.FromFile(items[6].ImageUrl);
            picLife1.Image = Image.FromFile(items[14].ImageUrl);
            picLife2.Image = Image.FromFile(items[15].ImageUrl);
            picLife3.Image = Image.FromFile(items[16].ImageUrl);
            picLife4.Image = Image.FromFile(items[17].ImageUrl);
            picLife5.Image = Image.FromFile(items[18].ImageUrl);
            picLife6.Image = Image.FromFile(items[19].ImageUrl);
            picLife7.Image = Image.FromFile(items[20].ImageUrl);
            picBall1.Image = Image.FromFile(items[28].ImageUrl);
            picBall2.Image = Image.FromFile(items[29].ImageUrl);
            picBall3.Image = Image.FromFile(items[30].ImageUrl);
            picBall4.Image = Image.FromFile(items[31].ImageUrl);
            picBall5.Image = Image.FromFile(items[32].ImageUrl);
            picBall6.Image = Image.FromFile(items[33].ImageUrl);
            picBall7.Image = Image.FromFile(items[34].ImageUrl);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            Info frm = new Info() { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
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

            picRun1.Image = Image.FromFile(items[0].ImageUrl);
            picRun2.Image = Image.FromFile(items[1].ImageUrl);
            picRun3.Image = Image.FromFile(items[2].ImageUrl);
            picRun4.Image = Image.FromFile(items[3].ImageUrl);
            picRun5.Image = Image.FromFile(items[4].ImageUrl);
            picRun6.Image = Image.FromFile(items[5].ImageUrl);
            picRun7.Image = Image.FromFile(items[6].ImageUrl);
            picLife1.Image = Image.FromFile(items[7].ImageUrl);
            picLife2.Image = Image.FromFile(items[8].ImageUrl);
            picLife3.Image = Image.FromFile(items[9].ImageUrl);
            picLife4.Image = Image.FromFile(items[10].ImageUrl);
            picLife5.Image = Image.FromFile(items[11].ImageUrl);
            picLife6.Image = Image.FromFile(items[12].ImageUrl);
            picLife7.Image = Image.FromFile(items[13].ImageUrl);
            picBall1.Image = Image.FromFile(items[14].ImageUrl);
            picBall2.Image = Image.FromFile(items[15].ImageUrl);
            picBall3.Image = Image.FromFile(items[16].ImageUrl);
            picBall4.Image = Image.FromFile(items[17].ImageUrl);
            picBall5.Image = Image.FromFile(items[18].ImageUrl);
            picBall6.Image = Image.FromFile(items[19].ImageUrl);
            picBall7.Image = Image.FromFile(items[20].ImageUrl);
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

            picRun1.Image = Image.FromFile(items[0].ImageUrl);
            picRun2.Image = Image.FromFile(items[1].ImageUrl);
            picRun3.Image = Image.FromFile(items[2].ImageUrl);
            picRun4.Image = Image.FromFile(items[3].ImageUrl);
            picRun5.Image = Image.FromFile(items[4].ImageUrl);
            picRun6.Image = Image.FromFile(items[5].ImageUrl);
            picRun7.Image = Image.FromFile(items[6].ImageUrl);
            picLife1.Image = Image.FromFile(items[7].ImageUrl);
            picLife2.Image = Image.FromFile(items[8].ImageUrl);
            picLife3.Image = Image.FromFile(items[9].ImageUrl);
            picLife4.Image = Image.FromFile(items[10].ImageUrl);
            picLife5.Image = Image.FromFile(items[11].ImageUrl);
            picLife6.Image = Image.FromFile(items[12].ImageUrl);
            picLife7.Image = Image.FromFile(items[13].ImageUrl);
            picBall1.Image = Image.FromFile(items[14].ImageUrl);
            picBall2.Image = Image.FromFile(items[15].ImageUrl);
            picBall3.Image = Image.FromFile(items[16].ImageUrl);
            picBall4.Image = Image.FromFile(items[17].ImageUrl);
            picBall5.Image = Image.FromFile(items[18].ImageUrl);
            picBall6.Image = Image.FromFile(items[19].ImageUrl);
            picBall7.Image = Image.FromFile(items[20].ImageUrl);
        }
    }
}