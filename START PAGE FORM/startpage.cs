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
    public partial class startform : Form
    {
        public startform()
        {
            InitializeComponent();
        }

       //_____________EXIT BUTTON________________________
        private void bntexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //_____________LOGIN BUTTON______________________
        private void bntstrtlogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();        
        }
    }
}
