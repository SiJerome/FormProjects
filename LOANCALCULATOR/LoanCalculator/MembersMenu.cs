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
    public partial class MembersMenu : Form
    {
        public MembersMenu()
        {
            InitializeComponent();
        }

        DataAccess myData = new DataAccess();
        private void MembersMenu_Load(object sender, EventArgs e)
        {
            lblAccountNumber.Text = DataAccess.MyAccountNumber;
            lblMembershipBond.Text = DataAccess.MyMembershipBond;
        }
        public static string MemberBond = DataAccess.MyMembershipBond;

        private void btnApplyForLoan_Click(object sender, EventArgs e)
        {
            MemberBond = lblMembershipBond.Text;
            this.Hide();
            LoanCal loanCal1 = new LoanCal();
            loanCal1.ShowDialog();
            this.Close();
        }

        private void btnViewLoanDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanDetails loanDetails1 = new LoanDetails();
            loanDetails1.ShowDialog();
            this.Close();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile1 = new MyProfile();
            myProfile1.ShowDialog();
            this.Close();
        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblMembershipBond_Click(object sender, EventArgs e)
        {

        }

       
    }
}
