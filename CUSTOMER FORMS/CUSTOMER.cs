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
    public partial class CUSTOMER : Form
    {
        public CustomerBL cust;
        public CUSTOMER(CustomerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________SIGN OUT BUTTON_____________________
        private void btnsignnout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //__________VIEW ITEM WITH NAME SORTING____________________
        private void btnviewcusname_Click(object sender, EventArgs e)
        {
            viewitemname view = new viewitemname(cust);
            view.Show();
            this.Hide();
        }

        //_________VIEW ITEM WITH PRICE SORTING_____________________
        private void button1_Click(object sender, EventArgs e)
        {
            viewitemprice view = new viewitemprice(cust);
            view.Show();
            this.Hide();
        }

        //__________BUY BUTTON_____________________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            BuyItem buy = new BuyItem(cust);
            buy.Show();
            this.Hide();
        }
        
        //___________PRINT BILL  BUTTON__________
        private void btnbill_Click(object sender, EventArgs e)
        {
            PrintBill printBill = new PrintBill(cust);  
            printBill.Show();
            this.Hide();
        }
    }
}
