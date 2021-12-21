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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = " Select Count(*) From Login_Users Where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'";
            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Succefully Login");

                Global_Var.Username = "Welcome " + tb_Username.Text;

                if (tb_Username.Text == "Admin")
                {
                    Global_Var.U_Id = 1;
                }
                else if (tb_Username.Text == "a")
                {
                    Global_Var.U_Id = 2;
                }
            
                Mdi_Form_Loadder Obj = new Mdi_Form_Loadder();
                Obj.Show();
                this.Hide();
            }
            else
            {
                tb_Username.Focus();

                lbl_Note.Text = "Invalid Username and Password";

            }
            SCon_Closed();

            tb_Username.Clear();
            tb_Password.Clear();
            
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Please,Enter Your Username && Password";
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Did You Really Want To Close");
            Application.Exit();
        }
    }
}
