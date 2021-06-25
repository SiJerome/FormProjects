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
    public partial class LoanCal : Form
    {
        public LoanCal()
        {
            InitializeComponent();


        }

        DataAccess myData = new DataAccess();
        
        double InterestRate;
        private void LoanCal_Load(object sender, EventArgs e)
        {
            AccNum.Text = DataAccess.MyAccountNumber;
            MemBond.Text = DataAccess.MyMembershipBond;
           


        }

        private void cmbLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (cmbLoanType.SelectedIndex == 0)
                {
                    txtAmount.Enabled = false;
                    double mymembond = Convert.ToDouble(MemBond.Text);
                    double amount = mymembond * 2;
                    txtAmount.Text = amount.ToString();  
                }

                else if (cmbLoanType.SelectedIndex == 1)
                {
                    txtAmount.Text = "";
                    txtAmount.Enabled = true;
                }

                else if (cmbLoanType.SelectedIndex == 2)
                {
                    txtAmount.Text = "";
                    txtAmount.Enabled = true;
                }
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string status = "Pending";

            if (cmbLoanType.Text != "" && txtAmount.Text != "" && txtMonthsToPay.Text != "")
            {

                if (cmbLoanType.SelectedIndex == 0)
                {
                    if (Convert.ToInt32(txtMonthsToPay.Text) > 24)
                    {
                        MessageBox.Show("Payable upto 24 months only");
                    }

                    else
                    {

                        if (Convert.ToInt32(txtMonthsToPay.Text) <= 6)
                        {
                            InterestRate = 0.005;
                        }

                        else if (Convert.ToInt32(txtMonthsToPay.Text) >= 7 && Convert.ToInt32(txtMonthsToPay.Text) <= 12)
                        {
                            InterestRate = 0.004;
                        }

                        else if (Convert.ToInt32(txtMonthsToPay.Text) >= 13 && Convert.ToInt32(txtMonthsToPay.Text) <= 18)
                        {
                            InterestRate = 0.0035;
                        }

                        else if (Convert.ToInt32(txtMonthsToPay.Text) >= 19 && Convert.ToInt32(txtMonthsToPay.Text) <= 24)
                        {
                            InterestRate = 0.0025;
                        }

                        myData.ComputeLoan(InterestRate, Convert.ToDouble(txtAmount.Text), Convert.ToInt32(txtMonthsToPay.Text));
                        myData.AddNewLoan(AccNum.Text, MemBond.Text, cmbLoanType.Text, txtAmount.Text, myData.MyInterest.ToString(), myData.MyMonthlyAmortization.ToString(".00"), txtMonthsToPay.Text, myData.MyTotalLoanDue.ToString(), status);

                        MessageBox.Show("Transaction Successful." +
                            "\nType of Loan: Regular Loan" +
                            "\nInterest: " + myData.MyInterest +
                            "\nTotal Loan Due: " + myData.MyTotalLoanDue +
                            "\nMonthly Amortization: " + myData.MyMonthlyAmortization.ToString(".00"));

                        this.Hide();
                        MembersMenu membersMenu1 = new MembersMenu();
                        membersMenu1.ShowDialog();
                        this.Close();
                    }

                }// end of regular loan

//=======================================================================================================


                else if (cmbLoanType.SelectedIndex == 1)
                {
                    if (Convert.ToDouble(txtAmount.Text) < 5000 || Convert.ToDouble(txtAmount.Text) > 30000)
                    {
                        MessageBox.Show("Amount should be 5000 upto 30000");
                    }

                    else 
                    {
                        if (Convert.ToInt32(txtMonthsToPay.Text) > 12)
                        {
                            MessageBox.Show("Payable upto 12 months only");
                        }

                        else
                        {
                            if (Convert.ToInt32(txtMonthsToPay.Text) <= 6)
                            {
                                InterestRate = 0.005;
                            }

                            else if (Convert.ToInt32(txtMonthsToPay.Text) >= 7 && Convert.ToInt32(txtMonthsToPay.Text) <= 12)
                            {
                                InterestRate = 0.004;
                            }

                            myData.ComputeLoan(InterestRate, Convert.ToDouble(txtAmount.Text), Convert.ToInt32(txtMonthsToPay.Text));
                            myData.AddNewLoan(AccNum.Text, MemBond.Text, cmbLoanType.Text, txtAmount.Text, myData.MyInterest.ToString(), myData.MyMonthlyAmortization.ToString(".00"), txtMonthsToPay.Text, myData.MyTotalLoanDue.ToString(), status);

                            MessageBox.Show("Transaction Successful." +
                                "\nType of Loan: Emergency Loan" +
                                "\nInterest: " + myData.MyInterest +
                                "\nTotal Loan Due: " + myData.MyTotalLoanDue +
                                "\nMonthly Amortization: " + myData.MyMonthlyAmortization.ToString(".00"));
                            this.Hide();
                            MembersMenu membersMenu1 = new MembersMenu();
                            membersMenu1.ShowDialog();
                            this.Close();
                        }

                        
                    }

//=======================================================================================================

                }// end of emergency loan

                else if (cmbLoanType.SelectedIndex == 2)
                {
                    if(Convert.ToDouble(txtAmount.Text) > 30000)
                        if (Convert.ToDouble(txtAmount.Text) < 50000 || Convert.ToDouble(txtAmount.Text) > 120000)
                        {
                            MessageBox.Show("Amount should be 50000 upto 120000");
                        }
                        else
                        {
                            if (Convert.ToInt32(txtMonthsToPay.Text) <= 6)
                            {
                                InterestRate = 0.005;
                            }

                            else if (Convert.ToInt32(txtMonthsToPay.Text) >= 7 && Convert.ToInt32(txtMonthsToPay.Text) <= 12)
                            {
                                InterestRate = 0.004;
                            }

                            else if (Convert.ToInt32(txtMonthsToPay.Text) >= 13 && Convert.ToInt32(txtMonthsToPay.Text) <= 18)
                            {
                                InterestRate = 0.0035;
                            }

                            else if (Convert.ToInt32(txtMonthsToPay.Text) >= 19)
                            {
                                InterestRate = 0.0025;
                            }

                            myData.ComputeLoan(InterestRate, Convert.ToDouble(txtAmount.Text), Convert.ToInt32(txtMonthsToPay.Text));
                            myData.AddNewLoan(AccNum.Text, MemBond.Text, cmbLoanType.Text, txtAmount.Text, myData.MyInterest.ToString(), myData.MyMonthlyAmortization.ToString(".00"), txtMonthsToPay.Text, myData.MyTotalLoanDue.ToString(), status);

                            MessageBox.Show("Transaction Successful." +
                                "\nType of Loan: Regular Loan" +
                                "\nInterest: " + myData.MyInterest +
                                "\nTotal Loan Due: " + myData.MyTotalLoanDue +
                                "\nMonthly Amortization: " + myData.MyMonthlyAmortization.ToString(".00"));

                            this.Hide();
                            MembersMenu membersMenu1 = new MembersMenu();
                            membersMenu1.ShowDialog();
                            this.Close();
                        }
                    else
                    {
                        MessageBox.Show("Only Memberbond of above 30000 is allowed");
                    }

                }// end of privelege loan

            }//end of if
            else
            {
                MessageBox.Show("Please Input All Fields");
            }
        }// end of btnClick



        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MembersMenu membersMenu1 = new MembersMenu();
            membersMenu1.ShowDialog();
            this.Close();
        }
    }
}
