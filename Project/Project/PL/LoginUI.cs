using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
         private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this program?", "Notice!", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TableManagement table = new TableManagement();
            // table.Show();
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.Show();
            this.Hide();
        }

      
    }
}
