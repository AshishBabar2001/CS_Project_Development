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
    public partial class Frm_Add_Category : Form
    {
        public Frm_Add_Category()
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
            Cmd.CommandText = "Select Count(*) From Category_Details";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Category_Id) From Category_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1001;

            }

            SCon_Closed();

            return Cnt;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if ( tb_Category_Name.Text == "")
            {
                MessageBox.Show("Fill All Records");    
            }
            else
            {
               SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Category_Details (Category_Id,Category_Name) Values(" + tb_Category_ID.Text + " ,'" + tb_Category_Name.Text + "')";

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Succesfully");
                tb_Category_Name.Clear();
                tb_Category_ID.Text = Convert.ToString(Auto_Incr());
            }
            SCon_Closed();
         }

        private void Frm_Add_Category_Load(object sender, EventArgs e)
        {
            tb_Category_ID.Text = Convert.ToString(Auto_Incr());
        }

        private void tb_Category_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Category_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
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
