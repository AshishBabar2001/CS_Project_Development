namespace Farming_Management_System
{
    partial class Frm_Add_Stocks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Stocks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.llbl_Add_Stocks = new System.Windows.Forms.LinkLabel();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbl_Unit_Value = new System.Windows.Forms.Label();
            this.cmb_Quantity = new System.Windows.Forms.ComboBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Qty = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Stock_Added = new System.Windows.Forms.Label();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.tb_Stock_Added = new System.Windows.Forms.TextBox();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Current_Stock = new System.Windows.Forms.Label();
            this.tb_Current_Stock = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.dtp_Date);
            this.panel1.Controls.Add(this.llbl_Add_Stocks);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 139);
            this.panel1.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1428, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(54, 51);
            this.btn_Logout.TabIndex = 12;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1218, 93);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(229, 32);
            this.dtp_Date.TabIndex = 3;
            // 
            // llbl_Add_Stocks
            // 
            this.llbl_Add_Stocks.AutoSize = true;
            this.llbl_Add_Stocks.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Add_Stocks.LinkColor = System.Drawing.Color.Black;
            this.llbl_Add_Stocks.Location = new System.Drawing.Point(615, 43);
            this.llbl_Add_Stocks.Name = "llbl_Add_Stocks";
            this.llbl_Add_Stocks.Size = new System.Drawing.Size(277, 55);
            this.llbl_Add_Stocks.TabIndex = 0;
            this.llbl_Add_Stocks.TabStop = true;
            this.llbl_Add_Stocks.Text = "Add Stocks";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbl_Unit_Value);
            this.gb1.Controls.Add(this.cmb_Quantity);
            this.gb1.Controls.Add(this.cmb_Product_Name);
            this.gb1.Controls.Add(this.cmb_Category);
            this.gb1.Controls.Add(this.lbl_Category);
            this.gb1.Controls.Add(this.lbl_Qty);
            this.gb1.Controls.Add(this.lbl_Product_Name);
            this.gb1.Location = new System.Drawing.Point(0, 145);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(1482, 130);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // lbl_Unit_Value
            // 
            this.lbl_Unit_Value.AutoSize = true;
            this.lbl_Unit_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Value.Location = new System.Drawing.Point(1411, 33);
            this.lbl_Unit_Value.Name = "lbl_Unit_Value";
            this.lbl_Unit_Value.Size = new System.Drawing.Size(59, 24);
            this.lbl_Unit_Value.TabIndex = 5;
            this.lbl_Unit_Value.Text = "Value";
            // 
            // cmb_Quantity
            // 
            this.cmb_Quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Quantity.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Quantity.FormattingEnabled = true;
            this.cmb_Quantity.Location = new System.Drawing.Point(1125, 29);
            this.cmb_Quantity.Name = "cmb_Quantity";
            this.cmb_Quantity.Size = new System.Drawing.Size(279, 33);
            this.cmb_Quantity.TabIndex = 4;
            this.cmb_Quantity.SelectedIndexChanged += new System.EventHandler(this.cmb_Quantity_SelectedIndexChanged);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(729, 31);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(279, 33);
            this.cmb_Product_Name.TabIndex = 4;
            this.cmb_Product_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Product_Name_SelectedIndexChanged);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(168, 31);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(270, 33);
            this.cmb_Category.TabIndex = 3;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(12, 29);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(124, 31);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.AutoSize = true;
            this.lbl_Qty.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qty.Location = new System.Drawing.Point(1042, 29);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Size = new System.Drawing.Size(58, 31);
            this.lbl_Qty.TabIndex = 0;
            this.lbl_Qty.Text = "Qty";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(506, 33);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(199, 31);
            this.lbl_Product_Name.TabIndex = 0;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Cyan;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Save.Location = new System.Drawing.Point(198, 706);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(225, 52);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.label1);
            this.gb2.Controls.Add(this.lbl_Stock_Added);
            this.gb2.Controls.Add(this.tb_Total_Price);
            this.gb2.Controls.Add(this.tb_Stock_Added);
            this.gb2.Controls.Add(this.lbl_Total_Price);
            this.gb2.Controls.Add(this.lbl_Current_Stock);
            this.gb2.Controls.Add(this.tb_Current_Stock);
            this.gb2.Location = new System.Drawing.Point(0, 281);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(1482, 192);
            this.gb2.TabIndex = 11;
            this.gb2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1664, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Added Quantity";
            // 
            // lbl_Stock_Added
            // 
            this.lbl_Stock_Added.AutoSize = true;
            this.lbl_Stock_Added.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Added.Location = new System.Drawing.Point(879, 33);
            this.lbl_Stock_Added.Name = "lbl_Stock_Added";
            this.lbl_Stock_Added.Size = new System.Drawing.Size(176, 31);
            this.lbl_Stock_Added.TabIndex = 0;
            this.lbl_Stock_Added.Text = "Stock Added";
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(777, 129);
            this.tb_Total_Price.MaxLength = 5;
            this.tb_Total_Price.Multiline = true;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(322, 31);
            this.tb_Total_Price.TabIndex = 7;
            this.tb_Total_Price.Text = "0";
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Total_Price_KeyPress);
            // 
            // tb_Stock_Added
            // 
            this.tb_Stock_Added.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_Added.Location = new System.Drawing.Point(1125, 33);
            this.tb_Stock_Added.MaxLength = 5;
            this.tb_Stock_Added.Multiline = true;
            this.tb_Stock_Added.Name = "tb_Stock_Added";
            this.tb_Stock_Added.Size = new System.Drawing.Size(322, 31);
            this.tb_Stock_Added.TabIndex = 6;
            this.tb_Stock_Added.TextChanged += new System.EventHandler(this.tb_Stock_Added_TextChanged);
            this.tb_Stock_Added.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Add_Quantity_KeyPress);
            this.tb_Stock_Added.Leave += new System.EventHandler(this.tb_Stock_Added_Leave);
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(522, 129);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(160, 31);
            this.lbl_Total_Price.TabIndex = 0;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Current_Stock
            // 
            this.lbl_Current_Stock.AutoSize = true;
            this.lbl_Current_Stock.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Current_Stock.Location = new System.Drawing.Point(36, 34);
            this.lbl_Current_Stock.Name = "lbl_Current_Stock";
            this.lbl_Current_Stock.Size = new System.Drawing.Size(193, 31);
            this.lbl_Current_Stock.TabIndex = 0;
            this.lbl_Current_Stock.Text = "Current Stock";
            // 
            // tb_Current_Stock
            // 
            this.tb_Current_Stock.Enabled = false;
            this.tb_Current_Stock.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Current_Stock.Location = new System.Drawing.Point(284, 34);
            this.tb_Current_Stock.MaxLength = 5;
            this.tb_Current_Stock.Multiline = true;
            this.tb_Current_Stock.Name = "tb_Current_Stock";
            this.tb_Current_Stock.Size = new System.Drawing.Size(342, 31);
            this.tb_Current_Stock.TabIndex = 5;
            this.tb_Current_Stock.Text = "0";
            this.tb_Current_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Current_Stock_KeyPress);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Cyan;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Refresh.Location = new System.Drawing.Point(1061, 706);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(246, 52);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_Add_Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 800);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Add_Stocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Add_Stocks";
            this.Load += new System.EventHandler(this.Frm_Add_Stocks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Add_Stocks;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label lbl_Current_Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Stock_Added;
        private System.Windows.Forms.TextBox tb_Stock_Added;
        private System.Windows.Forms.TextBox tb_Current_Stock;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Unit_Value;
        private System.Windows.Forms.ComboBox cmb_Quantity;
        private System.Windows.Forms.Label lbl_Qty;
        private System.Windows.Forms.Button btn_Logout;
    }
}