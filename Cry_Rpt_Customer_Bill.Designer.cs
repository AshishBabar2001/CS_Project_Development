namespace Farming_Management_System
{
    partial class Cry_Rpt_Customer_Bill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Customer_Bills = new System.Windows.Forms.LinkLabel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Customer_Id = new System.Windows.Forms.TextBox();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.cryst_Customer_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.llbl_Customer_Bills);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 138);
            this.panel1.TabIndex = 1;
            // 
            // llbl_Customer_Bills
            // 
            this.llbl_Customer_Bills.AutoSize = true;
            this.llbl_Customer_Bills.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Customer_Bills.Location = new System.Drawing.Point(568, 37);
            this.llbl_Customer_Bills.Name = "llbl_Customer_Bills";
            this.llbl_Customer_Bills.Size = new System.Drawing.Size(380, 62);
            this.llbl_Customer_Bills.TabIndex = 0;
            this.llbl_Customer_Bills.TabStop = true;
            this.llbl_Customer_Bills.Text = "Customer Bill";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Crimson;
            this.btn_Search.Location = new System.Drawing.Point(1028, 154);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 39);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Customer_Id
            // 
            this.tb_Customer_Id.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_Id.Location = new System.Drawing.Point(579, 154);
            this.tb_Customer_Id.Multiline = true;
            this.tb_Customer_Id.Name = "tb_Customer_Id";
            this.tb_Customer_Id.Size = new System.Drawing.Size(308, 39);
            this.tb_Customer_Id.TabIndex = 1;
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.Location = new System.Drawing.Point(312, 154);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(175, 30);
            this.lbl_Customer_Id.TabIndex = 0;
            this.lbl_Customer_Id.Text = "Customer_Id";
            // 
            // cryst_Customer_Bill
            // 
            this.cryst_Customer_Bill.ActiveViewIndex = -1;
            this.cryst_Customer_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryst_Customer_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryst_Customer_Bill.Location = new System.Drawing.Point(3, 210);
            this.cryst_Customer_Bill.Name = "cryst_Customer_Bill";
            this.cryst_Customer_Bill.Size = new System.Drawing.Size(1503, 511);
            this.cryst_Customer_Bill.TabIndex = 2;
            this.cryst_Customer_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Cry_Rpt_Customer_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 723);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cryst_Customer_Bill);
            this.Controls.Add(this.tb_Customer_Id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Customer_Id);
            this.Name = "Cry_Rpt_Customer_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cry_Rpt_Customer_Bill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Customer_Id;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryst_Customer_Bill;
        private System.Windows.Forms.LinkLabel llbl_Customer_Bills;


    }
}