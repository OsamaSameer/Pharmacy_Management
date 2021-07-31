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
    public partial class Prescribtion : Form
    {
        public Prescribtion(int ID)
        {
            InitializeComponent();
            bunifuMetroTextbox3.Text =ID.ToString();// OR bunifuMetroTextbox3.Text =ID+"";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Priscription(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text);

            PR L = new PR();
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

        private void bunifuMetroTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Prescribtion_Load(object sender, EventArgs e)
        {

        }
    }
}
