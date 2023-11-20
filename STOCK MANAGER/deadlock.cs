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
    public partial class deadlock : Form
    {
        public StockBL manager;
        public deadlock(StockBL manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        //________CLOSE BUTTON_________________
        private void btnback_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //___________DEAD LOCK___________________
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ITEMBL i in ITEMDL.ITEM_LISTS)
            {
                if (i.Quantity == 0)
                {
                    MessageBox.Show("ItemName\tItemPrice\tQuantity\tDiscounts\n" 
                      +  i.Item + "\t\t" + i.Price + "\t\t" + i.Quantity + "\t\t" + i.Discount);
                }
            }
        }

        //_______BACK BUTTON_____________
        private void button2_Click(object sender, EventArgs e)
        {
            StockManager stock = new StockManager(manager);
            stock.Show();
            this.Hide();
        }
    }
}
