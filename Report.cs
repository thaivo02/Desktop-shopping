using Guna.UI2.WinForms;
using Microsoft.Extensions.DependencyInjection;
using Sneakerz.Repository.Item;
using System.Data;

namespace Sneakerz
{
    public partial class Report : Form
    {
        private readonly IItemRepository _itemRepository;
        public Report(IItemRepository itemRepository)
        {
            InitializeComponent();
            _itemRepository = itemRepository;
            var cartDetails = Lanscape.cartDto.CartDetails;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ItemId");
            dataTable.Columns.Add("Brand");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Ammount");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Total");

            cartDetails.ForEach(ct =>
            {
                var item = _itemRepository.GetItemDetail(ct.ItemId);
                dataTable.Rows.Add(item.Id, item.Brand, item.Name, ct.Amount, item.Cash, ct.Amount * item.Cash);
            });
            dataTable.Rows.Add("", "", "", "", "", Lanscape.totalPrice);

            data.DataSource = dataTable;
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
    }
}