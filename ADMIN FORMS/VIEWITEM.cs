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

namespace OSSDG
{
    public partial class VIEWITEM : Form
    {
        public VIEWITEM()
        {
            InitializeComponent();
        }

        //__________VIEW ITEM LOAD_____________________
        private void VIEWITEM_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_name();
            viewitemgrd.DataSource = ITEMDL.ITEM_LISTS;
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click_1(object sender, EventArgs e)
        {
            ADMIN adminform = new ADMIN();
            adminform.Show();
            this.Hide();
        }

        private void viewitemgrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
