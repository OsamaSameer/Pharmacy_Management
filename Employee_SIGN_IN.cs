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
    public partial class Employee_SIGN_IN : Form
    {
        public Employee_SIGN_IN()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Employee_SIGN_IN_Load(object sender, EventArgs e)
        {
            int id = Functions.GET_Employee_ID();
            id++;
            bunifuMetroTextbox1.Text = id.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Functions.Create_New_Employee(bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, bunifuMetroTextbox4.Text);
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MAIN L = new MAIN();
            this.Close();
            this.Hide();
            L.ShowDialog();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
