using Guna.UI2.WinForms;
using Sneakerz.Entity;
using System.Windows.Forms;
using Sneakerz.Repository.Item;
using Sneakerz.Services.Item;

namespace Sneakerz
{
    public partial class Lanscape : Form
    {
        private readonly IItemServices _itemServices;
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private String[] running = { "Nike Air Zoom Alphafly NEXT% 2", "Nike Air Zoom Pegasus 39 Shield", "Nike Free Run 5.0", "Nike Pegasus Turbo Next Nature", "Nike React Infinity Run Flyknit 3", "Nike React Pegasus Trail 4 GORE-TEX", "Nike ZoomX Vaporfly NEXT% 2", "Adidas 4DFWD 2", "Adidas ADISTAR 1 REFUEL", "Adidas ADIZERO ADIOS PRO 3", "Adidas ADIZERO PRIME X", "Adidas PUREBOOST 22", "Adidas SUPERNOVA 2", "Adidas ULTRABOOST 22 COLD.RDY 2.0" };
        private String[] lifestyle = { "Nike Air Force 1", "Nike Air Max 90", "Nike Air Max 97", "Nike Air Max Flyknit Racer", "Nike Air Max Plus", "Nike Blazer Mid", "Nike Vapormax 2021 Flyknit", "Adidas HOOPS 3.0 LOW CLASSIC", "Adidas NMD_R1 V2", "Adidas OZELIA", "Adidas QUESTAR FLOW NXT", "Adidas STAN SMITH", "Adidas SWIFT RUN", "Adidas ULTRABOOST DNA CLIMACOOL" };
        private String[] basketball = { "Nike Air Zoom G.T. Cut 2", "Nike Comis Unity 2", "Nike Jordan Why Not Zero", "Nike KD15", "Nike LeBron XX", "Nike PG 6", "Nike Zoom Freak 4", "Adidas D ROSE SON OF CHI CHRISTMAS", "Adidas D.O.N. ISSUE #4", "Adidas HARDEN STEPBACK 3", "Adidas HARDEN VOL. 6", "Adidas LUNAR NEW YEAR D.O.N ISSUE 3", "Adidas SUPER DAME 8", "Adidas TRAE YOUNG 2.0" };
        private String[] nike_running = { "Air Zoom Alphafly NEXT% 2", "Air Zoom Pegasus 39 Shield", "Free Run 5.0", "Pegasus Turbo Next Nature", "React Infinity Run Flyknit 3", "React Pegasus Trail 4 GORE-TEX", "ZoomX Vaporfly NEXT% 2" };
        private String[] nike_lifestyle = { "Air Force 1", "Air Max 90", "Air Max 97", "Air Max Flyknit Racer", "Air Max Plus", "Blazer Mid", "Vapormax 2021 Flyknit" };
        private String[] nike_basketball = { "Air Zoom G.T. Cut 2", "Comis Unity 2", "Jordan Why Not Zero", "KD15", "LeBron XX", "PG 6", "Zoom Freak 4" };
        private String[] adidas_running = { "4DFWD 2", "ADISTAR 1 REFUEL", "ADIZERO ADIOS PRO 3", "ADIZERO PRIME X", "PUREBOOST 22", "SUPERNOVA 2", "ULTRABOOST 22 COLD.RDY 2.0" };
        private String[] adidas_lifestyle = { "HOOPS 3.0 LOW CLASSIC", "NMD_R1 V2", "OZELIA", "QUESTAR FLOW NXT", "STAN SMITH", "SWIFT RUN", "ULTRABOOST DNA CLIMACOOL" };
        private String[] adidas_basketball = { "D ROSE SON OF CHI CHRISTMAS", "D.O.N. ISSUE #4", "HARDEN STEPBACK 3", "HARDEN VOL. 6", "LUNAR NEW YEAR D.O.N ISSUE 3", "SUPER DAME 8", "TRAE YOUNG 2.0" };

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

        public Lanscape(IItemServices itemServices)
        {
            _itemServices = itemServices;
            InitializeComponent();
            this.Home();
        }

        private void Home()
        {
            List<Item> items = new List<Item>();
            shuffleImages(running);
            shuffleImages(lifestyle);
            shuffleImages(basketball);
            for (int i = 0; i < 14; i++)
            {
                String shoeLocation = running[i];
                int space = shoeLocation.IndexOf(" ");
                shoeLocation = shoeLocation.Remove(space, 1).Insert(space, "/");
                items.Add(new Item() { Id = (i+1).ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + shoeLocation + ".png", Name = running[i], ReleaseDate = 2021 }); 
            }
            for (int i = 14; i < 28; i++)
            {
                String shoeLocation = lifestyle[i - 14];
                int space = shoeLocation.IndexOf(" ");
                shoeLocation = shoeLocation.Remove(space, 1).Insert(space, "/");
                items.Add(new Item() { Id = (i+1).ToString(), CaregoryId = 2, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + shoeLocation + ".png", Name = lifestyle[i - 14], ReleaseDate = 2021 });
            }
            for (int i = 28; i < 42; i++)
            {
                String shoeLocation = basketball[i - 28];
                int space = shoeLocation.IndexOf(" ");
                shoeLocation = shoeLocation.Remove(space, 1).Insert(space, "/");
                items.Add(new Item() { Id = (i+1).ToString(), CaregoryId = 3, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + shoeLocation + ".png", Name = basketball[i - 28], ReleaseDate = 2021 });
            }

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
            List<Item> items = new List<Item>();
            shuffleImages(nike_running);
            shuffleImages(nike_lifestyle);
            shuffleImages(nike_basketball);
            for (int i = 0; i < 7; i++)
            {
                String name = "Nike";
                String shoeLocation = name + "/"  + nike_running[i];
                String shoeName = name + " "  + nike_running[i];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }
            for (int i = 7; i < 14; i++)
            {
                String name = "Nike";
                String shoeLocation = name + "/" + nike_lifestyle[i - 7];
                String shoeName = name + " " + nike_lifestyle[i - 7];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 2, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }
            for (int i = 14; i < 21; i++)
            {
                String name = "Nike";
                String shoeLocation = name + "/" + nike_basketball[i - 14];
                String shoeName = name + " " + nike_basketball[i - 14];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 3, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }

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
            {
                String name = "Adidas";
                String shoeLocation = name + "/" + adidas_running[i];
                String shoeName = name + " " + adidas_running[i];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 1, Cash = 100, Description = "", ImageUrl = "../shoes/running/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }
            for (int i = 7; i < 14; i++)
            {
                String name = "Adidas";
                String shoeLocation = name + "/" + adidas_lifestyle[i - 7];
                String shoeName = name + " " + adidas_lifestyle[i - 7];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 2, Cash = 100, Description = "", ImageUrl = "../shoes/lifestyle/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }
            for (int i = 14; i < 21; i++)
            {
                String name = "Adidas";
                String shoeLocation = name + "/" + adidas_basketball[i - 14];
                String shoeName = name + " " + adidas_basketball[i - 14];
                items.Add(new Item() { Id = i.ToString(), CaregoryId = 3, Cash = 100, Description = "", ImageUrl = "../shoes/basketball/" + shoeLocation + ".png", Name = shoeName, ReleaseDate = 2021 });
            }

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