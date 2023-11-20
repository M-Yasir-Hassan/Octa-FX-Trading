using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSSDG.DL;
using OSSDG.BL;

namespace OSSDG
{
    public partial class order : Form
    {
        private string username;
        private string password;
        public StockBL manager;
        public order(StockBL manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        //_________CLOSE BUTTON___________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //_________BACK BUTTON________________
        private void btnback_Click(object sender, EventArgs e)
        {
            StockManager stock = new StockManager(manager);
            stock.Show();
            this.Hide();
        }

        //____________ORDER ITEM________________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            string searchstring = txtadditem.Text;
            ITEMBL item = ITEMDL.SearchanItem(searchstring);
            if (item != null)
            {
                int quant = int.Parse(textaddquantity.Text);
                if (quant >= item.Quantity)
                {
                    manager.ORDERItem(item, quant);
                    ITEMDL.increaseQuantity(quant, item);
                    MessageBox.Show("Item ORDER sucessfully...");
                    ITEMDL.storeitem();
                }
            }
        }
    }
}
