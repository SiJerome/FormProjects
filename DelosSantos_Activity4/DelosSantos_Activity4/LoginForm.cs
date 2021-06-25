using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelper;

namespace DelosSantos_Activity4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        DataAccess myData = new DataAccess();
        private void button1_Click(object sender, EventArgs e)
        {
           
            if(myData.CheckUserAcc(txtUser.Text, txtPass.Text))
            {
                Form1 form = new Form1();
                txtUser.Clear();
                txtPass.Clear();
                form.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            registration.ShowDialog();
        }
    }
}
