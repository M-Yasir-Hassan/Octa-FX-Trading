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
    public partial class EditItemgrd : Form
    {
        public EditItemgrd()
        {
            InitializeComponent();
        }

        //__________DATA BIND_____________________
        public void dataBind()
        {
            itemGRD.DataSource = null;
            itemGRD.DataSource = ITEMDL.ITEM_LISTS;
            itemGRD.Refresh();
        }

        //__________ITEM GRID LOAD_____________________
        private void EditItemgrd_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_name();
            itemGRD.DataSource = ITEMDL.ITEM_LISTS;
        }

        //__________ITEM GRID CELL_____________________
        private void itemGRD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ITEMBL item = (ITEMBL)itemGRD.CurrentRow.DataBoundItem;

            if (itemGRD.Columns["EDIT"].Index == e.ColumnIndex)
            {
                EditItem edit = new EditItem(item);
                edit.ShowDialog();
                MessageBox.Show("UPDATED ITEM SUCCESSFULLY");
                ITEMDL.storeitem();
                dataBind();
            }
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            ADMIN aDMIN = new ADMIN();
            aDMIN.Show();
            this.Hide();
        }
    }
}
