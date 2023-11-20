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

namespace OSSDG
{
    public partial class orderform : Form
    {
        public StockBL manager;
        public orderform(StockBL manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        //________BACK BUTTON__________
        private void btnback_Click(object sender, EventArgs e)
        {
            StockManager stock = new StockManager(manager);
            stock.Show();
            this.Hide();
        }

        //________VIEW PLACE ORDER_______________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            order o = new order(manager);
            o.Show();
            this.Hide();
        }

        //________CLOSE BUTTON_________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
