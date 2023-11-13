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
    public partial class viewitemname : Form
    {
        public CustomerBL cust;
        public viewitemname(CustomerBL cust)
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

        //__________VIEW ITEM NAME LOAD_____________________
        private void viewitemname_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_name();
            viewitemnameGRD.DataSource = ITEMDL.ITEM_LISTS;
        }

        //__________CLOSE BUTTON_____________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewitemnameGRD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
