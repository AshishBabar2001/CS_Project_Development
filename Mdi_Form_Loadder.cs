using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Farming_Management_System
{
    public partial class Mdi_Form_Loadder : Form
    {
        public Mdi_Form_Loadder()
        {
            InitializeComponent();
        }

        private void addCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Customer Adc = new Frm_Add_Customer();
            Adc.MdiParent = this;
            Adc.Show();
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Product_Details obj = new Frm_Add_Product_Details();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addStocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Add_Stocks obj = new Frm_Add_Stocks();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Category Cobj = new Frm_Add_Category();
            Cobj.MdiParent = this;
            Cobj.Show();
        }

        private void addUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Unit Uobj = new Frm_Add_Unit();
            Uobj.MdiParent = this;
            Uobj.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Employee Eobj = new Frm_Add_Employee();
            Eobj.MdiParent = this;
            Eobj.Show();
        }

        private void showAllEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_All_Employees_Details Aobj = new Frm_All_Employees_Details();
            Aobj.MdiParent = this;
            Aobj.Show();
        }

        private void addDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Distributor Dobj = new Frm_Add_Distributor();
            Dobj.MdiParent = this;
            Dobj.Show();
        }

        private void searchAndUpdateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_And_Update_Employees Sobj = new Frm_Search_And_Update_Employees();
            Sobj.MdiParent = this;
            Sobj.Show();
        }

        private void showAllDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_All_Distributor_Info Aobj = new Frm_View_All_Distributor_Info();
            Aobj.MdiParent = this;
            Aobj.Show();
        }

        private void searchAndUpdateDistributorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_And_Update_Distributor Sobj = new Frm_Search_And_Update_Distributor();
            Sobj.MdiParent = this;
            Sobj.Show();
        }

        private void showAllCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_View_All_Customer_Details Cobj = new Frm_View_All_Customer_Details();
            Cobj.MdiParent = this;
            Cobj.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_User Obj = new Frm_Add_User();
            Obj.MdiParent = this;
            Obj.Show();
            
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Update_User Uobj = new Frm_Update_User();
            Uobj.MdiParent = this;
            Uobj.Show();
        }

        private void deeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frn_Delete_User obj = new Frn_Delete_User();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Mdi_Form_Loadder_Load(object sender, EventArgs e)
        {
            lbl_User.Text = Global_Var.Username;

            if (Global_Var.U_Id == 1)
            {
                employeeToolStripMenuItem.Visible = true;
                distributorToolStripMenuItem.Visible = true;
                userManagementToolStripMenuItem.Visible = true;
            }
            else if (Global_Var.U_Id == 2)
            {
                toolsToolStripMenuItem.Visible = true;
            }
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        /*private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }*/

        private void customerBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cry_Rpt_Customer_Bill obj = new Cry_Rpt_Customer_Bill();
            obj.MdiParent = this;
            obj.Show();
        }

        private void productBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cry_Rpt_Product_Bill obj = new cry_Rpt_Product_Bill();
            obj.MdiParent = this;
            obj.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Rpt_Stock_Bill obj = new Rpt_Stock_Bill();
            obj.MdiParent = this;
            obj.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }
    }
}
