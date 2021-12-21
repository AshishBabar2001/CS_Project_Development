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
    public partial class Frm_Add_Employee : Form
    {
        public Frm_Add_Employee()
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
            Cmd.CommandText = "Select Count(*) From Employees_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Id) From Employees_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 10001;

            }

            SCon_Closed();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            tb_Address.Clear();
            tb_Adhaar_No.Clear();
            tb_Experience.Clear();
            tb_PAN_No.Clear();
            tb_Qualification.Clear();
            tb_Salary.Clear();
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Mobile_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Adhaar_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_PAN_No_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Qualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Experience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
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

            if (tb_Name.Text == "" && tb_Mobile_No.Text == "" && tb_Adhaar_No.Text == "" && tb_PAN_No.Text == "" && tb_Qualification.Text == "" && tb_Salary.Text == "" && tb_Address.Text == "" && tb_Experience.Text == "")
            {
                MessageBox.Show("Fill All The Records !!!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into Employees_Details (Id,Date,Name,Mobile_No,Gender,Dob,Adhaar_No,PAN_No,Qualification,Experience,Salary,Post,Address) Values (@Id,@Date,@Name,@Mobile_No,@Gender,@DOB,@Adhaar_No,@PAN_No,@Qualification,@Experience,@Salary,@Post,@Address)";

                Cmd.Parameters.Add("@Id",SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("@Date",SqlDbType.Date).Value = dtp_Date.Value.Date;
                Cmd.Parameters.Add("@Name",SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("@Mobile_No",SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("@DOB",SqlDbType.Date).Value = dtp_Date_Of_Birth.Value.Date;
                Cmd.Parameters.Add("@Adhaar_No",SqlDbType.Decimal).Value = tb_Adhaar_No.Text;
                Cmd.Parameters.Add("@PAN_No",SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("@Qualification",SqlDbType.NVarChar).Value = tb_Qualification.Text;
                Cmd.Parameters.Add("@Experience",SqlDbType.NVarChar).Value = tb_Experience.Text;
                Cmd.Parameters.Add("@Salary",SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("@Post",SqlDbType.NVarChar).Value = cmb_Post.Text;
                Cmd.Parameters.Add("@Address",SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("@Gender",SqlDbType.NChar).Value = Gender;

                Cmd.ExecuteNonQuery();

                tb_ID.Text = Convert.ToString(Auto_Incr());

                MessageBox.Show(" Employeee Added Succefully ");

                Clear_Controls();
            }

            SCon_Closed();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

            MessageBox.Show("Data Is Refreshed !!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Frm_Add_Employee_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            Mdi_Form_Loadder Obj = new Mdi_Form_Loadder();
            Obj.Show();
            this.Hide();
            Obj.Hide();
        }
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      