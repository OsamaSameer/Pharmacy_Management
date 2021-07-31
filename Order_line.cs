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
    public partial class Order_line : Form
    {
        public Order_line()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Order_line(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text);
            Order L = new Order();
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

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Order_line_Load(object sender, EventArgs e)
        {

        }
    }
}
