namespace Farming_Management_System
{
    partial class Frm_Search_And_Update_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Search_And_Update_Employees));
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.gb_Employee_Id = new System.Windows.Forms.GroupBox();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.llbl_Search_Employee = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.gb_Personal_Details = new System.Windows.Forms.GroupBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Date_Of_Birth = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmb_Post = new System.Windows.Forms.ComboBox();
            this.gb_Other_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.lbl_Adhaar_No = new System.Windows.Forms.Label();
            this.tb_Experience = new System.Windows.Forms.TextBox();
            this.tb_PAN_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.tb_Adhaar_No = new System.Windows.Forms.TextBox();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.lbl_Experience = new System.Windows.Forms.Label();
            this.lbl_PAN_No = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.gb_Employee_Id.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_Personal_Details.SuspendLayout();
            this.gb_Other_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(210, 30);
            this.tb_ID.MaxLength = 5;
            this.tb_ID.Multiline = true;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(335, 31);
            this.tb_ID.TabIndex = 1;
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(914, 27);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(64, 26);
            this.lbl_Date.TabIndex = 0;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(58, 32);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(42, 26);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // gb_Employee_Id
            // 
            this.gb_Employee_Id.Controls.Add(this.dtp_Date);
            this.gb_Employee_Id.Controls.Add(this.tb_ID);
            this.gb_Employee_Id.Controls.Add(this.lbl_Date);
            this.gb_Employee_Id.Controls.Add(this.lbl_ID);
            this.gb_Employee_Id.Location = new System.Drawing.Point(2, 134);
            this.gb_Employee_Id.Name = "gb_Employee_Id";
            this.gb_Employee_Id.Size = new System.Drawing.Size(1479, 86);
            this.gb_Employee_Id.TabIndex = 7;
            this.gb_Employee_Id.TabStop = false;
            this.gb_Employee_Id.Text = "Employee_Id";
            // 
            // dtp_Date
            // 
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Location = new System.Drawing.Point(1094, 22);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(335, 32);
            this.dtp_Date.TabIndex = 2;
            // 
            // llbl_Search_Employee
            // 
            this.llbl_Search_Employee.AutoSize = true;
            this.llbl_Search_Employee.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Search_Employee.Location = new System.Drawing.Point(606, 44);
            this.llbl_Search_Employee.Name = "llbl_Search_Employee";
            this.llbl_Search_Employee.Size = new System.Drawing.Size(334, 45);
            this.llbl_Search_Employee.TabIndex = 0;
            this.llbl_Search_Employee.TabStop = true;
            this.llbl_Search_Employee.Text = "Search Employee";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.llbl_Search_Employee);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1479, 127);
            this.panel1.TabIndex = 6;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(36, 122);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(125, 26);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Enabled = false;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(210, 117);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(335, 31);
            this.tb_Mobile_No.TabIndex = 6;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mobile_No_KeyPress);
            // 
            // gb_Personal_Details
            // 
            this.gb_Personal_Details.Controls.Add(this.lbl_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.tb_Mobile_No);
            this.gb_Personal_Details.Controls.Add(this.dtp_Date_Of_Birth);
            this.gb_Personal_Details.Controls.Add(this.rb_Female);
            this.gb_Personal_Details.Controls.Add(this.rb_Male);
            this.gb_Personal_Details.Controls.Add(this.lbl_Name);
            this.gb_Personal_Details.Controls.Add(this.lbl_Gender);
            this.gb_Personal_Details.Controls.Add(this.lbl_Date_Of_Birth);
            this.gb_Personal_Details.Controls.Add(this.tb_Name);
            this.gb_Personal_Details.Location = new System.Drawing.Point(2, 226);
            this.gb_Personal_Details.Name = "gb_Personal_Details";
            this.gb_Personal_Details.Size = new System.Drawing.Size(1479, 164);
            this.gb_Personal_Details.TabIndex = 8;
            this.gb_Personal_Details.TabStop = false;
            this.gb_Personal_Details.Text = "Personal_Details";
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Enabled = false;
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(1120, 114);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(309, 32);
            this.dtp_Date_Of_Birth.TabIndex = 7;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(1254, 43);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(95, 28);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(1114, 43);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(76, 29);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(49, 40);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(74, 26);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(914, 45);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(90, 26);
            this.lbl_Gender.TabIndex = 0;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Date_Of_Birth
            // 
            this.lbl_Date_Of_Birth.AutoSize = true;
            this.lbl_Date_Of_Birth.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date_Of_Birth.Location = new System.Drawing.Point(914, 122);
            this.lbl_Date_Of_Birth.Name = "lbl_Date_Of_Birth";
            this.lbl_Date_Of_Birth.Size = new System.Drawing.Size(168, 26);
            this.lbl_Date_Of_Birth.TabIndex = 0;
            this.lbl_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(210, 35);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(335, 31);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // cmb_Post
            // 
            this.cmb_Post.Enabled = false;
            this.cmb_Post.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Post.FormattingEnabled = true;
            this.cmb_Post.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Salesman"});
            this.cmb_Post.Location = new System.Drawing.Point(1094, 173);
            this.cmb_Post.Name = "cmb_Post";
            this.cmb_Post.Size = new System.Drawing.Size(335, 33);
            this.cmb_Post.TabIndex = 13;
            // 
            // gb_Other_Details
            // 
            this.gb_Other_Details.Controls.Add(this.cmb_Post);
            this.gb_Other_Details.Controls.Add(this.lbl_Address);
            this.gb_Other_Details.Controls.Add(this.lbl_Salary);
            this.gb_Other_Details.Controls.Add(this.lbl_Qualification);
            this.gb_Other_Details.Controls.Add(this.lbl_Adhaar_No);
            this.gb_Other_Details.Controls.Add(this.tb_Experience);
            this.gb_Other_Details.Controls.Add(this.tb_PAN_No);
            this.gb_Other_Details.Controls.Add(this.tb_Address);
            this.gb_Other_Details.Controls.Add(this.tb_Salary);
            this.gb_Other_Details.Controls.Add(this.tb_Qualification);
            this.gb_Other_Details.Controls.Add(this.tb_Adhaar_No);
            this.gb_Other_Details.Controls.Add(this.lbl_Post);
            this.gb_Other_Details.Controls.Add(this.lbl_Experience);
            this.gb_Other_Details.Controls.Add(this.lbl_PAN_No);
            this.gb_Other_Details.Location = new System.Drawing.Point(2, 396);
            this.gb_Other_Details.Name = "gb_Other_Details";
            this.gb_Other_Details.Size = new System.Drawing.Size(1479, 330);
            this.gb_Other_Details.TabIndex = 9;
            this.gb_Other_Details.TabStop = false;
            this.gb_Other_Details.Text = "Other_Details";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(58, 241);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(98, 26);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(58, 175);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(84, 26);
            this.lbl_Salary.TabIndex = 0;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.Location = new System.Drawing.Point(20, 113);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(161, 26);
            this.lbl_Qualification.TabIndex = 0;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // lbl_Adhaar_No
            // 
            this.lbl_Adhaar_No.AutoSize = true;
            this.lbl_Adhaar_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhaar_No.Location = new System.Drawing.Point(29, 42);
            this.lbl_Adhaar_No.Name = "lbl_Adhaar_No";
            this.lbl_Adhaar_No.Size = new System.Drawing.Size(132, 26);
            this.lbl_Adhaar_No.TabIndex = 0;
            this.lbl_Adhaar_No.Text = "Adhaar No";
            // 
            // tb_Experience
            // 
            this.tb_Experience.Enabled = false;
            this.tb_Experience.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Experience.Location = new System.Drawing.Point(1094, 111);
            this.tb_Experience.MaxLength = 10;
            this.tb_Experience.Multiline = true;
            this.tb_Experience.Name = "tb_Experience";
            this.tb_Experience.Size = new System.Drawing.Size(335, 31);
            this.tb_Experience.TabIndex = 11;
            this.tb_Experience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Experience_KeyPress);
            // 
            // tb_PAN_No
            // 
            this.tb_PAN_No.Enabled = false;
            this.tb_PAN_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PAN_No.Location = new System.Drawing.Point(1094, 37);
            this.tb_PAN_No.MaxLength = 10;
            this.tb_PAN_No.Multiline = true;
            this.tb_PAN_No.Name = "tb_PAN_No";
            this.tb_PAN_No.Size = new System.Drawing.Size(335, 31);
            this.tb_PAN_No.TabIndex = 9;
            this.tb_PAN_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PAN_No_KeyPress);
            // 
            // tb_Address
            // 
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(210, 236);
            this.tb_Address.MaxLength = 50;
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(335, 77);
            this.tb_Address.TabIndex = 14;
            this.tb_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Address_KeyPress);
            // 
            // tb_Salary
            // 
            this.tb_Salary.Enabled = false;
            this.tb_Salary.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(210, 173);
            this.tb_Salary.MaxLength = 10;
            this.tb_Salary.Multiline = true;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(335, 31);
            this.tb_Salary.TabIndex = 12;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Salary_KeyPress);
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Enabled = false;
            this.tb_Qualification.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(210, 108);
            this.tb_Qualification.MaxLength = 10;
            this.tb_Qualification.Multiline = true;
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(335, 31);
            this.tb_Qualification.TabIndex = 10;
            this.tb_Qualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Qualification_KeyPress);
            // 
            // tb_Adhaar_No
            // 
            this.tb_Adhaar_No.Enabled = false;
            this.tb_Adhaar_No.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhaar_No.Location = new System.Drawing.Point(210, 40);
            this.tb_Adhaar_No.MaxLength = 12;
            this.tb_Adhaar_No.Multiline = true;
            this.tb_Adhaar_No.Name = "tb_Adhaar_No";
            this.tb_Adhaar_No.Size = new System.Drawing.Size(335, 31);
            this.tb_Adhaar_No.TabIndex = 8;
            this.tb_Adhaar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Adhaar_No_KeyPress);
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Post.Location = new System.Drawing.Point(924, 175);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(60, 26);
            this.lbl_Post.TabIndex = 0;
            this.lbl_Post.Text = "Post";
            // 
            // lbl_Experience
            // 
            this.lbl_Experience.AutoSize = true;
            this.lbl_Experience.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Experience.Location = new System.Drawing.Point(924, 113);
            this.lbl_Experience.Name = "lbl_Experience";
            this.lbl_Experience.Size = new System.Drawing.Size(134, 26);
            this.lbl_Experience.TabIndex = 0;
            this.lbl_Experience.Text = "Experience";
            // 
            // lbl_PAN_No
            // 
            this.lbl_PAN_No.AutoSize = true;
            this.lbl_PAN_No.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PAN_No.Location = new System.Drawing.Point(924, 42);
            this.lbl_PAN_No.Name = "lbl_PAN_No";
            this.lbl_PAN_No.Size = new System.Drawing.Size(102, 26);
            this.lbl_PAN_No.TabIndex = 0;
            this.lbl_PAN_No.Text = "PAN No";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Search.Location = new System.Drawing.Point(274, 741);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(207, 49);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Update.Location = new System.Drawing.Point(1038, 741);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(207, 49);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(1425, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(54, 51);
            this.btn_LogOut.TabIndex = 17;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click_1);
            // 
            // Frm_Search_And_Update_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 814);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.gb_Other_Details);
            this.Controls.Add(this.gb_Personal_Details);
            this.Controls.Add(this.gb_Employee_Id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Search_And_Update_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Search_And_Update_Employees";
            this.gb_Employee_Id.ResumeLayout(false);
            this.gb_Employee_Id.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_Personal_Details.ResumeLayout(false);
            this.gb_Personal_Details.PerformLayout();
            this.gb_Other_Details.ResumeLayout(false);
            this.gb_Other_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.GroupBox gb_Employee_Id;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.LinkLabel llbl_Search_Employee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.GroupBox gb_Personal_Details;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Date_Of_Birth;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmb_Post;
        private System.Windows.Forms.GroupBox gb_Other_Details;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Label lbl_Adhaar_No;
        private System.Windows.Forms.TextBox tb_Experience;
        private System.Windows.Forms.TextBox tb_PAN_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.TextBox tb_Adhaar_No;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.Label lbl_Experience;
        private System.Windows.Forms.Label lbl_PAN_No;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_LogOut;
    }
}