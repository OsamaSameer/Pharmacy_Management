
namespace Pharmacy_Management
{
    partial class BILL
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
            this.components = new System.ComponentModel.Container();
            this.mainOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_ManagementDataSet4 = new Pharmacy_Management.Pharmacy_ManagementDataSet4();
            this.main_OrderTableAdapter = new Pharmacy_Management.Pharmacy_ManagementDataSet4TableAdapters.Main_OrderTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_ManagementDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainOrderBindingSource
            // 
            this.mainOrderBindingSource.DataMember = "Main_Order";
            this.mainOrderBindingSource.DataSource = this.pharmacy_ManagementDataSet4;
            // 
            // pharmacy_ManagementDataSet4
            // 
            this.pharmacy_ManagementDataSet4.DataSetName = "Pharmacy_ManagementDataSet4";
            this.pharmacy_ManagementDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // main_OrderTableAdapter
            // 
            this.main_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BILL";
            this.Text = "BILL";
            this.Load += new System.EventHandler(this.BILL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_ManagementDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Pharmacy_ManagementDataSet4 pharmacy_ManagementDataSet4;
        private System.Windows.Forms.BindingSource mainOrderBindingSource;
        private Pharmacy_ManagementDataSet4TableAdapters.Main_OrderTableAdapter main_OrderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}