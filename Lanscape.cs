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
            items = _itemServices.GetListItem(new ItemQuery());
            InitializeComponent();
            this.Home();
        }

        private void Home()
        {
            pic1.Image = Image.FromFile(pic1.ImageLocation = items[0].ImageUrl);
            pic2.Image = Image.FromFile(pic2.ImageLocation = items[1].ImageUrl);
            pic3.Image = Image.FromFile(pic3.ImageLocation = items[2].ImageUrl);
            pic4.Image = Image.FromFile(pic4.ImageLocation = items[3].ImageUrl);
            pic5.Image = Image.FromFile(pic5.ImageLocation = items[4].ImageUrl);
            pic6.Image = Image.FromFile(pic6.ImageLocation = items[5].ImageUrl);
            pic7.Image = Image.FromFile(pic7.ImageLocation = items[6].ImageUrl);
            pic8.Image = Image.FromFile(pic8.ImageLocation = items[7].ImageUrl);
            pic9.Image = Image.FromFile(pic9.ImageLocation = items[14].ImageUrl);
            pic10.Image = Image.FromFile(pic10.ImageLocation = items[15].ImageUrl);
            pic11.Image = Image.FromFile(pic11.ImageLocation = items[16].ImageUrl);
            pic12.Image = Image.FromFile(pic12.ImageLocation = items[17].ImageUrl);
            pic13.Image = Image.FromFile(pic13.ImageLocation = items[18].ImageUrl);
            pic14.Image = Image.FromFile(pic14.ImageLocation = items[19].ImageUrl);
            pic15.Image = Image.FromFile(pic15.ImageLocation = items[20].ImageUrl);
            pic16.Image = Image.FromFile(pic16.ImageLocation = items[21].ImageUrl);
            pic17.Image = Image.FromFile(pic17.ImageLocation = items[28].ImageUrl);
            pic18.Image = Image.FromFile(pic18.ImageLocation = items[29].ImageUrl);
            pic19.Image = Image.FromFile(pic19.ImageLocation = items[30].ImageUrl);
            pic20.Image = Image.FromFile(pic20.ImageLocation = items[31].ImageUrl);
            pic21.Image = Image.FromFile(pic21.ImageLocation = items[32].ImageUrl);

            //items.ForEach(items =>
            //{
            //    _itemServices.AddItem(items);
            //});
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            Guna2PictureBox pressed = (Guna2PictureBox)sender;
            var picName = pressed.ImageLocation.ToString().Split("/");
            //String location = pressed.ImageLocation;
            Info frm = new Info(pressed) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            pic1.Image = Image.FromFile(pic1.ImageLocation = items[0].ImageUrl);
            pic2.Image = Image.FromFile(pic2.ImageLocation = items[1].ImageUrl);
            pic3.Image = Image.FromFile(pic3.ImageLocation = items[2].ImageUrl);
            pic4.Image = Image.FromFile(pic4.ImageLocation = items[3].ImageUrl);
            pic5.Image = Image.FromFile(pic5.ImageLocation = items[4].ImageUrl);
            pic6.Image = Image.FromFile(pic6.ImageLocation = items[5].ImageUrl);
            pic7.Image = Image.FromFile(pic7.ImageLocation = items[6].ImageUrl);
            pic8.Image = Image.FromFile(pic8.ImageLocation = items[7].ImageUrl);
            pic9.Image = Image.FromFile(pic9.ImageLocation = items[8].ImageUrl);
            pic10.Image = Image.FromFile(pic10.ImageLocation = items[9].ImageUrl);
            pic11.Image = Image.FromFile(pic11.ImageLocation = items[10].ImageUrl);
            pic12.Image = Image.FromFile(pic12.ImageLocation = items[11].ImageUrl);
            pic13.Image = Image.FromFile(pic13.ImageLocation = items[12].ImageUrl);
            pic14.Image = Image.FromFile(pic14.ImageLocation = items[13].ImageUrl);
            pic15.Image = Image.FromFile(pic15.ImageLocation = items[14].ImageUrl);
            pic16.Image = Image.FromFile(pic16.ImageLocation = items[15].ImageUrl);
            pic17.Image = Image.FromFile(pic17.ImageLocation = items[16].ImageUrl);
            pic18.Image = Image.FromFile(pic18.ImageLocation = items[17].ImageUrl);
            pic19.Image = Image.FromFile(pic19.ImageLocation = items[18].ImageUrl);
            pic20.Image = Image.FromFile(pic20.ImageLocation = items[19].ImageUrl);
            pic21.Image = Image.FromFile(pic21.ImageLocation = items[20].ImageUrl);
        }

        private void btnAdidas_Click(object sender, EventArgs e)
        {
            pic1.Image = Image.FromFile(pic1.ImageLocation = items[0].ImageUrl);
            pic2.Image = Image.FromFile(pic2.ImageLocation = items[1].ImageUrl);
            pic3.Image = Image.FromFile(pic3.ImageLocation = items[2].ImageUrl);
            pic4.Image = Image.FromFile(pic4.ImageLocation = items[3].ImageUrl);
            pic5.Image = Image.FromFile(pic5.ImageLocation = items[4].ImageUrl);
            pic6.Image = Image.FromFile(pic6.ImageLocation = items[5].ImageUrl);
            pic7.Image = Image.FromFile(pic7.ImageLocation = items[6].ImageUrl);
            pic8.Image = Image.FromFile(pic8.ImageLocation = items[7].ImageUrl);
            pic9.Image = Image.FromFile(pic9.ImageLocation = items[8].ImageUrl);
            pic10.Image = Image.FromFile(pic10.ImageLocation = items[9].ImageUrl);
            pic11.Image = Image.FromFile(pic11.ImageLocation = items[10].ImageUrl);
            pic12.Image = Image.FromFile(pic12.ImageLocation = items[11].ImageUrl);
            pic13.Image = Image.FromFile(pic13.ImageLocation = items[12].ImageUrl);
            pic14.Image = Image.FromFile(pic14.ImageLocation = items[13].ImageUrl);
            pic15.Image = Image.FromFile(pic15.ImageLocation = items[14].ImageUrl);
            pic16.Image = Image.FromFile(pic16.ImageLocation = items[15].ImageUrl);
            pic17.Image = Image.FromFile(pic17.ImageLocation = items[16].ImageUrl);
            pic18.Image = Image.FromFile(pic18.ImageLocation = items[17].ImageUrl);
            pic19.Image = Image.FromFile(pic19.ImageLocation = items[18].ImageUrl);
            pic20.Image = Image.FromFile(pic20.ImageLocation = items[19].ImageUrl);
            pic21.Image = Image.FromFile(pic21.ImageLocation = items[20].ImageUrl);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm frm = new CartForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}