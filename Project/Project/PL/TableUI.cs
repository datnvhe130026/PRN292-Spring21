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
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
            //set status for button
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReset.Enabled = false;
            btnAdd.Enabled = true;
            //set radio
            rdYes.Checked = true;


        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            loadDataForCombobox();
            loadDataForDataGridview();
        }

        //load data for combobox
        public void loadDataForCombobox()
        {
            cbbTableName.DisplayMember = "name";
            cbbTableName.ValueMember = "id";
            cbbTableName.DataSource = DAL.DAO.GetAllTableFood();
            cbbTableName.SelectedIndex = 0;
        }

        //load data for datagridview
        public void loadDataForDataGridview()
        {
            dataGridView1.DataSource = DAL.DAO.GetAllTableFood();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbbTableName.SelectedValue);
            dataGridView1.DataSource = DAL.DAO.GetAllTableByID(id);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //set status for button
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnReset.Enabled = true;

            //get Value
            string tableID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nameTable = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            // string status = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbFoodTable.Text = nameTable;
            tbVirtualID.Text = tableID;



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbFoodTable.Text;
            string status = "Het";

            bool check = rdYes.Checked;
            if (check)
            {
                status = "Trong";
            }

            if (!tbFoodTable.Text.Equals(""))
            {
                if (DAL.DAO.AddNewFoodTable(name, status))
                {
                    MessageBox.Show("Add successfully !");
                    dataGridView1.DataSource = DAL.DAO.GetAllTableFood();
                }
                else
                {
                    MessageBox.Show("Add fails !");
                }

            }
            else
            {
                lbError.Text = "Can't blank, please !";
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbFoodTable.Text = "";
            //set status for button
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int tableID = Convert.ToInt32(tbVirtualID.Text);
            if (DAL.DAO.deleteTableFoodByID(tableID))
            {
                MessageBox.Show("Delete successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllTableFood();
            }
            else
            {
                MessageBox.Show("Delete failse !");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbVirtualID.Text);
            string name = tbFoodTable.Text;

            string status = "Het";
            bool check = rdYes.Checked;
            if (check)
            {
                status = "Trong";
            }

            if (DAL.DAO.updateTableFood(id, name, status))
            {
                MessageBox.Show("Update successfully !");
                dataGridView1.DataSource = DAL.DAO.GetAllTableFood();
            }
            else
            {
                MessageBox.Show("Update fails !");
            }


        }
    }
}
