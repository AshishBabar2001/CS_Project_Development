using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Farming_Management_System
{
    public partial class Cry_Rpt_Customer_Bill : Form
    {
        public Cry_Rpt_Customer_Bill()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DB_Farming_Management_System;Integrated Security=True");

        void SCon_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void SCon_Closed()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }
    
        ReportDocument crypt = new ReportDocument();
        SqlDataAdapter Sda;

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Customer_Id.Text != "")
            {
                Sda = new SqlDataAdapter("SELECT Customer_Details.Customer_Id,Customer_Details.Customer_Name,Customer_Details.Date,Customer_Details.Mobile_No,Customer_Purchase_Details.Category,Customer_Purchase_Details.P_Name,Customer_Purchase_Details.Unit_Qty,Customer_Purchase_Details.Price,Customer_Purchase_Details.Quantity,Customer_Purchase_Details.Total_Price,Customer_Purchase_Details.Bill,Customer_Purchase_Details.GST,Customer_Purchase_Details.Final_Bill From Customer_Details INNER JOIN Customer_Purchase_Details ON Customer_Details.Customer_Id = Customer_Purchase_Details.Customer_Id Where Customer_Details.Customer_Id = " + tb_Customer_Id.Text + "", Con);
                DataSet dt = new DataSet();
                Sda.Fill(dt,"Customer_Details");
                Sda.Fill(dt,"Customer_Purchase_Details");

                crypt.Load(@"D:\Farming_Management_System\Farming_Management_System\Crystal_Reports_Files\crypt_Customer_Bill.rpt");
                crypt.SetDataSource(dt);
                cryst_Customer_Bill.ReportSource = crypt;
            }
            else
            {
                MessageBox.Show("Invalid Id,Please Enter Correct Id !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            SCon_Closed();
        }
    }
}
