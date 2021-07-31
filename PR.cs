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
    public partial class PR : Form
    {
        public PR()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.Display_Pris(bunifuMetroTextbox1.Text);
        }

        private void PR_Load(object sender, EventArgs e)
        {

        }
    }
}
