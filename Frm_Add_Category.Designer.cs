namespace Farming_Management_System
{
    partial class Frm_Add_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Category));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Add_Categories = new System.Windows.Forms.LinkLabel();
            this.lbl_Category_ID = new System.Windows.Forms.Label();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.tb_Category_ID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.llbl_Add_Categories);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 136);
            this.panel1.TabIndex = 0;
            // 
            // llbl_Add_Categories
            // 
            this.llbl_Add_Categories.AutoSize = true;
            this.llbl_Add_Categories.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Add_Categories.ForeColor = System.Drawing.Color.Coral;
            this.llbl_Add_Categories.LinkColor = System.Drawing.Color.Black;
            this.llbl_Add_Categories.Location = new System.Drawing.Point(238, 37);
            this.llbl_Add_Categories.Name = "llbl_Add_Categories";
            this.llbl_Add_Categories.Size = new System.Drawing.Size(365, 55);
            this.llbl_Add_Categories.TabIndex = 0;
            this.llbl_Add_Categories.TabStop = true;
            this.llbl_Add_Categories.Text = "Add Categories";
            this.llbl_Add_Categories.VisitedLinkColor = System.Drawing.Color.Coral;
            // 
            // lbl_Category_ID
            // 
            this.lbl_Category_ID.AutoSize = true;
            this.lbl_Category_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_ID.Location = new System.Drawing.Point(96, 237);
            this.lbl_Category_ID.Name = "lbl_Category_ID";
            this.lbl_Category_ID.Size = new System.Drawing.Size(191, 35);
            this.lbl_Category_ID.TabIndex = 1;
            this.lbl_Category_ID.Text = "Category ID";
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.Location = new System.Drawing.Point(96, 380);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(234, 35);
            this.lbl_Category_Name.TabIndex = 1;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // tb_Category_ID
            // 
            this.tb_Category_ID.Enabled = false;
            this.tb_Category_ID.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_ID.Location = new System.Drawing.Point(386, 237);
            this.tb_Category_ID.MaxLength = 5;
            this.tb_Category_ID.Multiline = true;
            this.tb_Category_ID.Name = "tb_Category_ID";
            this.tb_Category_ID.Size = new System.Drawing.Size(381, 35);
            this.tb_Category_ID.TabIndex = 1;
            this.tb_Category_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_ID_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Green;
            this.btn_Save.Location = new System.Drawing.Point(262, 537);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(276, 58);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(386, 380);
            this.tb_Category_Name.MaxLength = 20;
            this.tb_Category_Name.Multiline = true;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(381, 35);
            this.tb_Category_Name.TabIndex = 2;
            this.tb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Category_Name_KeyPress);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(760, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(54, 51);
            this.btn_LogOut.TabIndex = 7;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Frm_Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 675);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Category_Name);
            this.Controls.Add(this.tb_Category_ID);
            this.Controls.Add(this.lbl_Category_Name);
            this.Controls.Add(this.lbl_Category_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Add_Category";
            this.Load += new System.EventHandler(this.Frm_Add_Category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Add_Categories;
        private System.Windows.Forms.Label lbl_Category_ID;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.TextBox tb_Category_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Category_Name;
        private System.Windows.Forms.Button btn_LogOut;
    }
}