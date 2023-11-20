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
    public partial class LoginForm : Form
    {
        bool Valid;
        public LoginForm()
        {
            InitializeComponent();
            //______LOAD USER AND ITEM__________
           
        }

        //___________CLOSE BUTTON______________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //____________CLEAR FIELDS______________
        private void lblclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtroles.Clear();
        }

        //____________LOGIN BUTTON_______________
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.ToString();
            string password = txtpassword.Text.ToString();
            string roles = txtroles.Text.ToString();

            USERBL user = USERDL.isUserValid(username, password, roles);
            if (user == null)
            {
                if (Valid == false)
                {
                    MessageBox.Show("Invalid");
                }
            }
            else
            {
                if (roles == "Admin")
                {
                    MessageBox.Show("LOGIN SUCCESSFULLY AS ADMIN");
                    this.Hide();
                    ADMIN adminform = new ADMIN();
                    adminform.Show();
                }
                else if (roles == "Customer")
                {
                    MessageBox.Show("LOGIN SUCCESSFULLY AS CUSTOMER");
                    this.Hide();
                   
                    CustomerBL cust = CustomerDL.findCust(username, password, roles);
                    if (cust == null)
                    {
                        cust = new CustomerBL(new USERBL(username, password, roles), new List<ITEMBL>());
                        CustomerDL.add_list(cust);
                    }
                    CUSTOMER customerform = new CUSTOMER(cust);
                    customerform.Show();
                }
                else if (roles == "Stock")
                {
                    MessageBox.Show("LOGIN SUCCESSFULLY AS STOCK MANAGER");
                    this.Hide();
                    StockBL manager = StockDL.find_stock(username, password);
                    if (manager == null)
                    {
                        manager = new StockBL(new USERBL(username, password, "Stock"), new List<ITEMBL>());
                        StockDL.add_stock(manager);
                    }
                    StockManager stock = new StockManager(manager);
                    stock.Show();
                }
            }
        }
   
        

        //__________TEXT USERBOX COLOUR CHANGE________________
        private void txtusername_Click_1(object sender, EventArgs e)
        {
            txtusername.BackColor = Color.White;
            pnluserbox.BackColor = Color.White;
            pnlpassbox.BackColor = SystemColors.Control;
            txtpassword.BackColor = SystemColors.Control;
        }

        //__________TEXT Pass_BOX COLOUR CHANGE________________
        private void txtpassword_Click(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.White;
            pnlpassbox.BackColor = Color.White;
            txtusername.BackColor = SystemColors.Control;
            pnluserbox.BackColor = SystemColors.Control;
        }

        //__________TEXT ROLEBOX COLOUR CHANGE________________
        private void txtroles_Click(object sender, EventArgs e)
        {
            txtroles.BackColor = SystemColors.Control;
            pnlrolebox.BackColor = SystemColors.Control;  
        }

        //__________MOUSE DOWN FOR INVISIBLE PASSWORD_______________
        private void picpasslogo_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        //__________BACK BUTTON______________________
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            startform start = new startform();
            start.Show();  
        }

        private void lblaccount_Click(object sender, EventArgs e)
        {

        }
    }
}
