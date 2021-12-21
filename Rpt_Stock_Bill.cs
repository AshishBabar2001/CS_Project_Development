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
    public partial class Rpt_Stock_Bill : Form
    {
        public Rpt_Stock_Bill()
        {
            InitializeComponent();
        }
        ReportDocument crypt = new ReportDocument();
        SqlDataAdapter Sda;

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

        private void Rpt_Stock_Bill_Load(object sender, EventArgs e)
        {
            SCon_Open();

                Sda = new SqlDataAdapter("SELECT * From Stock_Received_Details", Con);
                DataSet dt = new DataSet();
                Sda.Fill(dt, "Stock_Received_Details");
                crypt.Load(@"D:\Farming_Management_System\Farming_Management_System\Crystal_Reports_Files\Stock_Bill.rpt");
                crypt.SetDataSource(dt);
                cryst_Stock_Bill.ReportSource = crypt;
            
            SCon_Closed();
        }
    }
}
