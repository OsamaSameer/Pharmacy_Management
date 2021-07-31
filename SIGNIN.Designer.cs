
namespace Pharmacy_Management
{
    partial class SIGNIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGNIN));
            this.TITLE = new System.Windows.Forms.Panel();
            this.OPT = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Medicine = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Employee = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Doctor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Patient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TITLE.SuspendLayout();
            this.OPT.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.Controls.Add(this.bunifuImageButton1);
            this.TITLE.Controls.Add(this.bunifuCustomLabel1);
            this.TITLE.Dock = System.Windows.Forms.DockStyle.Top;
            this.TITLE.Location = new System.Drawing.Point(0, 0);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(708, 41);
            this.TITLE.TabIndex = 0;
            // 
            // OPT
            // 
            this.OPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.OPT.Controls.Add(this.bunifuFlatButton2);
            this.OPT.Controls.Add(this.Medicine);
            this.OPT.Controls.Add(this.Employee);
            this.OPT.Controls.Add(this.Doctor);
            this.OPT.Controls.Add(this.Patient);
            this.OPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.OPT.Location = new System.Drawing.Point(0, 41);
            this.OPT.Name = "OPT";
            this.OPT.Size = new System.Drawing.Size(149, 275);
            this.OPT.TabIndex = 1;
            // 
            // main
            // 
            this.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.main.Controls.Add(this.tabControl1);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(149, 41);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(559, 275);
            this.main.TabIndex = 2;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(325, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 20);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SIGN IN";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 275);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Medicine
            // 
            this.Medicine.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Medicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Medicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Medicine.BorderRadius = 0;
            this.Medicine.ButtonText = "Medicine";
            this.Medicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medicine.DisabledColor = System.Drawing.Color.Gray;
            this.Medicine.Iconcolor = System.Drawing.Color.Transparent;
            this.Medicine.Iconimage = ((System.Drawing.Image)(resources.GetObject("Medicine.Iconimage")));
            this.Medicine.Iconimage_right = null;
            this.Medicine.Iconimage_right_Selected = null;
            this.Medicine.Iconimage_Selected = null;
            this.Medicine.IconMarginLeft = 0;
            this.Medicine.IconMarginRight = 0;
            this.Medicine.IconRightVisible = true;
            this.Medicine.IconRightZoom = 0D;
            this.Medicine.IconVisible = true;
            this.Medicine.IconZoom = 90D;
            this.Medicine.IsTab = false;
            this.Medicine.Location = new System.Drawing.Point(-3, 168);
            this.Medicine.Name = "Medicine";
            this.Medicine.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Medicine.OnHovercolor = System.Drawing.Color.Lime;
            this.Medicine.OnHoverTextColor = System.Drawing.Color.White;
            this.Medicine.selected = false;
            this.Medicine.Size = new System.Drawing.Size(149, 48);
            this.Medicine.TabIndex = 0;
            this.Medicine.Text = "Medicine";
            this.Medicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Medicine.Textcolor = System.Drawing.Color.White;
            this.Medicine.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medicine.Click += new System.EventHandler(this.Medicine_Click);
            // 
            // Employee
            // 
            this.Employee.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employee.BorderRadius = 0;
            this.Employee.ButtonText = "Employee";
            this.Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employee.DisabledColor = System.Drawing.Color.Gray;
            this.Employee.Iconcolor = System.Drawing.Color.Transparent;
            this.Employee.Iconimage = ((System.Drawing.Image)(resources.GetObject("Employee.Iconimage")));
            this.Employee.Iconimage_right = null;
            this.Employee.Iconimage_right_Selected = null;
            this.Employee.Iconimage_Selected = null;
            this.Employee.IconMarginLeft = 0;
            this.Employee.IconMarginRight = 0;
            this.Employee.IconRightVisible = true;
            this.Employee.IconRightZoom = 0D;
            this.Employee.IconVisible = true;
            this.Employee.IconZoom = 90D;
            this.Employee.IsTab = false;
            this.Employee.Location = new System.Drawing.Point(-3, 114);
            this.Employee.Name = "Employee";
            this.Employee.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Employee.OnHovercolor = System.Drawing.Color.Lime;
            this.Employee.OnHoverTextColor = System.Drawing.Color.White;
            this.Employee.selected = false;
            this.Employee.Size = new System.Drawing.Size(149, 48);
            this.Employee.TabIndex = 0;
            this.Employee.Text = "Employee";
            this.Employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Employee.Textcolor = System.Drawing.Color.White;
            this.Employee.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // Doctor
            // 
            this.Doctor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Doctor.BorderRadius = 0;
            this.Doctor.ButtonText = "Doctor";
            this.Doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Doctor.DisabledColor = System.Drawing.Color.Gray;
            this.Doctor.Iconcolor = System.Drawing.Color.Transparent;
            this.Doctor.Iconimage = ((System.Drawing.Image)(resources.GetObject("Doctor.Iconimage")));
            this.Doctor.Iconimage_right = null;
            this.Doctor.Iconimage_right_Selected = null;
            this.Doctor.Iconimage_Selected = null;
            this.Doctor.IconMarginLeft = 0;
            this.Doctor.IconMarginRight = 0;
            this.Doctor.IconRightVisible = true;
            this.Doctor.IconRightZoom = 0D;
            this.Doctor.IconVisible = true;
            this.Doctor.IconZoom = 90D;
            this.Doctor.IsTab = false;
            this.Doctor.Location = new System.Drawing.Point(0, 60);
            this.Doctor.Name = "Doctor";
            this.Doctor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Doctor.OnHovercolor = System.Drawing.Color.Lime;
            this.Doctor.OnHoverTextColor = System.Drawing.Color.White;
            this.Doctor.selected = false;
            this.Doctor.Size = new System.Drawing.Size(149, 48);
            this.Doctor.TabIndex = 0;
            this.Doctor.Text = "Doctor";
            this.Doctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Doctor.Textcolor = System.Drawing.Color.White;
            this.Doctor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Patient
            // 
            this.Patient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Patient.BorderRadius = 0;
            this.Patient.ButtonText = "Patient";
            this.Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Patient.DisabledColor = System.Drawing.Color.Gray;
            this.Patient.Iconcolor = System.Drawing.Color.Transparent;
            this.Patient.Iconimage = ((System.Drawing.Image)(resources.GetObject("Patient.Iconimage")));
            this.Patient.Iconimage_right = null;
            this.Patient.Iconimage_right_Selected = null;
            this.Patient.Iconimage_Selected = null;
            this.Patient.IconMarginLeft = 0;
            this.Patient.IconMarginRight = 0;
            this.Patient.IconRightVisible = true;
            this.Patient.IconRightZoom = 0D;
            this.Patient.IconVisible = true;
            this.Patient.IconZoom = 90D;
            this.Patient.IsTab = false;
            this.Patient.Location = new System.Drawing.Point(0, 6);
            this.Patient.Name = "Patient";
            this.Patient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Patient.OnHovercolor = System.Drawing.Color.Lime;
            this.Patient.OnHoverTextColor = System.Drawing.Color.White;
            this.Patient.selected = false;
            this.Patient.Size = new System.Drawing.Size(149, 48);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patient";
            this.Patient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Patient.Textcolor = System.Drawing.Color.White;
            this.Patient.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "BACK";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(-3, 222);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(152, 48);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "BACK";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(676, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // SIGNIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(708, 316);
            this.Controls.Add(this.main);
            this.Controls.Add(this.OPT);
            this.Controls.Add(this.TITLE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SIGNIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGNIN";
            this.TITLE.ResumeLayout(false);
            this.TITLE.PerformLayout();
            this.OPT.ResumeLayout(false);
            this.main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TITLE;
        private System.Windows.Forms.Panel OPT;
        private Bunifu.Framework.UI.BunifuFlatButton Medicine;
        private Bunifu.Framework.UI.BunifuFlatButton Employee;
        private Bunifu.Framework.UI.BunifuFlatButton Doctor;
        private Bunifu.Framework.UI.BunifuFlatButton Patient;
        private System.Windows.Forms.Panel main;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}