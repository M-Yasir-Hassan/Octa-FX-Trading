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
    public partial class EditItem : Form
    {
        private ITEMBL previousitem;
        public EditItem(ITEMBL previousitem)
        {
            InitializeComponent();
            this.previousitem = previousitem;
        }
        
        //________EDIT ITEM BUTTON____________
        private void btnedit_Click(object sender, EventArgs e)
        {
            //_________VALIDATION_______________
            if (int.Parse(txtaddquantity.Text) < 0)
            {
                MessageBox.Show("Enter the Quantity more than 0");
            }
            else if (int.Parse(txtadddiscount.Text) < 0)
            {
                MessageBox.Show("Enter the Discount more than 0");
            }
            else
            {
                ITEMBL edit = new ITEMBL(txtadditem.Text, float.Parse(txtaddprice.Text), int.Parse(txtaddquantity.Text), int.Parse(txtadddiscount.Text));
                ITEMDL.EditITEM_List(previousitem, edit);
                this.Close();
            }
        }

        //__________CLOSE BUTTON_____________________
        private void bTNCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            EditItemgrd edit = new EditItemgrd();
            edit.Show();
            this.Hide();
        }

        //________PREVIOUS ITEM LOAD_________________
        private void EditItem_Load(object sender, EventArgs e)
        {
            txtadditem.Text = previousitem.Item;
        }
    }
}
