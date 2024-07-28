using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaximumEffort___Task_Manager.Pages;

namespace MaximumEffort___Task_Manager
{
    public partial class MaximumEffort : Form
    {
        public MaximumEffort()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncreator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: Raiyen Zayed Rakin\nYear: 2024\nUniversity: AIUB\n\n All Rights Reserved.");
        }

        private void btnfb_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.facebook.com/raiyenzayed.rakin/");
        }

        private void btngh_Click(object sender, EventArgs e)
        {
           Process.Start("https://github.com/raiyen-zayed-rakin");
        }

        private void btnli_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.linkedin.com/in/raiyen-zayed-rakin-948100265/");
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Visible = true;
            this.Visible = false;
        }
    }
}
