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

        private void txtHra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrossSalry_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double bs=Convert.ToDouble(txtbasicsalary.Text);
            double hra = bs * 0.40;
            double ta = bs * 0.30;
            double da = bs * 0.20;
            double pf = bs * 0.12;
            double gross = (bs+hra+ta+da)-pf;

            txtHra.Text = hra.ToString();
            txtTa.Text = ta.ToString();
            txtDA.Text = da.ToString();
            txtPF.Text = pf.ToString();
            txtGrossSalry.Text=gross.ToString();   


        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg =txtEmpId.Text +"\n"+txtEmpname.Text+"\n"+cmbDEPTlist.Text+"\n"+txtGrossSalry.Text;
            lblmsg.Text = msg;  
        }

        private void lblmsg_Click(object sender, EventArgs e)
        {

        }
    }
}
