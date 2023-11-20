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
    public partial class cancelorder : Form
    {
        public StockBL manager;
        public cancelorder(StockBL manager)
        {
            InitializeComponent();
            deletegrid.DataSource = ITEMDL.ITEM_LISTS;
            this.manager = manager;
        }

        //___________DATA BIND______________
        public void dataBind()
        {
            deletegrid.DataSource = null;
            deletegrid.DataSource = ITEMDL.ITEM_LISTS;
            deletegrid.Refresh();
        }

        //___________BACK BUTTON___________
        private void btnback_Click(object sender, EventArgs e)
        {
            StockManager stock = new StockManager(manager);
            stock.Show();
            this.Hide();
        }

        //__________CANCEL ORDER GRID_____________
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ITEMBL item = (ITEMBL)deletegrid.CurrentRow.DataBoundItem;
            if (deletegrid.Columns["DELETE"].Index == e.ColumnIndex)
            {
                ITEMDL.deleteITEM(item);
                ITEMDL.storeitem();
                dataBind();
            }
        }
    }
}
