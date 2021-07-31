using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            int id = Functions.GET_order_ID();
            id++;
            bunifuMetroTextbox1.Text = id.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Order(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text,bunifuMetroTextbox3.Text);
            BILL L = new BILL();
            this.Hide();
            L.ShowDialog();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
