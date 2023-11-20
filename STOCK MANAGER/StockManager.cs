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

namespace OSSDG
{
    public partial class StockManager : Form
    {
        public StockBL manager;
        public StockManager(StockBL manager)
        {
            InitializeComponent();
            this.manager = manager;
        }

        //___________EXIT BUTTON_______________
        private void btnclose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //________DEAD LOCK BUTTON______________
        private void btnviewcusname_Click(object sender, EventArgs e)
        {
            deadlock deadlock = new deadlock(manager);
            deadlock.Show();
            this.Hide();
        }

        //_____________SIGN OUT BUTTON___________
        private void btnbill_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //__________CANCEL ORDER____________
        private void btnbuy_Click(object sender, EventArgs e)
        {
            cancelorder cancel = new cancelorder(manager);
            cancel.Show();
            this.Hide();
        }

        //_________ORDER ITEM______________
        private void button1_Click(object sender, EventArgs e)
        {
            orderform order = new orderform(manager);
            order.Show();
            this.Hide();
        }
    }
}
