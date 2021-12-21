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
    public partial class Frm_Search_And_Update_Distributor : Form
    {
        public Frm_Search_And_Update_Distributor()
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Id.Text == "")
            {
                MessageBox.Show("First Fill Id To See Result.", "Exclamation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Distributor_Details Where Id = " + tb_Id.Text + "";

                var obj = Cmd.ExecuteReader();
                if (obj.Read())
                {
                    dtp_Tie_Up_Date.Text = (obj["Tie_Up_Date"].ToString());
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (obj["Mobile_No"].ToString());
                    tb_Mobile_No_Optional.Text = (obj["Mobile_No_Sec"].ToString());
                    tb_Email_Id.Text = obj.GetString(obj.GetOrdinal("Email_Id"));
                    tb_Adhaar_No.Text = (obj["Adhaar_No"].ToString());
                    tb_Pan_No.Text = (obj["PAN_No"].ToString());
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Deliverd_Product.Text = obj.GetString(obj.GetOrdinal("Product"));
                }
                else
                {
                    MessageBox.Show("Invalid ID Number!!!");
                }
            }

            tb_Address.Enabled = true;
            tb_Adhaar_No.Enabled = true;
            tb_Deliverd_Product.Enabled = true;
            tb_Email_Id.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Mobile_No_Optional.Enabled = true;
            tb_Name.Enabled = true;
            tb_Pan_No.Enabled = true;

            SCon_Closed();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Id.Enabled == false)
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Update Distributror_Details Set Name = '" + tb_Name.Text + "',Tie_Up_Date = '" + dtp_Tie_Up_Date.Text + "',Mobile_No = " + tb_Mobile_No.Text + ",Mobile_No_Sec = " + tb_Mobile_No_Optional.Text + ",Email_id = '" + tb_Email_Id.Text + "',Adhaar_No = " + tb_Adhaar_No.Text + ",PAN_No = '" + tb_Pan_No.Text + "',Address = '" + tb_Address.Text + "',Product = '" + tb_Deliverd_Product.Text + "' Where Id = " + tb_Id.Text + " ";

                Cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Record Updated Succesfully");
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
