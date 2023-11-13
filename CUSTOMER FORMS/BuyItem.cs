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
    public partial class BuyItem : Form
    {
        public CustomerBL cust;
        public BuyItem(CustomerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            CUSTOMER cUSTOMER = new CUSTOMER(cust);
            cUSTOMER.Show();
            this.Hide();
        }

        //__________VIEW BUTTON_____________________
        private void btnview_Click(object sender, EventArgs e)
        {
            viewitemname view = new viewitemname(cust);
            view.Show();
            this.Hide();
        }

        //__________BUY BUTTON_____________________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            buy b = new buy(cust);
            b.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
