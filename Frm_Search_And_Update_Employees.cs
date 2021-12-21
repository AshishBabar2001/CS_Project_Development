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
    public partial class Frm_Search_And_Update_Employees : Form
    {
        public Frm_Search_And_Update_Employees()
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

        void Enable()
        {
            tb_ID.Enabled = false;
            tb_Address.Enabled = true;
            tb_Adhaar_No.Enabled = true;
            tb_Experience.Enabled = true;
            tb_Mobile_No.Enabled = true;
            tb_Name.Enabled = true;
            tb_PAN_No.Enabled = true;
            tb_Qualification.Enabled = true;
            tb_Salary.Enabled = true;
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_ID.Text == "")
            {
                MessageBox.Show("First Fill Id To See Result.", "Exclamation", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Employees_Details Where Id = " + tb_ID.Text + "";

                var obj = Cmd.ExecuteReader();
                if (obj.Read())
                {
                    dtp_Date.Text = (obj["Date"].ToString());
                    tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                    tb_Mobile_No.Text = (obj["Mobile_NO"].ToString());
                    dtp_Date_Of_Birth.Text = (obj["DOB"].ToString());
                    tb_Adhaar_No.Text = (obj["Adhaar_No"].ToString());
                    tb_PAN_No.Text = (obj["PAN_No"].ToString());
                    tb_Address.Text = obj.GetString(obj.GetOrdinal("Address"));
                    tb_Experience.Text = obj.GetString(obj.GetOrdinal("Experience"));
                    tb_Qualification.Text = obj.GetString(obj.GetOrdinal("Qualification"));
                    cmb_Post.Text = obj.GetString(obj.GetOrdinal("Post"));
                    tb_Salary.Text = (obj["Salary"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid ID Number!!!");
                }

                Enable();
            }

            SCon_Closed();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_ID.Enabled == false)
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Update Employees_Details Set Name = '" + tb_Name.Text + "',Mobile_No = " + tb_Mobile_No.Text + ",DOB = '" + dtp_Date_Of_Birth.Text + "',Adhaar_No = " + tb_Adhaar_No.Text + ",PAN_No = '" + tb_PAN_No.Text + "',Qualification = '" + tb_Qualification.Text + "',Experience = '" + tb_Experience.Text + "',Salary = " + tb_Salary.Text + ",Post = '" + cmb_Post.Text + "', Address = '" + tb_Address.Text + "' Where Id = " + tb_ID.Text + " ";
                    
                Cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Record Updated Succesfully");
            }

            SCon_Closed();
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
