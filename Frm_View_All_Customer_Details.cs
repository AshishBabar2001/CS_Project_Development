using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farming_Management_System
{
    public partial class Frm_View_All_Customer_Details : Form
    {
        public Frm_View_All_Customer_Details()
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
        private void Frm_View_All_Customer_Details_Load(object sender, EventArgs e)
        {
            SCon_Open();

            SqlDataAdapter Sda = new SqlDataAdapter("Select * From Customer_Details", Con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            dgv_View_All_Employee_details.DataSource = dt;

            Sda.Dispose();
            dt.Dispose();

            SqlDataAdapter Sda2 = new SqlDataAdapter("Select * From Customer_Purchase_Details", Con);

            DataTable dt2 = new DataTable();

            Sda2.Fill(dt2);

            dgv_View_All_Employee_details.DataSource = dt2;

            SCon_Closed();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Id.Text != "")
            {
                SqlDataAdapter Sda = new SqlDataAdapter("Select * From Customer_Details Where Customer_Id = " + tb_Id.Text + "", Con);
                DataTable dt = new DataTable();

                Sda.Fill(dt);

                dgv_View_All_Employee_details.DataSource = dt; 

                Sda.Dispose();

            }
            else
            {
                MessageBox.Show("Enter Customer Id First !!!!");
            }

            SCon_Closed();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Mdi_Form_Loadder Obj = new Mdi_Form_Loadder();
            Obj.Show();
            this.Hide();
            Obj.Hide();
        }
    }
}
