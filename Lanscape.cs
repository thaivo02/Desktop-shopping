using Guna.UI2.WinForms;
using Sneakerz.Entity;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Model;
using Sneakerz.Repository.Item;
using Sneakerz.Services.Cart;
using Sneakerz.Services.Item;

namespace Sneakerz
{
    public partial class Lanscape : Form
    {
        public readonly IItemServices _itemServices;
        public readonly ICartServices _cartServices;
        private readonly IItemRepository _itemRepository;
        private readonly List<string> itemNames = new List<string>();
        private readonly List<Item> items = new List<Item>();
        public static CartDto cartDto = new CartDto();
        public static int currentCartId = 0;
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

        public Lanscape(IItemServices itemServices, ICartServices cartServices, IItemRepository itemRepository)
        {
            _itemServices = itemServices;
            _cartServices = cartServices;
            _itemRepository = itemRepository;
            currentCartId = _cartServices.GetCartMaxId() + 1;
            items = _itemServices.GetListItem(new ItemQuery());
            InitializeComponent();
            Func<Item, string> querySpace = item => item.Name.Substring(item.Name.IndexOf(" ") + 1);
            itemNames = _itemRepository.GetAll().Select(querySpace).ToList();
            listBox1.Items.Clear();
            listBox1.Visible = false;
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

            txt1.Text = items[0].Cash.ToString() + "$";
            txt2.Text = items[1].Cash.ToString() + "$";
            txt3.Text = items[2].Cash.ToString() + "$";
            txt4.Text = items[3].Cash.ToString() + "$";
            txt5.Text = items[4].Cash.ToString() + "$";
            txt6.Text = items[5].Cash.ToString() + "$";
            txt7.Text = items[6].Cash.ToString() + "$";
            txt8.Text = items[7].Cash.ToString() + "$";
            txt9.Text = items[14].Cash.ToString() + "$";
            txt10.Text = items[15].Cash.ToString() + "$";
            txt11.Text = items[16].Cash.ToString() + "$";
            txt12.Text = items[17].Cash.ToString() + "$";
            txt13.Text = items[18].Cash.ToString() + "$";
            txt14.Text = items[19].Cash.ToString() + "$";
            txt15.Text = items[20].Cash.ToString() + "$";
            txt16.Text = items[21].Cash.ToString() + "$";
            txt17.Text = items[28].Cash.ToString() + "$";
            txt18.Text = items[29].Cash.ToString() + "$";
            txt19.Text = items[30].Cash.ToString() + "$";
            txt20.Text = items[31].Cash.ToString() + "$";
            txt21.Text = items[32].Cash.ToString() + "$";

            txtName1.Text = items[0].Name.Remove(0, items[0].Name.IndexOf(" "));
            txtName2.Text = items[1].Name.Remove(0, items[1].Name.IndexOf(" "));
            txtName3.Text = items[2].Name.Remove(0, items[2].Name.IndexOf(" "));
            txtName4.Text = items[3].Name.Remove(0, items[3].Name.IndexOf(" "));
            txtName5.Text = items[4].Name.Remove(0, items[4].Name.IndexOf(" "));
            txtName6.Text = items[5].Name.Remove(0, items[5].Name.IndexOf(" "));
            txtName7.Text = items[6].Name.Remove(0, items[6].Name.IndexOf(" "));
            txtName8.Text = items[7].Name.Remove(0, items[7].Name.IndexOf(" "));
            txtName9.Text = items[14].Name.Remove(0, items[14].Name.IndexOf(" "));
            txtName10.Text = items[15].Name.Remove(0, items[15].Name.IndexOf(" "));
            txtName11.Text = items[16].Name.Remove(0, items[16].Name.IndexOf(" "));
            txtName12.Text = items[17].Name.Remove(0, items[17].Name.IndexOf(" "));
            txtName13.Text = items[18].Name.Remove(0, items[18].Name.IndexOf(" "));
            txtName14.Text = items[19].Name.Remove(0, items[19].Name.IndexOf(" "));
            txtName15.Text = items[20].Name.Remove(0, items[20].Name.IndexOf(" "));
            txtName16.Text = items[21].Name.Remove(0, items[21].Name.IndexOf(" "));
            txtName17.Text = items[28].Name.Remove(0, items[28].Name.IndexOf(" "));
            txtName18.Text = items[29].Name.Remove(0, items[29].Name.IndexOf(" "));
            txtName19.Text = items[30].Name.Remove(0, items[30].Name.IndexOf(" "));
            txtName20.Text = items[31].Name.Remove(0, items[31].Name.IndexOf(" "));
            txtName21.Text = items[32].Name.Remove(0, items[32].Name.IndexOf(" "));

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
            var item = items.FirstOrDefault(i => i.ImageUrl == pressed.ImageLocation.ToString());
            // Info frm = new Info(pressed, item) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Info frm = Program._host.Services.GetRequiredService<Info>();
            frm.initComponent(pressed, item);
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
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

            txt1.Text = items[0].Cash.ToString() + "$";
            txt2.Text = items[1].Cash.ToString() + "$";
            txt3.Text = items[2].Cash.ToString() + "$";
            txt4.Text = items[3].Cash.ToString() + "$";
            txt5.Text = items[4].Cash.ToString() + "$";
            txt6.Text = items[5].Cash.ToString() + "$";
            txt7.Text = items[6].Cash.ToString() + "$";
            txt8.Text = items[7].Cash.ToString() + "$";
            txt9.Text = items[8].Cash.ToString() + "$";
            txt10.Text = items[9].Cash.ToString() + "$";
            txt11.Text = items[10].Cash.ToString() + "$";
            txt12.Text = items[11].Cash.ToString() + "$";
            txt13.Text = items[12].Cash.ToString() + "$";
            txt14.Text = items[13].Cash.ToString() + "$";
            txt15.Text = items[14].Cash.ToString() + "$";
            txt16.Text = items[15].Cash.ToString() + "$";
            txt17.Text = items[16].Cash.ToString() + "$";
            txt18.Text = items[17].Cash.ToString() + "$";
            txt19.Text = items[18].Cash.ToString() + "$";
            txt20.Text = items[19].Cash.ToString() + "$";
            txt21.Text = items[20].Cash.ToString() + "$";

            txtName1.Text = items[0].Name.Remove(0, items[0].Name.IndexOf(" "));
            txtName2.Text = items[1].Name.Remove(0, items[1].Name.IndexOf(" "));
            txtName3.Text = items[2].Name.Remove(0, items[2].Name.IndexOf(" "));
            txtName4.Text = items[3].Name.Remove(0, items[3].Name.IndexOf(" "));
            txtName5.Text = items[4].Name.Remove(0, items[4].Name.IndexOf(" "));
            txtName6.Text = items[5].Name.Remove(0, items[5].Name.IndexOf(" "));
            txtName7.Text = items[6].Name.Remove(0, items[6].Name.IndexOf(" "));
            txtName8.Text = items[7].Name.Remove(0, items[7].Name.IndexOf(" "));
            txtName9.Text = items[8].Name.Remove(0, items[8].Name.IndexOf(" "));
            txtName10.Text = items[9].Name.Remove(0, items[9].Name.IndexOf(" "));
            txtName11.Text = items[10].Name.Remove(0, items[10].Name.IndexOf(" "));
            txtName12.Text = items[11].Name.Remove(0, items[11].Name.IndexOf(" "));
            txtName13.Text = items[12].Name.Remove(0, items[12].Name.IndexOf(" "));
            txtName14.Text = items[13].Name.Remove(0, items[13].Name.IndexOf(" "));
            txtName15.Text = items[14].Name.Remove(0, items[14].Name.IndexOf(" "));
            txtName16.Text = items[15].Name.Remove(0, items[15].Name.IndexOf(" "));
            txtName17.Text = items[16].Name.Remove(0, items[16].Name.IndexOf(" "));
            txtName18.Text = items[17].Name.Remove(0, items[17].Name.IndexOf(" "));
            txtName19.Text = items[18].Name.Remove(0, items[18].Name.IndexOf(" "));
            txtName20.Text = items[19].Name.Remove(0, items[19].Name.IndexOf(" "));
            txtName21.Text = items[20].Name.Remove(0, items[20].Name.IndexOf(" "));
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

            txt1.Text = items[0].Cash.ToString() + "$";
            txt2.Text = items[1].Cash.ToString() + "$";
            txt3.Text = items[2].Cash.ToString() + "$";
            txt4.Text = items[3].Cash.ToString() + "$";
            txt5.Text = items[4].Cash.ToString() + "$";
            txt6.Text = items[5].Cash.ToString() + "$";
            txt7.Text = items[6].Cash.ToString() + "$";
            txt8.Text = items[7].Cash.ToString() + "$";
            txt9.Text = items[8].Cash.ToString() + "$";
            txt10.Text = items[9].Cash.ToString() + "$";
            txt11.Text = items[10].Cash.ToString() + "$";
            txt12.Text = items[11].Cash.ToString() + "$";
            txt13.Text = items[12].Cash.ToString() + "$";
            txt14.Text = items[13].Cash.ToString() + "$";
            txt15.Text = items[14].Cash.ToString() + "$";
            txt16.Text = items[15].Cash.ToString() + "$";
            txt17.Text = items[16].Cash.ToString() + "$";
            txt18.Text = items[17].Cash.ToString() + "$";
            txt19.Text = items[18].Cash.ToString() + "$";
            txt20.Text = items[19].Cash.ToString() + "$";
            txt21.Text = items[20].Cash.ToString() + "$";

            txtName1.Text = items[0].Name.Remove(0, items[0].Name.IndexOf(" "));
            txtName2.Text = items[1].Name.Remove(0, items[1].Name.IndexOf(" "));
            txtName3.Text = items[2].Name.Remove(0, items[2].Name.IndexOf(" "));
            txtName4.Text = items[3].Name.Remove(0, items[3].Name.IndexOf(" "));
            txtName5.Text = items[4].Name.Remove(0, items[4].Name.IndexOf(" "));
            txtName6.Text = items[5].Name.Remove(0, items[5].Name.IndexOf(" "));
            txtName7.Text = items[6].Name.Remove(0, items[6].Name.IndexOf(" "));
            txtName8.Text = items[7].Name.Remove(0, items[7].Name.IndexOf(" "));
            txtName9.Text = items[8].Name.Remove(0, items[8].Name.IndexOf(" "));
            txtName10.Text = items[9].Name.Remove(0, items[9].Name.IndexOf(" "));
            txtName11.Text = items[10].Name.Remove(0, items[10].Name.IndexOf(" "));
            txtName12.Text = items[11].Name.Remove(0, items[11].Name.IndexOf(" "));
            txtName13.Text = items[12].Name.Remove(0, items[12].Name.IndexOf(" "));
            txtName14.Text = items[13].Name.Remove(0, items[13].Name.IndexOf(" "));
            txtName15.Text = items[14].Name.Remove(0, items[14].Name.IndexOf(" "));
            txtName16.Text = items[15].Name.Remove(0, items[15].Name.IndexOf(" "));
            txtName17.Text = items[16].Name.Remove(0, items[16].Name.IndexOf(" "));
            txtName18.Text = items[17].Name.Remove(0, items[17].Name.IndexOf(" "));
            txtName19.Text = items[18].Name.Remove(0, items[18].Name.IndexOf(" "));
            txtName20.Text = items[19].Name.Remove(0, items[19].Name.IndexOf(" "));
            txtName21.Text = items[20].Name.Remove(0, items[20].Name.IndexOf(" "));
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            // CartForm frm = new CartForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            CartForm frm = Program._host.Services.GetRequiredService<CartForm>();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }


        private void txtSearch_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Func<Item, bool> querySpace = item => item.Name.Substring(item.Name.IndexOf(" ") + 1).ToLower() == txtSearch.Text.ToLower();
                var item = _itemRepository.GetAll().FirstOrDefault(querySpace);
                if (item == null)
                {
                    MessageBox.Show("San pham khong hop le");
                }
                else
                {
                    Info frm = Program._host.Services.GetRequiredService<Info>();
                    frm.Dock = DockStyle.Fill;
                    frm.TopLevel = false;
                    frm.TopMost = true;
                    frm.initComponent(item);
                    this.panelMain.Controls.Add(frm);
                    frm.BringToFront();
                    frm.Closed += (s, args) => this.Close();
                    frm.Show();
                }
            }
            e.Handled = true;
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)==false)
            {
                listBox1.Visible = true;
                listBox1.Items.Clear();
                foreach (string str in itemNames)
                {
                    if (str.ToLower().StartsWith(txtSearch.Text.ToLower())) 
                    {
                        listBox1.Items.Add(str);
                    }
                }
            } else
            {
                listBox1.Visible = false;
                listBox1.Items.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = listBox1.SelectedItem.ToString();
            Func<Item, bool> querySpace = item => item.Name.Substring(item.Name.IndexOf(" ") + 1).ToLower() == text.ToLower();
            var item = _itemRepository.GetAll().FirstOrDefault(querySpace);
            Info frm = Program._host.Services.GetRequiredService<Info>();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.initComponent(item);
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}