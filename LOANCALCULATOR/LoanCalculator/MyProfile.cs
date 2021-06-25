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
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersMenu membersMenu1 = new MembersMenu();
            membersMenu1.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyProfile_Load(object sender, EventArgs e)
        {
            lblAccountNumber.Text = DataAccess.MyAccountNumber;
            lblMembershipBond.Text = DataAccess.MyMembershipBond;
            lblFirstName.Text = DataAccess.MyFirstName;
            lblLastName.Text = DataAccess.MyLastName;
            lblPassword.Text = DataAccess.MyPassword;
            lblEmailAddress.Text = DataAccess.MyEmailAddress;
            lblBirthday.Text = DataAccess.MyBirthday;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            string age = (days / 365).ToString("0");

            if (Convert.ToInt32(age) < 21 || Convert.ToInt32(age) > 65)
                MessageBox.Show("21 years old up to 65 years old only.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            string age = (days / 365).ToString("0");
            string datepicked = from.ToString("MM/dd/yyyy");

            if (Convert.ToInt32(age) < 21 || Convert.ToInt32(age) > 65)
                MessageBox.Show("21 years old up to 65 years old only.");
            else
            {
                if (txtMembershipBond.Text != "" && txtPassword.Text != "" && txtEmailAddress.Text != "")
                {
                    myData.UpdateProfile(txtMembershipBond.Text, txtPassword.Text, datepicked, txtEmailAddress.Text, DataAccess.MyAccountNumber);
                    MessageBox.Show("Success!" + "\n Logout to take effect.");
                }
                else
                {
                    MessageBox.Show("Please fill the empty field");
                }
            }
        }
    }
}
