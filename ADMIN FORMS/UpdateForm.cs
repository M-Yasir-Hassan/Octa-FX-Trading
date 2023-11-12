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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        //__________DATA BIND_____________________
        public void dataBind()
        {
            updateGRD.DataSource = null;
            updateGRD.DataSource = USERDL.USERS_LISTS;
            updateGRD.Refresh();
        }

        //__________UPDATE GRID CELL_____________________
        private void updateGRD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            USERBL user = (USERBL)updateGRD.CurrentRow.DataBoundItem;
         
            if (updateGRD.Columns["UPDATE"].Index == e.ColumnIndex)
            {
                EditForm edit = new EditForm(user);
                edit.ShowDialog();
                MessageBox.Show("UPDATED USER SUCCESSFULLY");
                USERDL.storeUser();
                dataBind();
            }

            else if (updateGRD.Columns["DELETE"].Index == e.ColumnIndex)
            {
                USERDL.deleteuser(user);
                USERDL.storeUser();
                dataBind();
            }
        }

        //__________UPDATE LOAD_____________________
        private void UpdateForm_Load(object sender, EventArgs e)
        {
            ITEMDL.sort_ascending_price();
            updateGRD.DataSource = USERDL.USERS_LISTS;
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
