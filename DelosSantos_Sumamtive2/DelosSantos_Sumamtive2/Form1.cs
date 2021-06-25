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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataAccess myData = new DataAccess();
        private void Form1_Load(object sender, EventArgs e)
        {
            //act like session variable
            lblaccnum.Text = DataAccess.Accnumber1;
            lblacctype.Text = DataAccess.Acctype1;
            lblbalance1.Text = DataAccess.Initialdeposit1;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        //intindihin nlng tong part na to, ignore yung empty methods
        private void button4_Click(object sender, EventArgs e)
        {
           string transtype = "Deposit";
           string time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
           
           if(Convert.ToDouble(txtdeposit.Text) >= 500)
            {
                myData.ComputeDeposit(lblaccnum.Text, txtdeposit.Text);
                myData.AddRTransactionRecord(transtype, txtdeposit.Text, Convert.ToDateTime(time), lblaccnum.Text, txttransferto.Text);
                lblbalance1.Text = myData.Dep.ToString();
                txtdeposit.Clear();
            }
            else
            {
                MessageBox.Show("Minimum input is 500");
            }     
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string transtype = "Withdraw";
            string time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();

            if (Convert.ToDouble(txtwithdraw.Text) < 200 || Convert.ToDouble(txtwithdraw.Text) >= Convert.ToDouble(lblbalance1.Text) * 0.7)
            {
                MessageBox.Show("Withdraw must be minimum of 200 and maximum of 70% of your balance");  
            }
            else
            {
                myData.ComputeWithdraw(lblaccnum.Text, txtwithdraw.Text);
                myData.AddRTransactionRecord(transtype, txtwithdraw.Text, Convert.ToDateTime(time), lblaccnum.Text, txttransferto.Text);
                lblbalance1.Text = myData.With.ToString();
                txtwithdraw.Clear();
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewTransaction viewTransaction =  new ViewTransaction();
            viewTransaction.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string transtype = "Transfer";
            string time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            if (lblaccnum.Text != txttransferto.Text)
            {
                if (Convert.ToDouble(txtamount.Text) >= Convert.ToDouble(lblbalance1.Text) * 0.7)
                {
                    MessageBox.Show("Only maximum of 70% of your balance");
                }
                else
                {
                    myData.ComputeTransfer1(lblaccnum.Text, txtamount.Text);
                    myData.GetBalance(txttransferto.Text, txtamount.Text);
                    myData.ComputeTransfer2(txttransferto.Text, txtamount.Text);
                    myData.AddRTransactionRecord(transtype, txtamount.Text, Convert.ToDateTime(time), lblaccnum.Text, txttransferto.Text);
                    lblbalance1.Text = myData.Trans.ToString();
                    txtamount.Clear();
                    txttransferto.Clear();
                   
                }
            }
            else
            {
                MessageBox.Show("Same account number");
            }
        }
    }
}
