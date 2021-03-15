using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project.PL
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            //set status for button
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReset.Enabled = false;

        }

        private void frmCategory_Click(object sender, EventArgs e)
        {

        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            loadData();
        }

        //load data for combobobox and datagridview
        public void loadData()
        {
            //combobox
            cbbFoodCategory.DisplayMember = "name";
            cbbFoodCategory.ValueMember = "id";
            cbbFoodCategory.DataSource = DAL.DAO.GetAllFoodCategory();
            cbbFoodCategory.SelectedIndex = 0;
            //datagridView
            dataGridView1.DataSource = DAL.DAO.GetAllFoodCategory();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int foodCateID = Convert.ToInt32(cbbFoodCategory.SelectedValue);
            dataGridView1.DataSource = DAL.DAO.GetFoodCategoryById(foodCateID);
           
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //set status for button
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReset.Enabled = true;

            //get Value
            string foodCateID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            //set value for textbox
            tbIdVirtual.Text = foodCateID;
            tbFoodCategory.Text = name;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string foodCateName = tbFoodCategory.Text;
            int foodCateID =Convert.ToInt32(tbIdVirtual.Text); 

            if (DAL.DAO.updateFoodCategory(foodCateID, foodCateName))
            {
                MessageBox.Show("Update successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllFoodCategory();
            }
            else
            {
                MessageBox.Show("Update fails !");
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int foodCateID = Convert.ToInt32(tbIdVirtual.Text);
            if (DAL.DAO.deleteFoodCategory(foodCateID))
            {
                MessageBox.Show("Delete successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllFoodCategory();
            }
            else
            {
                MessageBox.Show("Delete fails !");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string foodCateName = tbFoodCategory.Text;

            if (DAL.DAO.addNewFoodCategory(foodCateName))
            {
                MessageBox.Show("Add successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllFoodCategory();
            }
            else
            {
                MessageBox.Show("Add fails !");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbFoodCategory.Text = "";
            //set status button
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReset.Enabled = true;




        }
    }
}
