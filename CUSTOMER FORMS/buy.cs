using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSSDG.BL;
using OSSDG.DL;

namespace OSSDG
{
public partial class buy : Form
    {
        public string password;
        public string username;
        public string roles;
        public CustomerBL cust;

        public buy(CustomerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        //______________EXIT BUTTON____________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //______________Back Button______________
        private void btnback_Click(object sender, EventArgs e)
        {
            CUSTOMER cUSTOMER = new CUSTOMER(cust);
            cUSTOMER.Show();
            this.Hide();
        }

        //__________BUY ITEM_____________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            string searchstring = txtadditem.Text; 
            ITEMBL item = ITEMDL.SearchanItem(searchstring);
            if (item != null)
            {
                MessageBox.Show(item.Item + "\t\t" + item.Price + "\t\t" + item.Discount + "%" + "\t\t" + item.Quantity);
                int quant = int.Parse(textaddquantity.Text);
                if (quant <= item.Quantity)
                {
                    cust.BuyItem(item, quant);
                    ITEMDL.reduceQuantity(quant, item);
                    MessageBox.Show("Item BUYED sucessfully...");
                    CustomerDL.storeCustomer();
                }
            }
        }
    }
}
