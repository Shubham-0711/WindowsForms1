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
    public partial class MDIForm : Form
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void employeeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Employee_Details form2 = new Form_Employee_Details();
            form2.MdiParent = this;
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notepad obj = new Notepad();
            obj.MdiParent = this;
            obj.Show(); 
        }
    }
}
