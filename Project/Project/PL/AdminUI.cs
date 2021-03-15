using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.PL;
namespace Project
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            this.WindowState= FormWindowState.Maximized;
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        
        private void pbxMenu_Click(object sender, EventArgs e)
        {
            
            pnlLeft.Width = (pnlLeft.Width == 183) ? 45 : 183;
           
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            pnlAddForm.Controls.Clear();
            lblTittle.Text = "Thức Ăn";
            frmFood frmFood = new frmFood();
            frmFood.TopLevel = false;
            pnlAddForm.Controls.Add(frmFood);
            
            frmFood.Dock = DockStyle.Fill;
            frmFood.Show();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {   pnlAddForm.Controls.Clear();
            lblTittle.Text = "Doanh Thu";
            frmRevenue frmRevenue = new frmRevenue();
            frmRevenue.TopLevel = false;
            pnlAddForm.Controls.Add(frmRevenue);
           
            frmRevenue.Dock = DockStyle.Fill;
            frmRevenue.Show();
            
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            pnlAddForm.Controls.Clear();
            lblTittle.Text = "Danh Mục";
            frmCategory category = new frmCategory();
            category.TopLevel = false;
            pnlAddForm.Controls.Add(category);           
            category.Dock = DockStyle.Fill;
            category.Show();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            pnlAddForm.Controls.Clear();
            lblTittle.Text = "Bàn Ăn";
            frmTable table = new frmTable();
            table.TopLevel = false;
            pnlAddForm.Controls.Add(table);           
            table.Dock = DockStyle.Fill;
            table.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            pnlAddForm.Controls.Clear();
            lblTittle.Text = "Tài Khoản Nhân Viên";
            frmAccount account = new frmAccount();
            account.TopLevel = false;
            pnlAddForm.Controls.Add(account);       
            account.Dock = DockStyle.Fill;
            account.Show();
        }

      
    }
}
