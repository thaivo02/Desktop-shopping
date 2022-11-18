using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Entity;
using Sneakerz.Model;
using Sneakerz.Repository.Item;
using System.Linq;
using System.Reflection;
using Console = System.Console;

namespace Sneakerz
{
    public partial class CartForm : Form
    {
        private readonly IItemRepository _itemRepository;
        private readonly List<string> itemNames = new List<string>();

        public CartForm(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            InitializeComponent();
            txtSearch.Visible = false;
            listBox1.Visible = false;

            var cartItems = Lanscape.cartDto;
            pic1.Visible = false;
            size1.Visible = false;
            txtPrice1.Visible = false;
            itemInfo1.Visible = false;
            sizeInfo1.Visible = false;
            quantity1.Visible = false;
            btnDown1.Visible = false;
            btnUp1.Visible = false;
            txtQuantity1.Visible = false;
            //***************************
            pic2.Visible = false;
            size2.Visible = false;
            txtPrice2.Visible = false;
            itemInfo2.Visible = false;
            sizeInfo2.Visible = false;
            quantity2.Visible = false;
            btnDown2.Visible = false;
            btnUp2.Visible = false;
            txtQuantity2.Visible = false;
            //***************************
            pic3.Visible = false;
            size3.Visible = false;
            txtPrice3.Visible = false;
            itemInfo3.Visible = false;
            sizeInfo3.Visible = false;
            quantity3.Visible = false;
            btnDown3.Visible = false;
            btnUp3.Visible = false;
            txtQuantity3.Visible = false;
            //***************************
            pic4.Visible = false;
            size4.Visible = false;
            txtPrice4.Visible = false;
            itemInfo4.Visible = false;
            sizeInfo4.Visible = false;
            quantity4.Visible = false;
            btnDown4.Visible = false;
            btnUp4.Visible = false;
            txtQuantity4.Visible = false;
            //***************************
            pic5.Visible = false;
            size5.Visible = false;
            txtPrice5.Visible = false;
            itemInfo5.Visible = false;
            sizeInfo5.Visible = false;
            quantity5.Visible = false;
            btnDown5.Visible = false;
            btnUp5.Visible = false;
            txtQuantity5.Visible = false;

            if (cartItems.CartDetails is null) { }
            else if (cartItems.CartDetails.Count >= 1)
            {
                var cart1 = cartItems.CartDetails[0];
                var item1 = _itemRepository.GetItemDetail(cart1.ItemId);
                pic1.Visible = true;
                size1.Visible = true;
                txtPrice1.Visible = true;
                itemInfo1.Visible = true;
                sizeInfo1.Visible = true;
                quantity1.Visible = true;
                btnDown1.Visible = true;
                btnUp1.Visible = true;
                txtQuantity1.Visible = true;

                pic1.Image = Image.FromFile(item1.ImageUrl);
                itemInfo1.Text = item1.Name;
                sizeInfo1.Text = cart1.Size.ToString().Insert(cart1.Size.ToString().Length - 1, ".") + "US";
                txtQuantity1.Text = cart1.Amount.ToString();
                txtPrice1.Text = (cart1.Amount * item1.Cash).ToString() + "$";

                if (cartItems.CartDetails.Count >= 2)
                {
                    var cart2 = cartItems.CartDetails[1];
                    var item2 = _itemRepository.GetItemDetail(cart2.ItemId);
                    pic2.Visible = true;
                    size2.Visible = true;
                    txtPrice2.Visible = true;
                    itemInfo2.Visible = true;
                    sizeInfo2.Visible = true;
                    quantity2.Visible = true;
                    btnDown2.Visible = true;
                    btnUp2.Visible = true;
                    txtQuantity2.Visible = true;

                    pic2.Image = Image.FromFile(item2.ImageUrl);
                    itemInfo2.Text = item2.Name;
                    sizeInfo2.Text = cart2.Size.ToString().Insert(1, ".") + "US";
                    txtQuantity2.Text = cart2.Amount.ToString();
                    txtPrice2.Text = (cart2.Amount * item2.Cash).ToString() + "$";

                    if (cartItems.CartDetails.Count >= 3)
                    {
                        var cart3 = cartItems.CartDetails[2];
                        var item3 = _itemRepository.GetItemDetail(cart3.ItemId);
                        pic3.Visible = true;
                        size3.Visible = true;
                        txtPrice3.Visible = true;
                        itemInfo3.Visible = true;
                        sizeInfo3.Visible = true;
                        quantity3.Visible = true;
                        btnDown3.Visible = true;
                        btnUp3.Visible = true;
                        txtQuantity3.Visible = true;

                        pic3.Image = Image.FromFile(item3.ImageUrl);
                        itemInfo3.Text = item3.Name;
                        sizeInfo3.Text = cart3.Size.ToString().Insert(1, ".") + "US";
                        txtQuantity3.Text = cart3.Amount.ToString();
                        txtPrice3.Text = (cart3.Amount * item3.Cash).ToString() + "$";

                        if (cartItems.CartDetails.Count >= 4)
                        {
                            var cart4 = cartItems.CartDetails[3];
                            var item4 = _itemRepository.GetItemDetail(cart4.ItemId);
                            pic4.Visible = true;
                            size4.Visible = true;
                            txtPrice4.Visible = true;
                            itemInfo4.Visible = true;
                            sizeInfo4.Visible = true;
                            quantity4.Visible = true;
                            btnDown4.Visible = true;
                            btnUp4.Visible = true;
                            txtQuantity4.Visible = true;

                            pic4.Image = Image.FromFile(item4.ImageUrl);
                            itemInfo4.Text = item4.Name;
                            sizeInfo4.Text = cart4.Size.ToString().Insert(1, ".") + "US";
                            txtQuantity4.Text = cart4.Amount.ToString();
                            txtPrice4.Text = (cart4.Amount * item4.Cash).ToString() +"$";

                            if (cartItems.CartDetails.Count == 5)
                            {
                                var cart5 = cartItems.CartDetails[4];
                                var item5 = _itemRepository.GetItemDetail(cart5.ItemId);
                                pic5.Visible = true;
                                size5.Visible = true;
                                txtPrice5.Visible = true;
                                itemInfo5.Visible = true;
                                sizeInfo5.Visible = true;
                                quantity5.Visible = true;
                                btnDown5.Visible = true;
                                btnUp5.Visible = true;
                                txtQuantity5.Visible = true;

                                pic5.Image = Image.FromFile(item5.ImageUrl);
                                itemInfo5.Text = item5.Name;
                                sizeInfo5.Text = cart5.Size.ToString().Insert(1, ".") + "US";
                                txtQuantity5.Text = cart5.Amount.ToString();
                                txtPrice5.Text = (cart5.Amount * item5.Cash).ToString() +"$";
                            }
                        }
                    }
                }

            }
            txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void btnDown_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            if (btn.Name[btn.Name.Length - 1] == '1')
            {
                int quantity = Int32.Parse(txtQuantity1.Text);
                if (quantity > 0) quantity--;
                var cart = Lanscape.cartDto.CartDetails[0];
                cart.Amount = quantity;
                txtQuantity1.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[0].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            } else if (btn.Name[btn.Name.Length - 1] == '2')
            {
                int quantity = Int32.Parse(txtQuantity2.Text);
                if (quantity > 0) quantity--;
                var cart = Lanscape.cartDto.CartDetails[1];
                cart.Amount = quantity;
                txtQuantity2.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[1].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            } else if (btn.Name[btn.Name.Length - 1] == '3')
            {
                int quantity = Int32.Parse(txtQuantity3.Text);
                if (quantity > 0) quantity--;
                var cart = Lanscape.cartDto.CartDetails[2];
                cart.Amount = quantity;
                txtQuantity3.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[2].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            } else if (btn.Name[btn.Name.Length - 1] == '4')
            {
                int quantity = Int32.Parse(txtQuantity4.Text);
                if (quantity > 0) quantity--;
                var cart = Lanscape.cartDto.CartDetails[3];
                cart.Amount = quantity;
                txtQuantity4.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[3].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            } else if (btn.Name[btn.Name.Length - 1] == '5')
            {
                int quantity = Int32.Parse(txtQuantity5.Text);
                if (quantity > 0) quantity--;
                var cart = Lanscape.cartDto.CartDetails[4];
                cart.Amount = quantity;
                txtQuantity5.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[4].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            if (btn.Name[btn.Name.Length - 1] == '1')
            {
                int quantity = Int32.Parse(txtQuantity1.Text);
                quantity++;
                var cart = Lanscape.cartDto.CartDetails[0];
                cart.Amount= quantity;
                txtQuantity1.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[0].ItemId);
                Lanscape.totalPrice += item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }
            else if (btn.Name[btn.Name.Length - 1] == '2')
            {
                int quantity = Int32.Parse(txtQuantity2.Text);
                quantity++;
                var cart = Lanscape.cartDto.CartDetails[1];
                cart.Amount = quantity;
                txtQuantity2.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[1].ItemId);
                Lanscape.totalPrice += item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }
            else if (btn.Name[btn.Name.Length - 1] == '3')
            {
                int quantity = Int32.Parse(txtQuantity3.Text);
                quantity++;
                var cart = Lanscape.cartDto.CartDetails[2];
                cart.Amount = quantity;
                txtQuantity3.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[2].ItemId);
                Lanscape.totalPrice += item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }
            else if (btn.Name[btn.Name.Length - 1] == '4')
            {
                int quantity = Int32.Parse(txtQuantity4.Text);
                quantity++;
                var cart = Lanscape.cartDto.CartDetails[3];
                cart.Amount = quantity;
                txtQuantity4.Text = quantity.ToString();
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[3].ItemId);
                Lanscape.totalPrice += item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }
            else if (btn.Name[btn.Name.Length - 1] == '5')
            {
                int quantity = Int32.Parse(txtQuantity5.Text);
                quantity++;
                var cart = Lanscape.cartDto.CartDetails[4];
                cart.Amount = quantity;
                txtQuantity5.Text = quantity.ToString();
                txtPrice5.Text = (cart.Amount * _itemRepository.GetItemDetail(cart.ItemId).Cash).ToString() + "$";
                var item = _itemRepository.GetItemDetail(Lanscape.cartDto.CartDetails[1].ItemId);
                Lanscape.totalPrice -= item.Cash;
                txtTotal.Text = Lanscape.totalPrice.ToString() + "$";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
            btnSearch.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text) == false)
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
            }
            else
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Report frm = Program._host.Services.GetRequiredService<Report>();
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
