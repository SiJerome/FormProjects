using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHelperLoanCalculator;

namespace LoanCalculator
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
        }
        DataAccess myData = new DataAccess();
   

        private void Graph_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myData.ViewLoanGraph();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu1 = new AdminMenu();
            adminMenu1.ShowDialog();
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            /*
            chart1.DataSource = myData.ViewLoanGraph();
            chart1.Series[0].XValueMember = "LoanType";
            chart1.Series[0].YValueMembers = "LoanStatus";
            chart1.DataBind();
            */

            /*
            //TESTING
            chart1.Series["Count"].Points.AddXY("Approved", 3);
            chart1.Series["Count"].Points.AddXY("Declined", 2);
            chart1.Series["Count"].Points.AddXY("Terminated", 1);
            */

            
            chart1.Series["Count"].Points.AddXY("Regular Loan", myData.getLoanTransactionCount("Regular Loan"));
            chart1.Series["Count"].Points.AddXY("Emergency Loan", myData.getLoanTransactionCount("Emergency Loan"));
            chart1.Series["Count"].Points.AddXY("Privilege Loan", myData.getLoanTransactionCount("Privellage Loan"));
        }
    }
}
