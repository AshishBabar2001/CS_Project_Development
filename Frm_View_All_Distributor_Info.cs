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
    public partial class Frm_View_All_Distributor_Info : Form
    {
        public Frm_View_All_Distributor_Info()
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

        private void Frm_View_All_Distributor_Info_Load(object sender, EventArgs e)
        {
            SCon_Open();

            SqlDataAdapter Sda = new SqlDataAdapter("Select * From Distributor_Details", Con);

            DataTable dt = new DataTable();

            Sda.Fill(dt);

            dgv_View_All_Distributor.DataSource = dt;

            SCon_Closed();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Id.Text != "")
            {
                SqlDataAdapter Sda = new SqlDataAdapter("Select * From Distributor_Details Where ID = " + tb_Id.Text + "", Con);
                DataTable dt = new DataTable();

                Sda.Fill(dt);

                dgv_View_All_Distributor.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter Roll Number !!!!");
            }

            SCon_Closed();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Id.Clear();
            dgv_View_All_Distributor.Rows.Clear();
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
