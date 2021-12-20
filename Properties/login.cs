using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFeedpackSystem.Properties
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard adminlogin = new AdminDashboard();

            Admin a = new Admin();

            adminlogin.UserName = userNameTxtBox.Text;
            adminlogin.Password = passwordTextBox.Text;




            if (userNameTxtBox.Text == "admin" && passwordTextBox.Text == "admin123")
            {
                MessageBox.Show("Success");
                a.Show();
                
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();

            MessageBox.Show("Success");
            a.Show();

        }

       
    }
}
