using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        Double num1;
        String myOperators = "";
        bool operator_pressed = false;
   
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnback_Click(object sender, EventArgs e)
        {
            if (txtresult.TextLength > 0)
                txtresult.Text = txtresult.Text.Remove(txtresult.TextLength - 1, 1);
        }

        private void btn_operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            myOperators = b.Text;
            num1 = Double.Parse(txtresult.Text);
            operator_pressed = true;
            txtequation.Text = num1 + " " + myOperators;
        }

        private void btn_click(object sender, EventArgs e)
        {
            
            if (operator_pressed)
                txtresult.Clear();
            operator_pressed = false;
            Button b = (Button)sender;
            txtresult.Text = txtresult.Text + b.Text;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num1 = 0;
            myOperators = "";
            operator_pressed = false;
            txtresult.Clear();
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            txtequation.Text = "";
            switch (myOperators) {

                case "+":
                    txtresult.Text = (num1 + Double.Parse(txtresult.Text)).ToString();        
                    break;
                case "-":
                    txtresult.Text = (num1 - Double.Parse(txtresult.Text)).ToString();
                    break;
                case "*":
                    txtresult.Text = (num1 * Double.Parse(txtresult.Text)).ToString();
                    break;
                case "/":
                    if (Double.Parse(txtresult.Text) == 0)
                    {
                        txtresult.Text = "Can't divide to zero";
                    }
                    else
                    {
                        txtresult.Text = (num1 / Double.Parse(txtresult.Text)).ToString();
                    }
                    break;

            }//switch end
           
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            txtresult.Text = (Double.Parse(txtresult.Text) / 100).ToString();
        }

    }
}
