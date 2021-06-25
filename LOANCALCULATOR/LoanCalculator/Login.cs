using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataHelperLoanCalculator;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                AdminMenu adminMenu1 = new AdminMenu();
                adminMenu1.ShowDialog();
                this.Close();
            }

            
            else if (myData.CheckUserAccount(txtUsername.Text, txtPassword.Text))
            {
                 this.Hide();
                 MembersMenu membersMenu1 = new MembersMenu();
                 membersMenu1.ShowDialog();
                 this.Close();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
            this.Close();
        }


        //ForgetPassword
        private void label5_Click(object sender, EventArgs e)
        {
            string Status="Pending";

            if(txtUsername.Text != "")
            {
                MessageBox.Show("Reset Password Pending");
                myData.ResetPasswordPending(txtUsername.Text, Status);
            }

            else
            {
                MessageBox.Show("Please Input Account Number");
            }
            
        }
    }
}
