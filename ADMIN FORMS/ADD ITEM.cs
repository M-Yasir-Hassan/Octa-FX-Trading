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
    public partial class ADD_ITEM : Form
    {
        public ADD_ITEM()
        {
            InitializeComponent();  
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            ADMIN adminform = new ADMIN();
            adminform.Show();
            this.Hide();
        }

        //__________ADD BUTTON_____________________
        private void btnadd_Click(object sender, EventArgs e)
        {
            //________VALIDATION___________________
            if (int.Parse(txtaddquantity.Text) < 0)
            {
                MessageBox.Show("Enter Quantity More than 0");
            }
            else if (int.Parse(txtadddiscount.Text) < 0)
            {
                MessageBox.Show("Enter Discount More than 0");
            }
            else
            {
                ITEMBL i = new ITEMBL(txtadditem.Text, float.Parse(txtaddprice.Text), int.Parse(txtaddquantity.Text), int.Parse(txtadddiscount.Text));
                ITEMDL.add_item_list(i);
                MessageBox.Show("ITEM ADDED");
                ITEMDL.storeitem();
                this.Hide();
                ADMIN adminform = new ADMIN();
                adminform.Show();
            }
        }   
    }
}
