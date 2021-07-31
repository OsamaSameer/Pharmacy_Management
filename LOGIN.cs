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
    public partial class LOGIN : Form
    {

        public LOGIN()
        {
            InitializeComponent();
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (Functions.login(bunifuTextbox1.text, bunifuTextbox2.text) == true)
            {
                Order_line L = new Order_line();
                this.Hide();
                L.ShowDialog();
            }
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
