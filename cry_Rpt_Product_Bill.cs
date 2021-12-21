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
    public partial class cry_Rpt_Product_Bill : Form
    {
        public cry_Rpt_Product_Bill()
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

            if (tb_Product_Id.Text != "")
            {
                Sda = new SqlDataAdapter("SELECT Main_Product_Details.Product_Id,Category_Name,Date,Product_Name,Quantity,Unit,Purchase_Price From Product_Details Where Product_Id = " + tb_Product_Id.Text + "", Con);
                DataSet dt = new DataSet();
                Sda.Fill(dt, "Main_Product_Details");
                Sda.Fill(dt, "Sub_Product_Details");
                crypt.Load(@"D:\Farming_Management_System\Farming_Management_System\Crystal_Reports_Files\Cryst_Product_Bill.rpt");
                crypt.SetDataSource(dt);
                cryst_Product_Bill.ReportSource = crypt;
            }
            else
            {
                MessageBox.Show("Invalid Id,Please Enter Correct Id !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            SCon_Closed();
        }
    }
}
