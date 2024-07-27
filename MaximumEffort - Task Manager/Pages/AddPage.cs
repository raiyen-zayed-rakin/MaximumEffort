using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MaximumEffort___Task_Manager.Custom_Classes;

namespace MaximumEffort___Task_Manager.Pages
{
    public partial class AddPage : Form
    {
        public AddPage()
        {
            InitializeComponent();
        }
        taskClass tc = new taskClass();
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Visible = true;
            this.Visible = false;
        }

        private void txtboxtaskid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //Get the value from the box 
            tc.TaskName = txtboxtaskname.Text;
            tc.Description = txtboxdescription.Text;
            tc.Date = txtboxdate.Text;
            if (radiodone.Checked)
            {
                tc.Status = radiodone.Text;
            }
            else
            {
                tc.Status = radioundone.Text;
            }
            bool success = tc.Insert(tc);
            if (success == true)
            {
                MessageBox.Show("Task added successfully.");
                Clear();
            }
            else
            {
                MessageBox.Show("Task adding failed. Please try again");
            }
            //load data in Data grid view
            DataTable dataTable = tc.Select();
            dgvTaskList.DataSource = dataTable;
        }

        private void AddPage_Load(object sender, EventArgs e)
        {
            //load data in Data grid view
            DataTable dataTable = tc.Select();
            dgvTaskList.DataSource = dataTable;
        }

        public void Clear()
        {
            txtboxtaskid.Text = "";
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
    }
}
