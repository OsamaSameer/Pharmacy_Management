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
    public partial class SIGNIN : Form
    {
        public SIGNIN()
        {
            InitializeComponent();
        }

        private void Patient_Click(object sender, EventArgs e)
        {
            Patient L = new Patient();
            createtab(L);
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            Doctor_SIGN_IN L = new Doctor_SIGN_IN();
            createtab(L);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void createtab(Form obj)
        {
            tabControl1.TabPages.Clear();
            TabPage tb = new TabPage { };
            tb.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Add(tb);
            obj.TopLevel = false;
            obj.Parent = tb;
            obj.Show();
            obj.Dock = DockStyle.Fill;
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_SIGN_IN L = new Employee_SIGN_IN();
            createtab(L);

        }

        private void Medicine_Click(object sender, EventArgs e)
        {
            
            Medicine L = new Medicine();
            createtab(L);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN L = new MAIN();
            L.ShowDialog();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MAIN L = new MAIN();
            L.ShowDialog();

        }
    }
}
