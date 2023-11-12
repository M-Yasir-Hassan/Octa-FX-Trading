using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSSDG
{
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________SIGN OUT BUTTON_____________________
        private void btnout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //__________ADD USER BUTTON_____________________
        private void btnadduser_Click(object sender, EventArgs e)
        {
            ADDUSER adduser = new ADDUSER();
            adduser.Show();
            this.Hide();
        }

        //__________ADD ITEM BUTTON_____________________
        private void btnadditem_Click(object sender, EventArgs e)
        {
            ADD_ITEM additem = new ADD_ITEM();
            additem.Show();
            this.Hide();
        }

        //__________VIEW USER BUTTON_____________________
        private void btnviewuserr_Click(object sender, EventArgs e)
        {
            VIEWUSER view = new VIEWUSER();
            view.Show();
            this.Hide();
        }

        //__________VIEW ITEM BUTTON_____________________
        private void btnviewitem_Click(object sender, EventArgs e)
        {
            VIEWITEM viewitem = new VIEWITEM();
            viewitem.Show();
            this.Hide();
        }

        //_________EDIT ITEM BUTTON_____________
        private void button4_Click(object sender, EventArgs e)
        {
            EditItemgrd Edit = new EditItemgrd();
            Edit.Show();
            this.Hide();
        }

        //______UPDATE USER BUTTON_______________
        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.Show();
            this.Hide();
        }

        //__________DELETE ITEM BUTTON_____________________
        private void btndeleteitem_Click(object sender, EventArgs e)
        {
            deleteform delete = new deleteform();
            delete.Show();
            this.Hide();
        }
    }
}
