﻿namespace Farming_Management_System
{
    partial class Frm_All_Employees_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_All_Employees_Details));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_View_All_Employees_Details = new System.Windows.Forms.LinkLabel();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_View_All_Employee_details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employee_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.llbl_View_All_Employees_Details);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1481, 128);
            this.panel1.TabIndex = 0;
            // 
            // llbl_View_All_Employees_Details
            // 
            this.llbl_View_All_Employees_Details.AutoSize = true;
            this.llbl_View_All_Employees_Details.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_View_All_Employees_Details.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.llbl_View_All_Employees_Details.Location = new System.Drawing.Point(409, 47);
            this.llbl_View_All_Employees_Details.Name = "llbl_View_All_Employees_Details";
            this.llbl_View_All_Employees_Details.Size = new System.Drawing.Size(617, 51);
            this.llbl_View_All_Employees_Details.TabIndex = 0;
            this.llbl_View_All_Employees_Details.TabStop = true;
            this.llbl_View_All_Employees_Details.Text = "View All Employees Details";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(595, 162);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(47, 34);
            this.lbl_Id.TabIndex = 1;
            this.lbl_Id.Text = "Id";
            // 
            // tb_Id
            // 
            this.tb_Id.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id.Location = new System.Drawing.Point(716, 165);
            this.tb_Id.Multiline = true;
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(350, 34);
            this.tb_Id.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(245, 740);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(228, 41);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_View_All_Employee_details
            // 
            this.dgv_View_All_Employee_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_All_Employee_details.Location = new System.Drawing.Point(1, 236);
            this.dgv_View_All_Employee_details.Name = "dgv_View_All_Employee_details";
            this.dgv_View_All_Employee_details.RowTemplate.Height = 24;
            this.dgv_View_All_Employee_details.Size = new System.Drawing.Size(1481, 483);
            this.dgv_View_All_Employee_details.TabIndex = 4;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1006, 740);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(228, 41);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn_LogOut.Image = ((System.Drawing.Image)(resources.GetObject("btn_LogOut.Image")));
            this.btn_LogOut.Location = new System.Drawing.Point(1424, 0);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(54, 51);
            this.btn_LogOut.TabIndex = 4;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // Frm_All_Employees_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 793);
            this.Controls.Add(this.dgv_View_All_Employee_details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_All_Employees_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_All_Employees_Details";
            this.Load += new System.EventHandler(this.Frm_All_Employees_Details_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_All_Employee_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_View_All_Employees_Details;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_View_All_Employee_details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_LogOut;
    }
}