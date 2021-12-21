namespace Farming_Management_System
{
    partial class Frm_Add_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Add_Customer = new System.Windows.Forms.LinkLabel();
            this.gb_Customer_Info = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dgv_Add_Customer = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Purchase_Info = new System.Windows.Forms.GroupBox();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.cmb_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Unit_Qty = new System.Windows.Forms.ComboBox();
            this.lbl_Unit_Qty = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_Customer_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).BeginInit();
            this.gb_Purchase_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.llbl_Add_Customer);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 112);
            this.panel1.TabIndex = 0;
            // 
            // llbl_Add_Customer
            // 
            this.llbl_Add_Customer.AutoSize = true;
            this.llbl_Add_Customer.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Add_Customer.LinkColor = System.Drawing.Color.Black;
            this.llbl_Add_Customer.Location = new System.Drawing.Point(606, 26);
            this.llbl_Add_Customer.Name = "llbl_Add_Customer";
            this.llbl_Add_Customer.Size = new System.Drawing.Size(344, 55);
            this.llbl_Add_Customer.TabIndex = 0;
            this.llbl_Add_Customer.TabStop = true;
            this.llbl_Add_Customer.Text = "Add Customer";
            // 
            // gb_Customer_Info
            // 
            this.gb_Customer_Info.Controls.Add(this.dtp_Date);
            this.gb_Customer_Info.Controls.Add(this.tb_Mobile_No);
            this.gb_Customer_Info.Controls.Add(this.tb_Name);
            this.gb_Customer_Info.Controls.Add(this.tb_ID);
            this.gb_Customer_Info.Controls.Add(this.lbl_Name);
            this.gb_Customer_Info.Controls.Add(this.lbl_Mobile_No);
            this.gb_Customer_Info.Controls.Add(this.lbl_Date);
            this.gb_Customer_Info.Controls.Add(this.lbl_Id);
            this.gb_Customer_Info.Location = new System.Drawing.Point(0, 119);
            this.gb_Customer_Info.Name = "gb_Customer_Info";
            this.gb_Customer_Info.Size = new System.Drawing.Size(1482, 194);
            this.gb_Customer_Info.TabIndex = 1;
            this.gb_Customer_Info.TabStop = false;
            this.gb_Customer_Info.Text = "Customer Info";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1058, 44);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(391, 36);
            this.dtp_Date.TabIndex = 3;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(1058, 123);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(391, 37);
            this.tb_Mobile_No.TabIndex = 2;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(173, 123);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(391, 37);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(173, 48);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(391, 37);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(35, 131);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(81, 29);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(859, 131);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(138, 29);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(859, 50);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(69, 29);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(35, 56);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(46, 29);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "ID";
            // 
            // dgv_Add_Customer
            // 
            this.dgv_Add_Customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Add_Customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Add_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Add_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.P_Name,
            this.Unit_Qty,
            this.Price,
            this.Quantity,
            this.Total_Price});
            this.dgv_Add_Customer.Location = new System.Drawing.Point(0, 528);
            this.dgv_Add_Customer.Name = "dgv_Add_Customer";
            this.dgv_Add_Customer.RowTemplate.Height = 24;
            this.dgv_Add_Customer.Size = new System.Drawing.Size(1482, 156);
            this.dgv_Add_Customer.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // P_Name
            // 
            this.P_Name.HeaderText = "P_Name";
            this.P_Name.Name = "P_Name";
            // 
            // Unit_Qty
            // 
            this.Unit_Qty.HeaderText = "Unit_Qty";
            this.Unit_Qty.Name = "Unit_Qty";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Total_Price
            // 
            this.Total_Price.HeaderText = "Total_Price";
            this.Total_Price.Name = "Total_Price";
            // 
            // gb_Purchase_Info
            // 
            this.gb_Purchase_Info.Controls.Add(this.lbl_Unit);
            this.gb_Purchase_Info.Controls.Add(this.cmb_Name);
            this.gb_Purchase_Info.Controls.Add(this.cmb_Unit_Qty);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Unit_Qty);
            this.gb_Purchase_Info.Controls.Add(this.btn_Add);
            this.gb_Purchase_Info.Controls.Add(this.cmb_Category);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Price);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Product_Name);
            this.gb_Purchase_Info.Controls.Add(this.tb_Quantity);
            this.gb_Purchase_Info.Controls.Add(this.tb_Total_Price);
            this.gb_Purchase_Info.Controls.Add(this.tb_Price);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Total_Price);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Quantity);
            this.gb_Purchase_Info.Controls.Add(this.lbl_Category);
            this.gb_Purchase_Info.Location = new System.Drawing.Point(0, 319);
            this.gb_Purchase_Info.Name = "gb_Purchase_Info";
            this.gb_Purchase_Info.Size = new System.Drawing.Size(1482, 203);
            this.gb_Purchase_Info.TabIndex = 4;
            this.gb_Purchase_Info.TabStop = false;
            this.gb_Purchase_Info.Text = "Purchase Info";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(1354, 56);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(57, 25);
            this.lbl_Unit.TabIndex = 12;
            this.lbl_Unit.Text = "Unit";
            // 
            // cmb_Name
            // 
            this.cmb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Name.Enabled = false;
            this.cmb_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Name.FormattingEnabled = true;
            this.cmb_Name.Location = new System.Drawing.Point(629, 44);
            this.cmb_Name.Name = "cmb_Name";
            this.cmb_Name.Size = new System.Drawing.Size(239, 33);
            this.cmb_Name.TabIndex = 4;
            this.cmb_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Name_SelectedIndexChanged);
            // 
            // cmb_Unit_Qty
            // 
            this.cmb_Unit_Qty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Unit_Qty.Enabled = false;
            this.cmb_Unit_Qty.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit_Qty.FormattingEnabled = true;
            this.cmb_Unit_Qty.Location = new System.Drawing.Point(1107, 48);
            this.cmb_Unit_Qty.Name = "cmb_Unit_Qty";
            this.cmb_Unit_Qty.Size = new System.Drawing.Size(226, 33);
            this.cmb_Unit_Qty.TabIndex = 5;
            this.cmb_Unit_Qty.SelectedIndexChanged += new System.EventHandler(this.cmb_Unit_Qty_SelectedIndexChanged);
            // 
            // lbl_Unit_Qty
            // 
            this.lbl_Unit_Qty.AutoSize = true;
            this.lbl_Unit_Qty.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Qty.Location = new System.Drawing.Point(935, 48);
            this.lbl_Unit_Qty.Name = "lbl_Unit_Qty";
            this.lbl_Unit_Qty.Size = new System.Drawing.Size(117, 29);
            this.lbl_Unit_Qty.TabIndex = 11;
            this.lbl_Unit_Qty.Text = "Unit Qty";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Coral;
            this.btn_Add.Location = new System.Drawing.Point(1366, 116);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(104, 46);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(183, 40);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(239, 33);
            this.cmb_Category.TabIndex = 3;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(23, 133);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(77, 29);
            this.lbl_Price.TabIndex = 0;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.Location = new System.Drawing.Point(483, 44);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(81, 29);
            this.lbl_Product_Name.TabIndex = 0;
            this.lbl_Product_Name.Text = "Name";
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(629, 133);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Multiline = true;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(241, 33);
            this.tb_Quantity.TabIndex = 7;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Quantity_KeyPress);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(1107, 133);
            this.tb_Total_Price.MaxLength = 5;
            this.tb_Total_Price.Multiline = true;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(226, 33);
            this.tb_Total_Price.TabIndex = 8;
            this.tb_Total_Price.Text = "0";
            this.tb_Total_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Total_Price_KeyPress);
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(183, 133);
            this.tb_Price.MaxLength = 5;
            this.tb_Price.Multiline = true;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(239, 33);
            this.tb_Price.TabIndex = 6;
            this.tb_Price.Text = "0";
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Price_KeyPress);
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Price.Location = new System.Drawing.Point(935, 133);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(149, 29);
            this.lbl_Total_Price.TabIndex = 0;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(483, 133);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(117, 29);
            this.lbl_Quantity.TabIndex = 0;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(23, 40);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(115, 29);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(321, 778);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(145, 47);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save Details";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Refresh.Location = new System.Drawing.Point(982, 778);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(202, 47);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Bill
            // 
            this.tb_Bill.Enabled = false;
            this.tb_Bill.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bill.Location = new System.Drawing.Point(196, 705);
            this.tb_Bill.MaxLength = 5;
            this.tb_Bill.Multiline = true;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(226, 33);
            this.tb_Bill.TabIndex = 10;
            this.tb_Bill.Text = "0";
            this.tb_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Bill_KeyPress);
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill.Location = new System.Drawing.Point(79, 705);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(63, 29);
            this.lbl_Bill.TabIndex = 10;
            this.lbl_Bill.Text = "Bill";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Final_Bill.Location = new System.Drawing.Point(1135, 705);
            this.tb_Final_Bill.MaxLength = 5;
            this.tb_Final_Bill.Multiline = true;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(226, 33);
            this.tb_Final_Bill.TabIndex = 11;
            this.tb_Final_Bill.Text = "0";
            this.tb_Final_Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Final_Bill_KeyPress);
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Final_Bill.Location = new System.Drawing.Point(963, 705);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(140, 29);
            this.lbl_Final_Bill.TabIndex = 12;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // tb_GST
            // 
            this.tb_GST.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GST.Location = new System.Drawing.Point(709, 705);
            this.tb_GST.MaxLength = 3;
            this.tb_GST.Multiline = true;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(105, 33);
            this.tb_GST.TabIndex = 0;
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GST.Location = new System.Drawing.Point(567, 705);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(64, 29);
            this.lbl_GST.TabIndex = 14;
            this.lbl_GST.Text = "GST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(820, 709);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "%";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_Logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_Logout.Image")));
            this.btn_Logout.Location = new System.Drawing.Point(1425, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(54, 51);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Frm_Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 837);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_GST);
            this.Controls.Add(this.lbl_GST);
            this.Controls.Add(this.tb_Final_Bill);
            this.Controls.Add(this.lbl_Final_Bill);
            this.Controls.Add(this.tb_Bill);
            this.Controls.Add(this.lbl_Bill);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Purchase_Info);
            this.Controls.Add(this.dgv_Add_Customer);
            this.Controls.Add(this.gb_Customer_Info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Add_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.Frm_Add_Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Customer_Info.ResumeLayout(false);
            this.gb_Customer_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Add_Customer)).EndInit();
            this.gb_Purchase_Info.ResumeLayout(false);
            this.gb_Purchase_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Add_Customer;
        private System.Windows.Forms.GroupBox gb_Customer_Info;
        private System.Windows.Forms.DataGridView dgv_Add_Customer;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox gb_Purchase_Info;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Name;
        private System.Windows.Forms.ComboBox cmb_Unit_Qty;
        private System.Windows.Forms.Label lbl_Unit_Qty;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price;
        private System.Windows.Forms.Button btn_Logout;
    }
}