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

        private String[] nike_running = { "nrunning_freerun_5", "nrunning_pegasus_39", "nrunning_pegasus_turbo_", "nrunning_pegasus_trial_4", "nrunning_react_infinity_run_flyknit_3", "nrunning_zoom_fly", "nrunning_zoom_fly" };
        private String[] nike_lifestyle = { "nlifestyle_air_force_1_", "nlifestyle_air_max_90", "nlifestyle_air_max_97", "nlifestyle_air_max_flyknit_racer", "nlifestyle_airmax_plus", "nlifestyle_blazer_mid_77", "nlifestyle_vapormax_2021_flyknit" };
        private String[] nike_basketball = { "nbasketball_cosmic_unity_2", "nbasketball_jordan_why_not_5", "nbasketball_kd15", "nbasketball_lebron_xx", "nbasketball_pg6", "nbasketball_zoom_freak_4", "nbasketball_zoom_gt_cut_2" };
        private String[] adidas_running = { "drunning_4dfwd_2", "drunning_adistar_1", "drunning_adizero_adios_pro_3", "drunning_adizero_prime_x", "drunning_pureboost_22", "drunning_supernove_2", "drunning_ultraboost_22" };
        private String[] adidas_lifestyle = { "dlifestyle_hoops_3.0_low", "dlifestyle_nmd_r1_v2", "dlifestyle_ozella", "dlifestyle_questar_flow_nxt", "dlifestyle_stan_smith", "dlifestyle_swift_run", "dlifestyle_ultraboost_dna" };
        private String[] adidas_basketball = { "dbasketball_don_issue_3", "dbasketball_don_issue_4", "dbasketball_drose_son_of_chi", "dbasketball_harden_stepback_3", "dbasketball_harden_vol_6", "dbasketball_super_dame_8", "dbasketball_trae_young_2.0" };
        
        private void shuffleImages(String[] quests)
        {
            Random _random = new Random();
            for (int i = 0; i < quests.Length; i++)
                swap(ref quests[i], ref quests[i + _random.Next(quests.Length - i)]);
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
            List<Item> items = new List<Item>();
            for (int i = 0; i < 7; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + nike_running[i] + ".png", Name = "Nike", ReleaseDate = 2021 });
            for (int i = 7; i < 14; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + adidas_running[i-7] + ".png", Name = "Adidas", ReleaseDate = 2021 });
            for (int i = 14; i < 21; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + nike_lifestyle[i-14] + ".png", Name = "Nike", ReleaseDate = 2021 });
            for (int i = 21; i < 28; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + adidas_lifestyle[i-21] + ".png", Name = "Adidas", ReleaseDate = 2021 });
            for (int i = 28; i < 35; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + nike_basketball[i-28] + ".png", Name = "Nike", ReleaseDate = 2021 });
            for (int i = 35; i < 42; i++)
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + adidas_basketball[i-35] + ".png", Name = "Adidas", ReleaseDate = 2021 });
            
            picRun1.Image = Image.FromFile(items[0].ImageUrl);
            picRun2.Image = Image.FromFile(items[0].ImageUrl);

            //if (OnKeyPress)
            //{
            //    var searchitem = _itemservice.search
            //    Search frm = new Search(searchitem);
            //    Form search.show();
            //}
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
            frm.Closed += (s, args) => this.Close();
            frm.Show();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            btnSearch.Visible = false;
        }
    }
}