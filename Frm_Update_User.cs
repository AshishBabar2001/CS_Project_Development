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
    public partial class Frm_Update_User : Form
    {
        public Frm_Update_User()
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SCon_Open();
            if (tb_Enter_New_Password.Text != tb_Confirm_New_Password.Text)
            {
                MessageBox.Show("Password Is Not Match");
            }
            if (tb_Enter_Username.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Update Login_Users Set Password = '" + tb_Enter_New_Password.Text + "' Where Username = '" + tb_Enter_Username.Text + "'";

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Password Updated");
            }
            else
            {
                MessageBox.Show("First Fill Username !!!");
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
