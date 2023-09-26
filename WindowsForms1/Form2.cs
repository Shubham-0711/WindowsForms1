using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form_Employee_Details : Form
    {
        List<string> deptlist = new List<string>()
        {
            "HR","Admin","Sales","Development","Testing","Marketing"
        };

        public Form_Employee_Details()
        {
            InitializeComponent();
        }

        private void Form_Employee_Details_Load(object sender, EventArgs e)
        {
            cmbDEPTlist.DataSource = deptlist;
        }

        private void cmbDEPTlist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
