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
    public partial class LoanApplication : Form
    {
        public LoanApplication()
        {
            InitializeComponent();
            ViewAllLoanTransaction();
        }

        DataAccess myData = new DataAccess();

        public void ViewAllLoanTransaction()
        {
            dataGridView1.DataSource = myData.ViewAllLoanTransacction();
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtAccountNum.Text != "" && txtID.Text != "")
            {
                dataGridView1.DataSource = myData.SearchLoanID(txtAccountNum.Text, Convert.ToInt32(txtID.Text));
            }

            else if(txtAccountNum.Text !="" && txtID.Text =="")
            {
                dataGridView1.DataSource = myData.SearchLoanTransaction(txtAccountNum.Text);
            }

            else
            {
                ViewAllLoanTransaction();
            }
           
        }






        private void btnApprove_Click(object sender, EventArgs e)
        {
            if(txtAccountNum.Text != "" && txtID.Text != "")
            {
                string loantype = "Approved";
                dataGridView1.DataSource = myData.UpdateLoanType(Convert.ToInt32(txtID.Text), txtAccountNum.Text, loantype);
            }

            else
            {
                MessageBox.Show("Please Fill Account Number and ID");
            }

            

        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (txtAccountNum.Text != "" && txtID.Text != "")
            {
                string loantype = "Declined";
                dataGridView1.DataSource = myData.UpdateLoanType(Convert.ToInt32(txtID.Text), txtAccountNum.Text, loantype);
            }

            else
            {
                MessageBox.Show("Please Fill Account Number and ID");
            }

           
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            if (txtAccountNum.Text != "" && txtID.Text != "")
            {
                string loantype = "Terminated";
                dataGridView1.DataSource = myData.UpdateLoanType(Convert.ToInt32(txtID.Text), txtAccountNum.Text, loantype);
            }

            else
            {
                MessageBox.Show("Please Fill Account Number and ID");
            }            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu1 = new AdminMenu();
            adminMenu1.ShowDialog();
            this.Close();
        }

    }
}
