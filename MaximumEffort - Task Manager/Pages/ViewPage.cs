using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaximumEffort___Task_Manager.Pages
{
    public partial class ViewPage : Form
    {
        public ViewPage()
        {
            InitializeComponent();
        }

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



    }
}
