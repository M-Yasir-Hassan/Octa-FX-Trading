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
    public partial class deleteform : Form
    {
        public deleteform()
        {
            InitializeComponent();
        }

        //__________DATA BIND_____________________
        public void dataBind()
        {
            deletegrd.DataSource = null;
            deletegrd.DataSource = ITEMDL.ITEM_LISTS;
            deletegrd.Refresh();
        }

        //_______DELETE FORM LOAD______________
        private void deleteform_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_price();
            deletegrd.DataSource = ITEMDL.ITEM_LISTS;
        }

        //____________DATA GRID VIEW___________
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ITEMBL item = (ITEMBL)deletegrd.CurrentRow.DataBoundItem;
            if (deletegrd.Columns["DELETE"].Index == e.ColumnIndex)
            {
                ITEMDL.deleteITEM(item);
                ITEMDL.storeitem();
                dataBind();
            }
        }

        //__________BACK BUTTON_____________
        private void btnback_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }
    }
}
