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
    public partial class DeletePage : Form
    {
        public DeletePage()
        {
            InitializeComponent();
        }

        private void DeletePage_Load(object sender, EventArgs e)
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
    }
}
