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
    public partial class Frm_Add_Product_Details : Form
    {
        public Frm_Add_Product_Details()
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
            Cmd.CommandText = "Select Count(*) From Main_Product_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Product_Id) From Main_Product_Details ";

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

        void clear_Controls()
        {
            cmb_Category.SelectedIndex = -1;
            tb_Name.Clear();
            tb_Purchase_Price.Clear();
            tb_Quantity.Clear();
            cmb_Unit.SelectedIndex = -1;
            tb_Sales_Price.Clear();
            Dgv_Show_Added_Details.Rows.Clear();
        }

        private void Frm_Add_Product_Details_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());

            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Category_Name) From Category_Details ";
            
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            Cmd.Dispose();
            obj.Dispose();

            SqlCommand Cmd2 = new SqlCommand();
            Cmd2.Connection = Con;
            Cmd2.CommandText = "Select Distinct(Unit_Name) From Unit_Details";

            var Obj2 = Cmd2.ExecuteReader();

            while (Obj2.Read())
            {
                cmb_Unit.Items.Add(Obj2.GetString(Obj2.GetOrdinal("Unit_Name")));
            }

            SCon_Closed();
        }

        private void tb_Purchase_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)||(e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsLetterOrDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)||(e.KeyChar == (Char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void tb_Sales_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if ( tb_Quantity.Text != "" && cmb_Unit.Text != "" && tb_Purchase_Price.Text != "" && tb_Sales_Price.Text != "")
            {
                Dgv_Show_Added_Details.Rows.Add(tb_Quantity.Text, cmb_Unit.Text, tb_Purchase_Price.Text, tb_Sales_Price.Text);

                tb_Quantity.Text = "";
                cmb_Unit.SelectedIndex = -1;
                tb_Purchase_Price.Text = "";
                tb_Sales_Price.Text = "";

            }
            else
            {
                MessageBox.Show("Please,Fill All Details.","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }  

        private void btn_Save_Details_Click(object sender, EventArgs e)
        {
            SCon_Open();
            
            if (tb_ID.Text == "" && tb_Name.Text == "" && cmb_Category.Text == "" && Dgv_Show_Added_Details.Rows.Count == 0 )
            {
               MessageBox.Show("Fill All Records","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);       
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = " Insert Into Main_Product_Details (Product_Id,Category,Date,Product_Name) Values(@Product_Id,@Category,@Date,@Name)";

                Cmd.Parameters.Add("@Product_Id", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                Cmd.Parameters.Add("@Date",SqlDbType.Date).Value = dtp_Date.Value.Date;
                Cmd.Parameters.Add("@Name",SqlDbType.NVarChar).Value = tb_Name.Text;

                Cmd.ExecuteNonQuery();

                Cmd.Dispose();

                Cmd.Connection = Con;
                Cmd.CommandText = "select Max(Product_Id) From Main_Product_Details";

                int Id = Convert.ToInt32(Cmd.ExecuteScalar());
                Cmd.Dispose();

                foreach (DataGridViewRow Row in Dgv_Show_Added_Details.Rows)
                {
                    Cmd.Connection = Con;
                    Cmd.CommandText = "Insert Into Sub_Product_Details (Main_Id,Product_Id,Name,Current_Stock,Quantity,Unit,Purchase_Price,Sales_Price) Values (" + tb_ID.Text + "," + Id + ",'" + tb_Name.Text + "',0," + Row.Cells[0].Value + ",'" + Row.Cells[1].Value + "'," + Row.Cells[2].Value + "," + Row.Cells[3].Value + ")";
                    
                    Cmd.ExecuteNonQuery();

                }
                                
                tb_ID.Text = Convert.ToString(Auto_Incr());
                clear_Controls();

                MessageBox.Show("Record Saved Succesfully", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                
                SCon_Closed();
            }
            
        }
        private void btn_Referesh_Details_Click(object sender, EventArgs e)
        {
            clear_Controls();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand ();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Category_Details where Category_Name = '" + cmb_Category.Text + "' ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category_Name")));
            }

            SCon_Closed();
        }

        private void cmb_Unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText ="Select * From Unit_Details where Unit_Name = '" + cmb_Unit.Text + "' ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Unit.Items.Add(obj.GetString(obj.GetOrdinal("Unit_Name")));
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
