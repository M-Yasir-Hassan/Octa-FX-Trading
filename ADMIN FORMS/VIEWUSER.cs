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
    public partial class VIEWUSER : Form
    {
        public VIEWUSER()
        {
            InitializeComponent();
        }

        //__________VIEW USER LOAD_____________________
        private void VIEWUSER_Load(object sender, EventArgs e)
        {
            viewusergrd.DataSource = USERDL.USERS_LISTS;
        }

        //__________BACK BUTTON_____________________
        private void btnback_Click(object sender, EventArgs e)
        {
            ADMIN adminform = new ADMIN();
            adminform.Show();
            this.Hide();
        }

        //__________CLOSE BUTTON_____________________
        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
