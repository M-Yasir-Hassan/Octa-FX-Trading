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
    public partial class viewitemprice : Form
    {
        public CustomerBL cust;
        public viewitemprice(CustomerBL cust)
        {
            InitializeComponent();
            this.cust = cust;       
        }

        //__________VIEW ITEM PRICE LOAD SORTING_____________________
        private void viewitemprice_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_price();
            viewitempricegrd.DataSource = ITEMDL.ITEM_LISTS;
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            CUSTOMER cUSTOMER = new CUSTOMER(cust);
            cUSTOMER.Show();
            this.Hide();
        }
    }
}
