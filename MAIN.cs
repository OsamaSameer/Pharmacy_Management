﻿using System;
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
    public partial class MAIN : Form
    {

       
        public MAIN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MAIN_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            LOGIN L = new LOGIN();
            this.Hide();
            L.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            PR L = new PR();
            this.Hide();
            L.ShowDialog();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SIGNIN L = new SIGNIN();
            this.Hide();
            L.ShowDialog();
        }
    }
}
