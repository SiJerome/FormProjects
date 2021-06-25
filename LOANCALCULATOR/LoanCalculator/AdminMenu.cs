using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanCalculator
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnViewAllRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllRecords viewAllRecords1 = new ViewAllRecords();
            viewAllRecords1.ShowDialog();
            this.Close();
        }

        private void btnLoanApplication_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoanApplication loanApplication1 = new LoanApplication();
            loanApplication1.ShowDialog();
            this.Close();
        }

        private void btnPasswordReset_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordReset passwordReset1 = new PasswordReset();
            passwordReset1.ShowDialog();
            this.Close();
        }

        private void btnViewGraph_Click(object sender, EventArgs e)
        {
            this.Hide();
            Graph graph = new Graph();
            graph.ShowDialog();
            this.Close();
        }
    }
}
