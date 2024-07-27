using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximumEffort___Task_Manager.Custom_Classes;

namespace MaximumEffort___Task_Manager.Pages
{
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
        }
        taskClass tc = new taskClass();
        private void lbladdtask_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Visible = true;
            this.Visible = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePage_Load(object sender, EventArgs e)
        {
            //load data in Data grid view
            DataTable dataTable = tc.Select();
            dgvTaskList.DataSource = dataTable;
        }
        public void Clear()
        {
            txtboxtaskname.Text = "";
            txtboxdescription.Text = "";
            txtboxdate.Text = "";
            if (radiodone.Checked)
            {
                radiodone.Checked = false;
            }
            else
            {
                radioundone.Checked = false;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //get the data from the textboxes
            //Get the value from the box 
            tc.TaskName = txtboxtaskname.Text;
            tc.Description = txtboxdescription.Text;
            tc.Date = txtboxdate.Text;
            if (radiodone.Checked)
            {
                tc.Status = "Done";
            }
            else
            {
                tc.Status = "Undone";
            }
            bool success = tc.Update(tc);
            if (success == true)
            {
                MessageBox.Show("Task updated successfully.");
                //load data in Data grid view
                DataTable dataTable = tc.Select();
                dgvTaskList.DataSource = dataTable;
                Clear();
            }
            else
            {
                MessageBox.Show("Task update failed. Please try again");
            }
        }

        private void dgvTaskList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data from Data Grid View and load it to the boxes
            //identify the row on which mouse is clicked 
            int rowIndex = e.RowIndex;
            txtboxtaskid.Text = dgvTaskList.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxtaskname.Text = dgvTaskList.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxdescription.Text = dgvTaskList.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxdate.Text = dgvTaskList.Rows[rowIndex].Cells[3].Value.ToString();
            // Retrieve the value representing the RadioButton state
            var radioButtonValue = dgvTaskList.Rows[rowIndex].Cells[4].Value;

            // Assuming radioButtonValue is a string or enum that indicates which RadioButton was selected
            switch (radioButtonValue.ToString())
            {
                case "Done":
                    radiodone.Checked = true;
                    radioundone.Checked = false;
                    break;
                case "Undone":
                    radiodone.Checked = false;
                    radioundone.Checked = true;
                    break;
            }
        }
    }
}
