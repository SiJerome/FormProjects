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

namespace Activity2
{
    public partial class Form1 : Form
    {
        DataAccess myData = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }


     
        private void button1_Click(object sender, EventArgs e)
        {
            int itemcode;
            if (HoursWork.Text != "" && EmpID.Text != "" && EmpName.Text != "")
            {
                if (comboBox1.Text == "Contractual")
                {
                    itemcode = 1;
                    myData.CalculateGrossPay(itemcode, int.Parse(HoursWork.Text), int.Parse(OvertimeBox.Text));
                    richTextBox1.AppendText("Employee ID: " + EmpID.Text + "\n" +
                                             "Employee Name: " + EmpName.Text + "\n" +
                                             "Number of Hours Worked: " + HoursWork.Text + "\n" +
                                             "Overtime Hours: " + OvertimeBox.Text + "\n" +
                                             "Employee Type: " + comboBox1.SelectedItem.ToString() + "\n" +
                                             "Gross Pay : " + myData.Grosspay.ToString() + "\n" +
                                             "Deduction Pay : " + myData.Deduction.ToString() + "\n" +
                                             "Net Pay : " + myData.Netpay.ToString() + "\n" +
                                             "Overtime Pay : " + myData.Otpay.ToString() + "\n" +
                                             "=====================" + "\n");
                }

                else if (comboBox1.Text == "Probationary")
                {
                    itemcode = 2;
                    myData.CalculateGrossPay(itemcode, int.Parse(HoursWork.Text), int.Parse(OvertimeBox.Text));
                    richTextBox1.AppendText("Employee ID: " + EmpID.Text + "\n" +
                                             "Employee Name: " + EmpName.Text + "\n" +
                                             "Number of Hours Worked: " + HoursWork.Text + "\n" +
                                             "Overtime Hours: " + OvertimeBox.Text + "\n" +
                                             "Employee Type: " + comboBox1.SelectedItem.ToString() + "\n" +
                                             "Gross Pay : " + myData.Grosspay.ToString() + "\n" +
                                             "Deduction Pay : " + myData.Deduction.ToString() + "\n" +
                                             "Net Pay : " + myData.Netpay.ToString() + "\n" +
                                             "Overtime Pay : " + myData.Otpay.ToString() + "\n" +
                                             "=====================" + "\n");
                }

                else if (comboBox1.Text == "Permanent")
                {
                    itemcode = 3;
                    myData.CalculateGrossPay(itemcode, int.Parse(HoursWork.Text), int.Parse(OvertimeBox.Text));
                    richTextBox1.AppendText("Employee ID: " + EmpID.Text + "\n" +
                                             "Employee Name: " + EmpName.Text + "\n" +
                                             "Number of Hours Worked: " + HoursWork.Text + "\n" +
                                             "Overtime Hours: " + OvertimeBox.Text + "\n" +
                                             "Employee Type: " + comboBox1.SelectedItem.ToString() + "\n" +
                                             "Gross Pay : " + myData.Grosspay.ToString() + "\n" +
                                             "Deduction Pay : " + myData.Deduction.ToString() + "\n" +
                                             "Net Pay : " + myData.Netpay.ToString() + "\n" +
                                             "Overtime Pay : " + myData.Otpay.ToString() + "\n" +
                                             "=====================" + "\n");
                }
            }
            else
            {
                MessageBox.Show("Input your Employee id \n Your Employee Name \n Your Hours of work");
            }
        }
    }
}
