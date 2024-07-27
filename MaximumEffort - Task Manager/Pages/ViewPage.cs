using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximumEffort___Task_Manager.Custom_Classes;

namespace MaximumEffort___Task_Manager.Pages
{
    public partial class ViewPage : Form
    {
        public ViewPage()
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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Visible = true;
            this.Visible = false;
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from the text box
            string keyword = txtboxsearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_maximumeffort WHERE TaskName LIKE '%" + keyword + "%' OR Description LIKE '%" + keyword + "%' OR Date LIKE '%" + keyword + "%' OR Status LIKE '%" + keyword + "%'", conn);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgvTaskList.DataSource = dt;
        }
        //private void dgvTaskList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //Get the data from Data Grid View and load it to the boxes
        //    //identify the row on which mouse is clicked 
        //    int rowIndex = e.RowIndex;
        //    //TaskID = dgvTaskList.Rows[rowIndex].Cells[0].Value;
        //    TaskName = dgvTaskList.Rows[rowIndex].Cells[1].Value.ToString();
        //    Description = dgvTaskList.Rows[rowIndex].Cells[2].Value.ToString();
        //    Date = dgvTaskList.Rows[rowIndex].Cells[3].Value.ToString();
        //    // Retrieve the value representing the RadioButton state
        //    var radioButtonValue = dgvTaskList.Rows[rowIndex].Cells[4].Value;

        //        // Assuming radioButtonValue is a string or enum that indicates which RadioButton was selected
        //        switch (radioButtonValue.ToString())
        //        {
        //            case "Done":
        //                radiodone.Checked = true;
        //                radioundone.Checked = false;
        //                break;
        //            case "Undone":
        //                radiodone.Checked = false;
        //                radioundone.Checked = true;
        //                break;
        //        }
        //}

        private void ViewPage_Load(object sender, EventArgs e)
        {
            //load data in Data grid view
            DataTable dataTable = tc.Select();
            dgvTaskList.DataSource = dataTable;
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
