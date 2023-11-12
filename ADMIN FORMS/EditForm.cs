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
    public partial class EditForm : Form
    {
        private USERBL previous_user;
        public EditForm(USERBL previous_user)
        {
            InitializeComponent();
            this.previous_user = previous_user;
        }

        //__________CLOSE BUTTON_____________________
        private void bTNCLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            UpdateForm update = new UpdateForm();
            update.Show();
            this.Hide();
        }

        //__________EDIT BUTTON_____________________
        private void btnadd_Click(object sender, EventArgs e)
        {
            USERBL update = new USERBL(txtusername.Text, txtpassword.Text, txtroles.Text);
            USERDL.EditUser_List(previous_user, update);
            this.Close();
        }

        //__________EDIT FORM LOAD PREVIOUS_______________
        private void EditForm_Load(object sender, EventArgs e)
        {
            txtusername.Text = previous_user.UserNames;
            txtpassword.Text = previous_user.PassWords;
            txtroles.Text = previous_user.Roles;
        }
    }
}
