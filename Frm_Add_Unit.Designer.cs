namespace Farming_Management_System
{
    partial class Frm_Add_Unit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Add_Unit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Add_Unit = new System.Windows.Forms.LinkLabel();
            this.lbl_Unit_ID = new System.Windows.Forms.Label();
            this.lbl_Unit_Name = new System.Windows.Forms.Label();
            this.tb_Unit_ID = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.llbl_Add_Unit);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 152);
            this.panel1.TabIndex = 0;
            // 
            // llbl_Add_Unit
            // 
            this.llbl_Add_Unit.AutoSize = true;
            this.llbl_Add_Unit.Font = new System.Drawing.Font("Modern No. 20", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Add_Unit.LinkColor = System.Drawing.Color.Black;
            this.llbl_Add_Unit.Location = new System.Drawing.Point(305, 54);
            this.llbl_Add_Unit.Name = "llbl_Add_Unit";
            this.llbl_Add_Unit.Size = new System.Drawing.Size(239, 55);
            this.llbl_Add_Unit.TabIndex = 0;
            this.llbl_Add_Unit.TabStop = true;
            this.llbl_Add_Unit.Text = "Add Unit";
            // 
            // lbl_Unit_ID
            // 
            this.lbl_Unit_ID.AutoSize = true;
            this.lbl_Unit_ID.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_ID.Location = new System.Drawing.Point(140, 261);
            this.lbl_Unit_ID.Name = "lbl_Unit_ID";
            this.lbl_Unit_ID.Size = new System.Drawing.Size(133, 35);
            this.lbl_Unit_ID.TabIndex = 1;
            this.lbl_Unit_ID.Text = "Unit ID";
            // 
            // lbl_Unit_Name
            // 
            this.lbl_Unit_Name.AutoSize = true;
            this.lbl_Unit_Name.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Name.Location = new System.Drawing.Point(123, 407);
            this.lbl_Unit_Name.Name = "lbl_Unit_Name";
            this.lbl_Unit_Name.Size = new System.Drawing.Size(176, 35);
            this.lbl_Unit_Name.TabIndex = 1;
            this.lbl_Unit_Name.Text = "Unit Name";
            // 
            // tb_Unit_ID
            // 
            this.tb_Unit_ID.Enabled = false;
            this.tb_Unit_ID.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit_ID.Location = new System.Drawing.Point(385, 261);
            this.tb_Unit_ID.MaxLength = 4;
            this.tb_Unit_ID.Multiline = true;
            this.tb_Unit_ID.Name = "tb_Unit_ID";
            this.tb_Unit_ID.Size = new System.Drawing.Size(396, 35);
            this.tb_Unit_ID.TabIndex = 1;
            this.tb_Unit_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Unit_ID_KeyPress);
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Save.Location = new System.Drawing.Point(339, 586);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(188, 60);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(385, 407);
            this.tb_Name.MaxLength = 20;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(396, 35);
            this.tb_Name.TabIndex = 2;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(802, 3);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(54, 51);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Frm_Add_Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 715);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Unit_ID);
            this.Controls.Add(this.lbl_Unit_Name);
            this.Controls.Add(this.lbl_Unit_ID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Add_Unit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Unit";
            this.Load += new System.EventHandler(this.Add_Unit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Add_Unit;
        private System.Windows.Forms.Label lbl_Unit_ID;
        private System.Windows.Forms.Label lbl_Unit_Name;
        private System.Windows.Forms.TextBox tb_Unit_ID;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_LogOut;
    }
}