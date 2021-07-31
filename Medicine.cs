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
    public partial class Medicine : Form
    {
        private int ID;
        public Medicine()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            int id = Functions.GET_Med_ID();
            id++;
            ID = id;
            bunifuMetroTextbox1.Text = id.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Medi(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox6.Text, bunifuMetroTextbox7.Text, bunifuMetroTextbox9.Text);
            MessageBox.Show("SAVED SUCCCCESSSSSFULLLY!");
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

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
