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
    public partial class PrintBill : Form
    {
        internal CustomerBL cust;
        public PrintBill(CustomerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
        }

        //_____________PRINT BILL__________________
        private void button1_Click(object sender, EventArgs e)
        {
            float total;
            total = cust.totalBill();
            MessageBox.Show("\nThe Amount is.........................................." + total + " Rs.");
        }

        //_____________BACK BUTTON___________
        private void button3_Click(object sender, EventArgs e)
        {
            CUSTOMER cUSTOMER = new CUSTOMER(cust);
            cUSTOMER.Show();
            this.Hide();
        }

        //____________EXIT BUTTON__________________
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
