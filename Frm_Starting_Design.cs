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
    public partial class Frm_Starting_Login_Form : Form
    {
        public Frm_Starting_Login_Form()
        {
            InitializeComponent();
        }

        private void Frm_Starting_Login_Form_Click(object sender, EventArgs e)
        {
            Frm_Login Obj = new Frm_Login();
            Obj.Show();
        }
    }
}
