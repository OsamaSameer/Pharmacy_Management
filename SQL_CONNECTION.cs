using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    class SQL_CONNECTION
    {
        public static SqlConnection cnn;

        public static void conOp()
        {
            string connetionString;
            connetionString = @"Data Source=OSMI;Initial Catalog = Pharmacy_Management;Integrated Security=True;";//User ID=ansa;Password=OSAMA;
            cnn = new SqlConnection(connetionString);
            cnn.Open();
           // MessageBox.Show("Connection Open  !");
            //cnn.Close();
        }
        public static void conCl()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
            MessageBox.Show("Connection Closed  !");
        }
    }
}

