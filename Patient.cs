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
    public partial class Patient : Form
    {
        private int ID;
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            int id = Functions.GET_Paitent_ID();
            id++;
            ID = id;
            bunifuMetroTextbox1.Text = id.ToString();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Patient(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text, bunifuMetroTextbox5.Text, bunifuMetroTextbox6.Text, bunifuMetroTextbox7.Text);

            MessageBox.Show("SAVED SUCCCCESSSSSFULLLY!");

            Prescribtion L = new Prescribtion(ID);
            this.Close();
            this.Hide();
            L.ShowDialog();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN L = new MAIN();
            L.ShowDialog();
        }
    }
}
