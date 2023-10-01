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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "Admin" && txtpassword.Text == "Admin")
            {
                MessageBox.Show("Login Successfully");
                Form_Employee_Details form2 = new Form_Employee_Details();
                //     form2.Show();
                //this.Hide();
                MDIForm mDIForm = new MDIForm();
                mDIForm.Show();
                this.Hide();//This refers to the login form
            }
            else
            {
                MessageBox.Show("Login Fail");
            }       

        }        

        private void btncancel_Click(object sender, EventArgs e)
        {

            txtusername.Clear();
            txtpassword.Clear();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
                      
        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
