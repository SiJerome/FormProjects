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

namespace DelosSantos_Sumamtive2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataAccess myData = new DataAccess();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(myData.CheckAcc(txtemail.Text, txtpass.Text))
            {
                this.Hide();
                Form1 form = new Form1();
                txtemail.Clear();
                txtpass.Clear();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Account");
            }
        }
    }
}
