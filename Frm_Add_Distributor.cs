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
    public partial class Frm_Add_Distributor : Form
    {
        public Frm_Add_Distributor()
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

        int Auto_Incr()
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Distributor_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Id) From Distributor_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 5001;
            }

            SCon_Closed();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            tb_Mobile_No_Optional.Text = "";
            tb_Email_Id.Text = "";
            tb_Adhaar_No.Text = "";
            tb_Pan_No.Text = "";
            tb_Address.Text = "";
            tb_Deliverd_Project.Text = "";
            rb_Male.Checked = false;
            rb_Female.Checked = false;
        }

        private void tb_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_No_Optional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Frm_Add_Distributor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Email_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == '@') || ((e.KeyChar == '.'))))
            {
                e.Handled = true;
            }
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {

            SCon_Open();

            string Gender = "";

            if (rb_Male.Checked)
            {
                Gender = rb_Male.Text;
            }
            else
            {
                Gender = rb_Female.Text;
            }

            if (tb_Name.Text == "" && tb_Mobile_No.Text == "" && tb_Mobile_No_Optional.Text == "" && tb_Adhaar_No.Text == "" && tb_Email_Id.Text == "" && tb_Pan_No.Text == "" && tb_Address.Text == "" && tb_Deliverd_Project.Text == "")
            {
                MessageBox.Show("Fill All The Records !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into Distributor_Details (Id,Tie_Up_Date,Name,Gender,Mobile_No,Mobile_No_Sec,Email_Id,Adhaar_No,PAN_No,Address,Product) Values (@Id,@TUDate,@Name,@Gender,@Mobile_No,@Mobile_No_Optional,@Email,@Adhaar_No,@PAN_No,@Address,@Dp)";

                Cmd.Parameters.Add("@Id",SqlDbType.Int).Value = tb_Id.Text;
                Cmd.Parameters.Add("@TUDate",SqlDbType.Date).Value = dtp_Tie_Up_Date.Value.Date;
                Cmd.Parameters.Add("@Name",SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@Gender",SqlDbType.NVarChar).Value = Gender;
                Cmd.Parameters.Add("@Mobile_No",SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@Mobile_No_Optional",SqlDbType.Decimal).Value = tb_Mobile_No_Optional.Text;
                Cmd.Parameters.Add("@Email",SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("@Adhaar_No",SqlDbType.Decimal).Value = tb_Adhaar_No.Text;
                Cmd.Parameters.Add("@PAN_No",SqlDbType.NVarChar).Value = tb_Pan_No.Text;
                Cmd.Parameters.Add("@Address",SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("@Dp",SqlDbType.NVarChar).Value = tb_Deliverd_Project.Text;

                Cmd.ExecuteNonQuery();

                tb_Id.Text = Convert.ToString(Auto_Incr());

                MessageBox.Show(" Employeee Added Succefully ");

                Clear_Controls();
            }

            SCon_Closed();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Frm_Add_Distributor_Load(object sender, EventArgs e)
        {
            tb_Id.Text = Convert.ToString(Auto_Incr());
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
