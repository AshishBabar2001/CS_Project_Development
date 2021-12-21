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
    public partial class Frm_Add_Unit : Form
    {
        public Frm_Add_Unit()
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
            Cmd.CommandText = "Select Count(*) From Unit_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Unit_Id) From Unit_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 501;

            }

            SCon_Closed();

            return Cnt;
        }


        private void Add_Unit_Load(object sender, EventArgs e)
        {
            tb_Unit_ID.Text = Convert.ToString(Auto_Incr());
            tb_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (tb_Name.Text == "")
            {
                MessageBox.Show("Fill All Records");
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into Unit_Details (Unit_Id,Unit_Name) Values(@Id ,@Name)";

                Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tb_Unit_ID.Text;
                Cmd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = tb_Name.Text;

                Cmd.ExecuteNonQuery();
                                
                tb_Unit_ID.Text = Convert.ToString(Auto_Incr());

                MessageBox.Show("Record Saved Succesfully");

                tb_Name.Clear();
            }
            SCon_Closed();
        }

        private void tb_Unit_ID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
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
