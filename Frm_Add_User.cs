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
    public partial class Frm_Add_User : Form
    {
        public Frm_Add_User()
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

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text != "" && tb_Password.Text != "")
            {
                MessageBox.Show("You Will Loss Your Data So You want To Close Applications","Hand",MessageBoxButtons.YesNo,MessageBoxIcon.Hand);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Name.Text == "" && tb_Username.Text == "" && tb_Password.Text == "")
            {
                MessageBox.Show("Fill All Records First");
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Login_Users (Username,Password) values ('" + tb_Name.Text + "','" + tb_Password.Text + "')";
                Cmd.ExecuteNonQuery();

                MessageBox.Show("Records Added Succesfully");
            }

            SCon_Closed();
        }

        private void tb_Name_Click(object sender, EventArgs e)
        {
            tb_Username.Enabled = true;
        }

        private void tb_Username_Click(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
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
