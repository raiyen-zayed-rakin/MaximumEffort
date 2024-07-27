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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            MaximumEffort maximumEffort = new MaximumEffort();
            maximumEffort.Visible = true;
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddtasknext_Click(object sender, EventArgs e)
        {
            AddPage addPage = new AddPage();
            addPage.Visible = true;
            this.Close();
        }

        private void btnupdatetasknext_Click(object sender, EventArgs e)
        {
            UpdatePage updatePage = new UpdatePage();
            updatePage.Visible = true;
            this.Visible = false;
        }
    }
}
