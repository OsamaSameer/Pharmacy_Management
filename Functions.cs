using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Pharmacy_Management;
using System.Windows.Forms;

namespace Pharmacy_Management
{
    class Functions
    {
        //Create_New_Patient

        public static void Create_New_Patient(string id, string name, string gender, string Cnic,string Phone,string Email,string age)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Patient", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@P_ID", id);
            Cr_New.Parameters.AddWithValue("@P_Name", name);
            Cr_New.Parameters.AddWithValue("@P_Gender", gender);
            Cr_New.Parameters.AddWithValue("@P_Cnic", Cnic);
            Cr_New.Parameters.AddWithValue("@P_PhoneNumber", Phone);
            Cr_New.Parameters.AddWithValue("@P_Email", Email);
            Cr_New.Parameters.AddWithValue("@P_Age", age);
            Cr_New.ExecuteNonQuery();
        }
        
        public static int GET_Paitent_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Patient_ID) from Patient";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }

        //Create_New_Doctor

        public static void Create_New_Doctor(string id, string name, string Specialist)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Doctor", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@D_ID", id);
            Cr_New.Parameters.AddWithValue("@D_Name", name);
            Cr_New.Parameters.AddWithValue("@D_Speciality", Specialist);
            Cr_New.ExecuteNonQuery();
        }
        
        public static int GET_Doctor_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Doctor_ID) from Doctor";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }

        //Create_New_Employee

        public static void Create_New_Employee(string id, string name, string date, string salary)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Employee", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@E_ID", id);
            Cr_New.Parameters.AddWithValue("@E_name", name);
            Cr_New.Parameters.AddWithValue("@J_date", date);
            Cr_New.Parameters.AddWithValue("@salary", salary);;
            Cr_New.ExecuteNonQuery();
        }

        public static int GET_Employee_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Employee_ID) from Employee";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }


        //Create_New_Record

        public static void Create_New_Record(string Re_id, string Pa_id, string Do_id)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Employee", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@R_ID", Re_id);
            Cr_New.Parameters.AddWithValue("@P_ID", Pa_id);
            Cr_New.Parameters.AddWithValue("@D_ID", Do_id);
            Cr_New.ExecuteNonQuery();
        }

        public static int GET_Record_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Record_ID) from Record";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }

       // Create_New_Medi

        public static void Create_New_Medi(string id, string name, string C_name, string type, string Batch, string Price, string Salts, string stock)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Medicine3", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@M_ID", id);
            Cr_New.Parameters.AddWithValue("@M_Name", name);
            Cr_New.Parameters.AddWithValue("@M_company", C_name);
            Cr_New.Parameters.AddWithValue("@M_Type", type);
            Cr_New.Parameters.AddWithValue("@M_Batch", Batch);
            Cr_New.Parameters.AddWithValue("@M_Price", Price);
            Cr_New.Parameters.AddWithValue("@M_Salts", Salts);
            Cr_New.Parameters.AddWithValue("@M_Stock", stock);
            Cr_New.ExecuteNonQuery();
        }

        public static int GET_Med_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Medicine_ID) from Medicine";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }



        public static void Create_New_Priscription(string id, string M_id, string P_id , string D_id, string Quantity)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_Prescribed", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@pres_ID", id);
            Cr_New.Parameters.AddWithValue("@M_ID", M_id);
            Cr_New.Parameters.AddWithValue("@P_ID", P_id);
            Cr_New.Parameters.AddWithValue("@D_ID", D_id);
            Cr_New.Parameters.AddWithValue("@Quantity", Quantity);
            Cr_New.ExecuteNonQuery();
        }

        public static bool login(string id,string name)
        {
            SQL_CONNECTION.conOp();
            bool flag = true;
            DataTable Test = new DataTable();
            SqlDataAdapter Check = new SqlDataAdapter("select * from Patient where (Patient_ID = @id and Patient_NAME = @name) ", SQL_CONNECTION.cnn);
            Check.SelectCommand.Parameters.AddWithValue("@id",id);
            Check.SelectCommand.Parameters.AddWithValue("@name",name);
            Check.Fill(Test);
            if (Test.Rows.Count == 0)
            {
                MessageBox.Show("Invalid Entery! or Data not found");
                flag = false;
            }
            if (flag == true)
            {
                MessageBox.Show("Welcome");
            }
            SQL_CONNECTION.conCl();

            return flag;
        }

        public static void Create_New_Order_line(string id, string P_id, string M_id, string Quantity)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("create_order_line", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@orderline_id", id);
            Cr_New.Parameters.AddWithValue("@patient_id", P_id);
            Cr_New.Parameters.AddWithValue("@medicine_id", M_id);
            Cr_New.Parameters.AddWithValue("@medicine_quantity", Quantity);
            Cr_New.ExecuteNonQuery();
        }

        public static void Create_New_Order(string id, string P_id,string m_id)
        {
            SQL_CONNECTION.conOp();
            SqlCommand Cr_New = new SqlCommand("Create_MainOrder", SQL_CONNECTION.cnn);
            Cr_New.CommandType = CommandType.StoredProcedure;
            Cr_New.Parameters.AddWithValue("@O_ID", id);
            Cr_New.Parameters.AddWithValue("@P_id", P_id);
            Cr_New.Parameters.AddWithValue("@M_id", m_id);
            Cr_New.ExecuteNonQuery();
        }

        public static int GET_order_ID()
        {
            SQL_CONNECTION.conOp();
            string Qurry;
            Qurry = "SELECT MAX(Main_Order_ID) from Main_Order";
            SqlCommand Get_id = new SqlCommand(Qurry, SQL_CONNECTION.cnn);
            int id = int.Parse(Get_id.ExecuteScalar().ToString());
            return id;
        }

        public static DataTable Display_Bill()
        {
            SQL_CONNECTION.conOp();
            DataTable Test = new DataTable();
            SqlDataAdapter Cr_New = new SqlDataAdapter("select Main_Order.Main_Order_ID,Main_Order.Patient_ID,Main_Order.Order_Date,Main_Order.Total_Order,Patient.Patient_NAME , M.Medicine_NAME from Main_Order  inner join Patient on Main_Order.Patient_ID = Patient.Patient_ID  inner join Medicine M on M.Medicine_ID = Main_Order.Medicine_ID where (Main_Order_ID) in (Select MAX(Main_Order_ID) from Main_Order) ", SQL_CONNECTION.cnn);
            Cr_New.Fill(Test);
            return Test;
        }

        public static DataTable Display_Pris(string id)
        {
            SQL_CONNECTION.conOp();
            DataTable Test = new DataTable();
            SqlDataAdapter Cr_New = new SqlDataAdapter("select * from Prescribed where Patient_ID = @id; ", SQL_CONNECTION.cnn);
            Cr_New.SelectCommand.Parameters.AddWithValue("@id", id);
            Cr_New.Fill(Test);
            return Test;
        }
    }

    
}
