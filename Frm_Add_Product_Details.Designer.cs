namespace Farming_Management_System
{
    partial class Frm_Add_Product_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Product_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Add_Product_Details = new System.Windows.Forms.LinkLabel();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.cmb_Unit = new System.Windows.Forms.ComboBox();
            this.lbl_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.Dgv_Show_Added_Details = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Save_Details = new System.Windows.Forms.Button();
            this.btn_Referesh_Details = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Show_Added_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.llbl_Add_Product_Details);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 131);
            this.panel1.TabIndex = 0;
            // 
            // llbl_Add_Product_Details
            // 
            this.llbl_Add_Product_Details.AutoSize = true;
            this.llbl_Add_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Add_Product_Details.ForeColor = System.Drawing.Color.Coral;
            this.llbl_Add_Product_Details.LinkColor = System.Drawing.Color.Black;
            this.llbl_Add_Product_Details.Location = new System.Drawing.Point(525, 32);
            this.llbl_Add_Product_Details.Name = "llbl_Add_Product_Details";
            this.llbl_Add_Product_Details.Size = new System.Drawing.Size(493, 55);
            this.llbl_Add_Product_Details.TabIndex = 0;
            this.llbl_Add_Product_Details.TabStop = true;
            this.llbl_Add_Product_Details.Text = "Add Product Details";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbl_Name);
            this.gb1.Controls.Add(this.cmb_Category);
            this.gb1.Controls.Add(this.tb_Name);
            this.gb1.Controls.Add(this.tb_ID);
            this.gb1.Controls.Add(this.dtp_Date);
            this.gb1.Controls.Add(this.lbl_Category);
            this.gb1.Controls.Add(this.lbl_Date);
            this.gb1.Controls.Add(this.lbl_ID);
            this.gb1.Location = new System.Drawing.Point(-1, 138);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(1479, 176);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(888, 125);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(88, 31);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(198, 124);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(371, 37);
            this.cmb_Category.TabIndex = 2;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(1061, 117);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(371, 39);
            this.tb_Name.TabIndex = 4;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(198, 28);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(371, 39);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CalendarFont = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1061, 25);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(371, 36);
            this.dtp_Date.TabIndex = 3;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(49, 125);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(124, 31);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(888, 29);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(75, 31);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(49, 29);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(50, 31);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btn_Add);
            this.gb2.Controls.Add(this.lbl_Unit);
            this.gb2.Controls.Add(this.lbl_Sales_Price);
            this.gb2.Controls.Add(this.cmb_Unit);
            this.gb2.Controls.Add(this.lbl_Purchase_Price);
            this.gb2.Controls.Add(this.lbl_Quantity);
            this.gb2.Controls.Add(this.tb_Sales_Price);
            this.gb2.Controls.Add(this.tb_Purchase_Price);
            this.gb2.Controls.Add(this.tb_Quantity);
            this.gb2.Location = new System.Drawing.Point(-1, 320);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(1479, 158);
            this.gb2.TabIndex = 2;
            this.gb2.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.BlueViolet;
            this.btn_Add.Location = new System.Drawing.Point(1333, 62);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 52);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(733, 41);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(72, 31);
            this.lbl_Unit.TabIndex = 0;
            this.lbl_Unit.Text = "Unit";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.Location = new System.Drawing.Point(733, 102);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(154, 31);
            this.lbl_Sales_Price.TabIndex = 0;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // cmb_Unit
            // 
            this.cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unit.Font = new System.Drawing.Font("Modern No. 20", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit.FormattingEnabled = true;
            this.cmb_Unit.Location = new System.Drawing.Point(924, 31);
            this.cmb_Unit.Name = "cmb_Unit";
            this.cmb_Unit.Size = new System.Drawing.Size(371, 32);
            this.cmb_Unit.TabIndex = 6;
            this.cmb_Unit.SelectedIndexChanged += new System.EventHandler(this.cmb_Unit_SelectedIndexChanged);
            // 
            // lbl_Purchase_Price
            // 
            this.lbl_Purchase_Price.AutoSize = true;
            this.lbl_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Price.Location = new System.Drawing.Point(23, 103);
            this.lbl_Purchase_Price.Name = "lbl_Purchase_Price";
            this.lbl_Purchase_Price.Size = new System.Drawing.Size(205, 31);
            this.lbl_Purchase_Price.TabIndex = 0;
            this.lbl_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(23, 43);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(125, 31);
            this.lbl_Quantity.TabIndex = 0;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(924, 102);
            this.tb_Sales_Price.MaxLength = 5;
            this.tb_Sales_Price.Multiline = true;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(371, 32);
            this.tb_Sales_Price.TabIndex = 8;
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Sales_Price_KeyPress);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(255, 103);
            this.tb_Purchase_Price.MaxLength = 5;
            this.tb_Purchase_Price.Multiline = true;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(346, 32);
            this.tb_Purchase_Price.TabIndex = 7;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Purchase_Price_KeyPress);
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(255, 41);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Multiline = true;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(346, 32);
            this.tb_Quantity.TabIndex = 5;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quantity_KeyPress);
            // 
            // Dgv_Show_Added_Details
            // 
            this.Dgv_Show_Added_Details.AllowUserToAddRows = false;
            this.Dgv_Show_Added_Details.AllowUserToDeleteRows = false;
            this.Dgv_Show_Added_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Show_Added_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Show_Added_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Show_Added_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.Unit,
            this.Purchase_Price,
            this.Sales_Price});
            this.Dgv_Show_Added_Details.Location = new System.Drawing.Point(12, 484);
            this.Dgv_Show_Added_Details.Name = "Dgv_Show_Added_Details";
            this.Dgv_Show_Added_Details.RowTemplate.Height = 24;
            this.Dgv_Show_Added_Details.Size = new System.Drawing.Size(1469, 223);
            this.Dgv_Show_Added_Details.TabIndex = 0;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.HeaderText = "Purchase_Price";
            this.Purchase_Price.Name = "Purchase_Price";
            // 
            // Sales_Price
            // 
            this.Sales_Price.HeaderText = "Sales_Price";
            this.Sales_Price.Name = "Sales_Price";
            // 
            // btn_Save_Details
            // 
            this.btn_Save_Details.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save_Details.ForeColor = System.Drawing.Color.Brown;
            this.btn_Save_Details.Location = new System.Drawing.Point(282, 736);
            this.btn_Save_Details.Name = "btn_Save_Details";
            this.btn_Save_Details.Size = new System.Drawing.Size(235, 39);
            this.btn_Save_Details.TabIndex = 10;
            this.btn_Save_Details.Text = "Save Details";
            this.btn_Save_Details.UseVisualStyleBackColor = true;
            this.btn_Save_Details.Click += new System.EventHandler(this.btn_Save_Details_Click);
            // 
            // btn_Referesh_Details
            // 
            this.btn_Referesh_Details.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Referesh_Details.ForeColor = System.Drawing.Color.Brown;
            this.btn_Referesh_Details.Location = new System.Drawing.Point(893, 736);
            this.btn_Referesh_Details.Name = "btn_Referesh_Details";
            this.btn_Referesh_Details.Size = new System.Drawing.Size(235, 39);
            this.btn_Referesh_Details.TabIndex = 11;
            this.btn_Referesh_Details.Text = "Referesh Details";
            this.btn_Referesh_Details.UseVisualStyleBackColor = true;
            this.btn_Referesh_Details.Click += new System.EventHandler(this.btn_Referesh_Details_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(1422, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(54, 51);
            this.btn_LogOut.TabIndex = 12;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Frm_Add_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 800);
            this.Controls.Add(this.btn_Referesh_Details);
            this.Controls.Add(this.btn_Save_Details);
            this.Controls.Add(this.Dgv_Show_Added_Details);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Add_Product_Details";
            this.Load += new System.EventHandler(this.Frm_Add_Product_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Show_Added_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Add_Product_Details;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Label lbl_Purchase_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView Dgv_Show_Added_Details;
        private System.Windows.Forms.Button btn_Save_Details;
        private System.Windows.Forms.Button btn_Referesh_Details;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.ComboBox cmb_Unit;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales_Price;
        private System.Windows.Forms.Button btn_LogOut;
    }
}