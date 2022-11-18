using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Entity;
using Sneakerz.Model;
using Sneakerz.Repository.Item;
using Sneakerz.Services.Item;

namespace Sneakerz
{
    public partial class Info : Form
    {
        public Guna2PictureBox pressed = new Guna2PictureBox();
        public Item item = new Item();
        private readonly IItemServices _itemServices;
        private readonly IItemRepository _itemRepository;
        private double size = 0;
        public Info(IItemServices itemServices, IItemRepository itemRepository)
        {
            _itemServices = itemServices;
            _itemRepository = itemRepository;
            InitializeComponent();
            txtSearch.Visible = false;

            // String brand = pressed.Name.Substring(0, space);
            // String name = pressed.Name.Substring(space + 1, pressed.Name.Length - space);
        }

        public void initComponent(Guna2PictureBox pressed, Item item)
        {
            String location = pressed.ImageLocation;
            picDefault.Image = Image.FromFile(location);
            String first = location.Insert(location.Length - 4, "(1)");
            String second = location.Insert(location.Length - 4, "(2)");
            int space = item.Name.IndexOf(" ", StringComparison.Ordinal);
            labelBrand.Text= item.Brand.Substring(0, space);
            if (labelBrand.Text == "Adidas") picLogo.Image = Image.FromFile(@"../img/icon-adidas-logo.png");
            else picLogo.Image = Image.FromFile(@"../img/logo.png");
            labelName.Text = item.Name.Substring(space + 1);
            picChange1.Image = Image.FromFile(first);
            picChange2.Image = Image.FromFile(second);
        }

        public void initComponent(Item item)
        {
            String location = item.ImageUrl;
            picDefault.Image = Image.FromFile(location);
            String first = location.Insert(location.Length - 4, "(1)");
            String second = location.Insert(location.Length - 4, "(2)");
            int space = item.Name.IndexOf(" ", StringComparison.Ordinal);
            labelBrand.Text = item.Brand.Substring(0, space);
            if (labelBrand.Text == "Adidas") picLogo.Image = Image.FromFile(@"../img/icon-adidas-logo.png");
            else picLogo.Image = Image.FromFile(@"../img/logo.png");
            labelName.Text = item.Name.Substring(space + 1);
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
            size = Double.Parse(sizeChosen.Text);
        }

        private void btnAdd_to_cart_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                MessageBox.Show("Vui lòng chọn size");
            }
            else
            {
                Func<Item, bool> querySpace = item => item.Name.Substring(item.Name.IndexOf(" ") + 1) == labelName.Text; 
                var item = _itemRepository.GetAll().FirstOrDefault(querySpace);

                var t = true;
                
                if (Lanscape.cartDto.CartDetails is null || Lanscape.cartDto.CartDetails.Count == 0)
                {
                    Lanscape.cartDto.Cart = new Cart()
                    {
                        Id = Lanscape.currentCartId,
                        UserId = 1
                    };
                    Lanscape.cartDto.CartDetails = new List<CartDetail>();
                }
                
                Lanscape.cartDto.CartDetails.ForEach(ct =>
                {
                    if (ct.ItemId == item.Id && ct.Size == size)
                    {
                        ct.Amount++;
                        t = false;
                        MessageBox.Show("Đã cập nhật giỏ hàng");
                    }
                });
        
                if (t)
                {
                    if (Lanscape.cartDto.CartDetails.Count == 5)
                    {
                        MessageBox.Show("Bạn chỉ có thể đặt tối đa 5 món hàng");
                    }
                    else
                    {
                        Lanscape.cartDto.CartDetails.Add(new CartDetail()
                        {
                            CardId = Lanscape.currentCartId,
                            Amount = 1,
                            ItemId = item.Id,
                            Size = size
                        });
                        MessageBox.Show("Đã cập nhật giỏ hàng");

                    }
                }
                
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            btnSearch.Visible = false;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            CartForm frm = Program._host.Services.GetRequiredService<CartForm>();
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.TopMost = true;
            this.panelMain.Controls.Add(frm);
            frm.BringToFront();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }
    }
}
