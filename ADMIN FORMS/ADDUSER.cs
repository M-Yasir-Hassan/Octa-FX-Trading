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
using OSSDG.BL;

namespace OSSDG
{
    public partial class ADDUSER : Form
    {
        public ADDUSER()
        {
            InitializeComponent();
        }

        //__________CLOSE BUTTON_____________________
        private void bTNCLOSE_Click(object sender, EventArgs e)
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
            string username = txtuseradd.Text.ToString();
            string password = txtaddpass.Text.ToString();
            string roles = txtaddrole.Text.ToString();
            USERBL U = new USERBL(username, password, roles);
            USERBL U1 = USERDL.isUserValid(username,password,roles);
            if (U1 != null)
            {
                //_______VALIDATION FOR USER EXISTENCE________
                if (username == U.UserNames && password == U.PassWords && roles == U.Roles)
                {
                    MessageBox.Show("USER ALRADY EXIST");
                    this.Hide();
                    ADMIN adminform = new ADMIN();
                    adminform.Show();
                }
            }
            else
            {
                USERBL u = new USERBL(txtuseradd.Text, txtaddpass.Text, txtaddrole.Text);
                USERDL.Add_User_List(u);
                MessageBox.Show("USER ADDED");
                USERDL.storeUser();
                this.Hide();
                ADMIN adminform = new ADMIN();
                adminform.Show();
            }
        }
    }
}
