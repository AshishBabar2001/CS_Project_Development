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
    public partial class Frm_Add_Stocks : Form
    {
        public Frm_Add_Stocks()
        {
            InitializeComponent();
        }

        double PPrice = 0;
        int Id = 0;

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

        void Clear_Controls()
        {
            cmb_Category.Text = "";
            cmb_Product_Name.Text = "";
            cmb_Quantity.Text = "";
            tb_Stock_Added.Text = "";
            tb_Total_Price.Text = "";

        }

        private void tb_Product_ID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Current_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Add_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Total_Price_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }
        private void Frm_Add_Stocks_Load(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Category) From Main_Product_Details ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category")));
            }

            Cmd.Dispose();
            
            SCon_Closed();
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Main_Product_Details where Category = '" + cmb_Category.Text + "' ";
            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Product_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            SCon_Closed();
        }

        private void cmb_Product_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Product_Id From Main_Product_Details where Category = '" + cmb_Category.Text + "' And Product_Name = '" + cmb_Product_Name.Text + "' ";

            Id = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            Cmd.CommandText = "Select Quantity, Unit From Sub_Product_Details where Product_Id = " + Id + " ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                lbl_Unit_Value.Text = obj.GetString(obj.GetOrdinal("Unit"));
                cmb_Quantity.Items.Add(obj["Quantity"].ToString());
            }

            SCon_Closed();
        }

        private void cmb_Quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Sub_Product_Details where Product_Id = " + Id + " And Quantity = " + cmb_Quantity.Text + " ", Con);

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                PPrice = Convert.ToDouble((obj["Purchase_Price"].ToString()));
                tb_Current_Stock.Text = (obj["Current_Stock"].ToString());
            }

            SCon_Closed();
        }


        private void tb_Stock_Added_TextChanged(object sender, EventArgs e)
        {
            if (tb_Stock_Added.Text != "")
            {
                double Tot_Price = PPrice * Convert.ToDouble(tb_Stock_Added.Text);

                tb_Total_Price.Text = Convert.ToString(Tot_Price);
            }
        }

        private void tb_Stock_Added_Leave(object sender, EventArgs e)
        {
            int Stock = Convert.ToInt32(tb_Stock_Added.Text);
            if (tb_Stock_Added.Text == "")
            {
                MessageBox.Show("Fill Stock First");
                tb_Stock_Added.Text = "0";
                tb_Stock_Added.Focus();
            }
            else if (Stock <= 0)
            {
                MessageBox.Show("Invalid Value For New Stock");
                tb_Stock_Added.Text = "0";
                tb_Stock_Added.Focus();

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            if (cmb_Category.Text == "" && cmb_Product_Name.Text == "" && cmb_Quantity.Text == "" && tb_Stock_Added.Text == "")
            {
                MessageBox.Show("Fill All Records First", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Stock_Received_Details (Id,Category,P_Name,Unit,Quantity,Stock,Date,Total_Price) Values (1,@Category,@Name,@Unit,0,@Stock_Add,@Date,@Tot_Price)";

                Cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = cmb_Category.Text;
                Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = cmb_Product_Name.Text;
                Cmd.Parameters.Add("@Unit", SqlDbType.NVarChar).Value = cmb_Quantity.Text;
                Cmd.Parameters.Add("@Stock_Add", SqlDbType.Int).Value = tb_Stock_Added.Text;
                Cmd.Parameters.Add("@Tot_Price", SqlDbType.Money).Value = tb_Total_Price.Text;
                Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                SqlCommand Cmd2 = new SqlCommand();
                Cmd2.Connection = Con;
                Cmd2.CommandText = "Insert Into Sub_Product_Details (Current_Stock) Values (" + tb_Current_Stock.Text + ")";

                MessageBox.Show("Record Fill Succesfully ", "Asterisk)", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                Clear_Controls();

                cmb_Category.Focus();
            }

            SCon_Closed();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Mdi_Form_Loadder Obj = new Mdi_Form_Loadder();
            Obj.Show();
            this.Hide();
            Obj.Hide();
        }
    }
}

