using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelosSantos_Summative1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.txttime.Text = time.ToString("dddd MMMM d yyyy");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public void addInput(string inputtext, string time)
        {
            String[] row = { inputtext, time };
            string output = string.Join(" ", row);

            listBox1.Items.Add(output);
           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    addInput(textBox1.Text, txttime.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Input string");
                }

                
            }

        }
    }
}
