using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project
{
    public partial class frmFood : Form
    {
       
        public frmFood()
        {
            InitializeComponent();
            setStatusButton();
            //set default for radiobutton
            rdExist.Checked = true;
        }

        //function to set status for button add, update, delete, reset
        public void setStatusButton()
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReset.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin frm2 = new frmAdmin();
            frm2.TopLevel = false;
            panel1.Controls.Add(frm2);
           
                frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int foodCateID = Convert.ToInt32(comboBox2.SelectedValue.ToString());
            dataGridView1.DataSource = DAL.DAO.GetAllFoodByFoodCateID(foodCateID);
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            loadFoodData();
            loadFoodCategory();
            comboBox2.SelectedIndex = 0;
        }

        //load food data into DataGridView
        public void loadFoodData()
        {
            dataGridView1.DataSource = DAL.DAO.GetAllFood();
        }
        //load foodCategory into Combobox
        public void loadFoodCategory()
        {
         //   comboBox2.Items.Insert(0, "-----All-----");
         //set value for combobox 2
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";
            comboBox2.DataSource = DAL.DAO.GetAllFoodCategoryTable();
            comboBox2.SelectedIndex = 0;
            //set value for combobox 1
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = DAL.DAO.GetAllFoodCategoryTable();
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //set status for add, update, delete, reset button
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReset.Enabled = true;

            //ten mon, gia , tinh trang
            string foodID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string foodName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string foodCateID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
           

            tbIdVirtual.Text = foodID;
            tbFoodName.Text = foodName;
            tbPrice.Text = price;
          //  comboBox1.SelectedItem = foodCateID; 

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            if (!tbFoodName.Text.Equals("") && !tbPrice.Text.Equals(""))
            {
                string foodName = tbFoodName.Text;
                int foodCategory = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                int price = Convert.ToInt32(tbPrice.Text);

                string foodStatus = "Hết Món";
                bool check = rdExist.Checked;
                if (check)
                {
                    foodStatus = "Còn Món";
                }

                if(DAL.DAO.addNewFood(foodName, foodCategory, foodStatus, price))
                {
                    MessageBox.Show("Successfully !");
                    dataGridView1.DataSource = DAL.DAO.GetAllFood();
                }


            }
            if (tbFoodName.Text.Equals(""))
            {
                lbFoodName.Text = "Can't blank, please !";
            }
            else
            {
                lbFoodName.Text = "";
            }

            if (tbPrice.Text.Equals(""))
            {
                lbPrice.Text = "Can't blank, please !";
            }
            else
            {
                lbPrice.Text = "";
            }
        }

     

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            tbFoodName.Text = "";
            tbPrice.Text = "";
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int foodID = Convert.ToInt32(tbIdVirtual.Text);
            int foodCate = Convert.ToInt32(comboBox1.SelectedValue);

            if (DAL.DAO.deleteFoodByID(foodID))
            {
                MessageBox.Show("delete successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllFoodByFoodCateID(foodCate);
            }
            else
            {
                MessageBox.Show("delete fails !");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int fooID = Convert.ToInt32(tbIdVirtual.Text);
            string foodName = tbFoodName.Text;
            int foodCate = Convert.ToInt32(comboBox1.SelectedValue);
            double price = Double.Parse(tbPrice.Text);

            string foodStatus = "Hết Món";
            bool check = rdExist.Checked;
            if (check)
            {
                foodStatus = "Còn Món";
            }

            MessageBox.Show("fooID : "+ fooID + "\nfoodName : "+ foodName + "\nfoodCate : "+ foodCate + "\nprice : "+ price+ "\nfoodStatus : "+ foodStatus);

            if (DAL.DAO.updateFood(fooID, foodName,foodCate, price, foodStatus))
            {
                MessageBox.Show("Update successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllFoodByFoodCateID(foodCate);
            }
            else
            {
                MessageBox.Show("Update fails !");
            }

        }
    }
}
