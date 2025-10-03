using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMaskedPassword
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cbxShowPassword_Click(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }

        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();

            frmAbout.ShowDialog();
        }
    }
}
