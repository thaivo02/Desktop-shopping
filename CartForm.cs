using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Repository.Item;
using System.Reflection;
using Console = System.Console;

namespace Sneakerz
{
    public partial class CartForm : Form
    {
        private readonly IItemRepository _itemRepository;
        public CartForm(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
            InitializeComponent();
            var cartItems = Lanscape.cartDto;
            if (cartItems.Cart is null)
            {
                
            }
            else if (cartItems.CartDetails.Count == 1)
            {
                var cart = cartItems.CartDetails[0];
                var item = _itemRepository.GetItemDetail(cart.ItemId);
                pic1.Image = Image.FromFile(item.ImageUrl);
                itemInfo1.Text = item.Name;
                size1.Text = cart.Size.ToString();
                sizeInfo1.Text = cart.Size.ToString();
                txtQuantity1.Text = cart.Amount.ToString();
                txtPrice1.Text = (cart.Amount * item.Cash).ToString();
            }
            
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
                txtQuantity1.Text = quantity.ToString();
            } else if (btn.Name[btn.Name.Length - 1] == '2')
            {
                int quantity = Int32.Parse(txtQuantity2.Text);
                if (quantity > 0) quantity--;
                txtQuantity2.Text = quantity.ToString();
            } else if (btn.Name[btn.Name.Length - 1] == '3')
            {
                int quantity = Int32.Parse(txtQuantity3.Text);
                if (quantity > 0) quantity--;
                txtQuantity3.Text = quantity.ToString();
            } else if (btn.Name[btn.Name.Length - 1] == '4')
            {
                int quantity = Int32.Parse(txtQuantity4.Text);
                if (quantity > 0) quantity--;
                txtQuantity4.Text = quantity.ToString();
            } else if (btn.Name[btn.Name.Length - 1] == '5')
            {
                int quantity = Int32.Parse(txtQuantity5.Text);
                if (quantity > 0) quantity--;
                txtQuantity5.Text = quantity.ToString();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            if (btn.Name[btn.Name.Length - 1] == '1')
            {
                int quantity = Int32.Parse(txtQuantity1.Text);
                quantity++;
                txtQuantity1.Text = quantity.ToString();
            }
            else if (btn.Name[btn.Name.Length - 1] == '2')
            {
                int quantity = Int32.Parse(txtQuantity2.Text);
                quantity++;
                txtQuantity2.Text = quantity.ToString();
            }
            else if (btn.Name[btn.Name.Length - 1] == '3')
            {
                int quantity = Int32.Parse(txtQuantity3.Text);
                quantity++;
                txtQuantity3.Text = quantity.ToString();
            }
            else if (btn.Name[btn.Name.Length - 1] == '4')
            {
                int quantity = Int32.Parse(txtQuantity4.Text);
                quantity++;
                txtQuantity4.Text = quantity.ToString();
            }
            else if (btn.Name[btn.Name.Length - 1] == '5')
            {
                int quantity = Int32.Parse(txtQuantity5.Text);
                quantity++;
                txtQuantity5.Text = quantity.ToString();
            }
        }
    }
}
