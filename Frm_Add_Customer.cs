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
    public partial class Frm_Add_Customer : Form
    {
        public Frm_Add_Customer()
        {
            InitializeComponent();
        }

        int Id = 0;
        Double SPrice = 0;

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


        void Category_Refresh()
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

            SCon_Closed();
            Cmd.Dispose();
            obj.Dispose();
        }
    
        int Auto_Incr()
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Customer_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Customer_Id) From Customer_Details ";

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

        void Clear_Controls()
        {
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Category.SelectedIndex = -1;
            cmb_Name.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total_Price.Clear();
            tb_Bill.Clear();
            tb_Final_Bill.Clear();
            dgv_Add_Customer.Rows.Clear();
            cmb_Unit_Qty.SelectedIndex = -1;
        }
        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
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

        private void tb_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
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

        private void tb_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
        }

        private void tb_Final_Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == '.')))
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

        private void Frm_Add_Customer_Load(object sender, EventArgs e)
        {
            tb_ID.Text = Convert.ToString(Auto_Incr());

            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct(Category) From Main_Product_Details ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                cmb_Category.Items.Add(obj.GetString(obj.GetOrdinal("Category")));
            }

            SCon_Closed();
            Cmd.Dispose();
            obj.Dispose();
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
                cmb_Name.Items.Add(obj.GetString(obj.GetOrdinal("Product_Name")));
            }

            SCon_Closed();

            Cmd.Dispose();
            obj.Dispose();
            cmb_Name.Enabled = true;

        }

        private void cmb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Product_Id From Main_Product_Details where Category = '" + cmb_Category.Text + "' And Product_Name = '" + cmb_Name.Text + "' ";

            Id = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            Cmd.CommandText = "Select Quantity, Unit From Sub_Product_Details where Product_Id = " + Id + " ";

            var obj = Cmd.ExecuteReader();

            while (obj.Read())
            {
                lbl_Unit.Text = obj.GetString(obj.GetOrdinal("Unit"));
                cmb_Unit_Qty.Items.Add(obj["Quantity"].ToString());
            }

            SCon_Closed();
            cmb_Unit_Qty.Enabled = true;
        }

        private void cmb_Unit_Qty_SelectedIndexChanged(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select * From Sub_Product_Details where Product_Id = " + Id + " And Quantity = '" + cmb_Unit_Qty.Text + "' ";

            var obj = Cmd.ExecuteReader();

            if (obj.Read())
            {
                SPrice = Convert.ToDouble((obj["Sales_Price"].ToString()));
                tb_Price.Text = (obj["Sales_Price"].ToString());
            }

            SCon_Closed();
            tb_Quantity.Enabled = true;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
             tb_Bill.Text = "0";
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SCon_Open();

            try
            {
                if (tb_Final_Bill.Text == "")
                {
                    MessageBox.Show("Fill All Records");
                }
                else
                {
                    SqlCommand Cmd = new SqlCommand();
                    Cmd.Connection = Con;
                    Cmd.CommandText = " Insert Into Customer_Details (Customer_Id,Customer_Name,Date,Mobile_No) Values (@Customer_Id,@Name,@Date,@M_No)";

                    Cmd.Parameters.Add("@Customer_Id", SqlDbType.Int).Value = tb_ID.Text;
                    Cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                    Cmd.Parameters.Add("@Date", SqlDbType.Date).Value = dtp_Date.Value.Date;
                    Cmd.Parameters.Add("@M_No", SqlDbType.Decimal).Value = tb_Mobile_No.Text;

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();

                    foreach (DataGridViewRow Row in dgv_Add_Customer.Rows)
                    {
                        SqlCommand Cmd2 = new SqlCommand();
                        Cmd2.Connection = Con;
                        Cmd2.CommandText = "Insert Into Customer_Purchase_Details (Customer_Id,Category,P_Name,Unit_Qty,Price,Quantity,Total_Price,Bill,GST,Final_Bill) Values (@Id,'" + Row.Cells[0].Value + "','" + Row.Cells[1].Value + "','" + Row.Cells[2].Value + "'," + Row.Cells[3].Value + "," + Row.Cells[4].Value + "," + Row.Cells[5].Value + ",@Bill,@GST,@FBill)";

                        Cmd2.Parameters.Add("@Id", SqlDbType.Int).Value = tb_ID.Text;
                        Cmd2.Parameters.Add("@Bill", SqlDbType.Money).Value = tb_Bill.Text;
                        Cmd2.Parameters.Add("@FBill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                        Cmd2.Parameters.Add("@GST", SqlDbType.Money).Value = tb_GST.Text;

                        Cmd2.ExecuteNonQuery();

                    }

                   // MessageBox.Show("Record Saved Succesfully", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                    tb_ID.Text = Convert.ToString(Auto_Incr());

                    Clear_Controls();

                    tb_Quantity.Enabled = true;
                }          
            }
            catch (Exception)
            {

                MessageBox.Show("Record Saved Succesfully", "Asterisk", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            
            SCon_Closed();
        }

        int pCnt = 1;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SCon_Open();

            int flag = -1;

            for (int i = 0; i <= dgv_Add_Customer.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgv_Add_Customer.Rows[i].Cells[2].Value) == tb_Quantity.Text)
                {
                    flag = 0;

                    int Qty = Convert.ToInt32(dgv_Add_Customer.Rows[i].Cells[4].Value);

                    Qty += Convert.ToInt32(tb_Quantity.Text);

                    double Tot_Price = Convert.ToDouble(Qty) * Convert.ToDouble(tb_Price.Text);

                    dgv_Add_Customer.Rows[i].Cells[3].Value = Qty;
                    dgv_Add_Customer.Rows[i].Cells[4].Value = Tot_Price;
                }
            }

            if (flag != 0)
            {
                dgv_Add_Customer.Rows.Add(cmb_Category.Text, cmb_Name.Text, cmb_Unit_Qty.Text, tb_Price.Text, tb_Quantity.Text, tb_Total_Price.Text);

                pCnt++;
            }

            double Bill = Convert.ToDouble(tb_Bill.Text);

            Bill = Convert.ToDouble(tb_Total_Price.Text) + Convert.ToDouble(tb_Bill.Text);
            tb_Bill.Text = Convert.ToString(Bill);
           
            cmb_Category.SelectedIndex = -1;
            cmb_Name.SelectedIndex = -1;
            cmb_Unit_Qty.SelectedIndex = -1;
            tb_Quantity.Text = "";
            tb_Price.Text = "";
            tb_Total_Price.Text = "";

            cmb_Category.Items.Clear();
            cmb_Name.Items.Clear();
            cmb_Unit_Qty.Items.Clear();
            tb_Quantity.Enabled = false;

            Category_Refresh();

            cmb_Category_SelectedIndexChanged(sender, e);
            cmb_Name_SelectedIndexChanged(sender, e);
            cmb_Unit_Qty_SelectedIndexChanged(sender, e);


            SCon_Closed();

        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "")
            {
                double Tot_Price = SPrice * Convert.ToDouble(tb_Quantity.Text);

                tb_Total_Price.Text = Convert.ToString(Tot_Price);
            }
            else
            {
                tb_Quantity.Focus();
            }
        }
 
        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_Bill.Text != "")
            {
                double GST = Convert.ToDouble(tb_Bill.Text) * (Convert.ToDouble(tb_GST.Text) / 100);

                double FBill = Convert.ToDouble(tb_Bill.Text) + GST;

                tb_Final_Bill.Text = Convert.ToString(FBill);
            }
            else
            {
                tb_GST.Focus();
            }
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
