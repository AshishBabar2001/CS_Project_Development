namespace Farming_Management_System
{
    partial class Rpt_Stock_Bill
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
            this.llbl_Stock_Bill = new System.Windows.Forms.LinkLabel();
            this.cryst_Stock_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.llbl_Stock_Bill);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1508, 138);
            this.panel1.TabIndex = 13;
            // 
            // llbl_Stock_Bill
            // 
            this.llbl_Stock_Bill.AutoSize = true;
            this.llbl_Stock_Bill.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_Stock_Bill.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.llbl_Stock_Bill.Location = new System.Drawing.Point(625, 35);
            this.llbl_Stock_Bill.Name = "llbl_Stock_Bill";
            this.llbl_Stock_Bill.Size = new System.Drawing.Size(286, 62);
            this.llbl_Stock_Bill.TabIndex = 0;
            this.llbl_Stock_Bill.TabStop = true;
            this.llbl_Stock_Bill.Text = "Stock Bill";
            // 
            // cryst_Stock_Bill
            // 
            this.cryst_Stock_Bill.ActiveViewIndex = -1;
            this.cryst_Stock_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryst_Stock_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryst_Stock_Bill.Location = new System.Drawing.Point(0, 144);
            this.cryst_Stock_Bill.Name = "cryst_Stock_Bill";
            this.cryst_Stock_Bill.Size = new System.Drawing.Size(1503, 578);
            this.cryst_Stock_Bill.TabIndex = 12;
            this.cryst_Stock_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Rpt_Stock_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cryst_Stock_Bill);
            this.Name = "Rpt_Stock_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rpt_Stock_Bill";
            this.Load += new System.EventHandler(this.Rpt_Stock_Bill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llbl_Stock_Bill;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryst_Stock_Bill;
    }
}