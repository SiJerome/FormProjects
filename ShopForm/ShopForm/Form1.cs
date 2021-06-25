using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DataHelper;

namespace ShopForm
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
            dataGridView1.Rows.Clear();
            for (int i = 0; i < myData.Productid.Count; i++)
            {
                dataGridView1.Rows.Add(myData.Productid[i].ToString(),
                                        myData.Productname[i].ToString(),
                                        myData.Productquantity[i].ToString());
            }
        }
        public void AddRecords(string productid, string productname, string quantity, string srp, string amount)
        {
            String[] row = { productid, productname, quantity, srp, amount };

            ListViewItem listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Printer Laser")
            {
                txtsrp.Text = myData.Printerlaser.ToString();
            }
            if (comboBox1.Text == "Mouse")
            {
                txtsrp.Text = myData.Mouse.ToString();
            }
            if (comboBox1.Text == "Printer Dot Matrix")
            {
                txtsrp.Text = myData.Printerdot.ToString();
            }
            if (comboBox1.Text == "LCD Monitor")
            {
                txtsrp.Text = myData.Lcd.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int itemcode;
            int qty = Convert.ToInt32(txtquantity.Value.ToString());
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select an item");
            }
            else
            {
                
                if (comboBox1.Text == "Printer Laser")
                {
                    itemcode = 1;

                    int stk = Convert.ToInt32(myData.Productquantity[0]);
                    

                    if (stk <= 0)
                    {
                        MessageBox.Show("Item is out of stock");
                    }
                    else
                    {
                        if (qty > stk)
                        {
                            MessageBox.Show("Quantity is too much for the stock");
                        }
                        else
                        {
                            myData.ComputeProduct(itemcode, int.Parse(txtquantity.Value.ToString()));
                            myData.UpdateQuantity(Convert.ToInt32(txtquantity.Value.ToString()), 0);
                            dataGridView1[2, 0].Value = myData.Newstock.ToString();
                            AddRecords(myData.Productid[0].ToString(), myData.Productname[0].ToString(),
                            txtquantity.Value.ToString(), myData.Printerlaser.ToString(), myData.Amount.ToString());
                        }

                    }
                      
                    }
                

                else if (comboBox1.Text == "Mouse")
                {
                    itemcode = 2;

                    int stk = Convert.ToInt32(myData.Productquantity[1]);


                    if (stk <= 0)
                    {
                        MessageBox.Show("Item is out of stock");
                    }
                    else
                    {
                        if (qty > stk)
                        {
                            MessageBox.Show("Quantity is too much for the stock");
                        }
                        else
                        {
                            myData.ComputeProduct(itemcode, int.Parse(txtquantity.Value.ToString()));
                            myData.UpdateQuantity(Convert.ToInt32(txtquantity.Value.ToString()), 1);
                            dataGridView1[2, 1].Value = myData.Newstock.ToString();

                            AddRecords(myData.Productid[1].ToString(), myData.Productname[1].ToString(),
                            txtquantity.Value.ToString(), myData.Mouse.ToString(), myData.Amount.ToString());
                        }
                    }

                }
                else if (comboBox1.Text == "Printer Dot Matrix")
                {
                    itemcode = 3;

                    int stk = Convert.ToInt32(myData.Productquantity[2]);

                    if (stk <= 0)
                    {
                        MessageBox.Show("Item is out of stock");
                    }
                    else
                    {
                        if (qty > stk)
                        {
                            MessageBox.Show("Quantity is too much for the stock");
                        }
                        else
                        {
                            myData.ComputeProduct(itemcode, int.Parse(txtquantity.Value.ToString()));
                            myData.UpdateQuantity(Convert.ToInt32(txtquantity.Value.ToString()), 2);
                            dataGridView1[2, 2].Value = myData.Newstock.ToString();
                            
                            AddRecords(myData.Productid[2].ToString(), myData.Productname[2].ToString(),
                            txtquantity.Value.ToString(), myData.Printerdot.ToString(), myData.Amount.ToString());
                        }
                    }

                }
                else if (comboBox1.Text == "LCD Monitor")
                {
                    itemcode = 4;

                    int stk = Convert.ToInt32(myData.Productquantity[3]);

                    if (stk <= 0)
                    {
                        MessageBox.Show("Item is out of stock");
                    }
                    else
                    {
                        if (qty > stk)
                        {
                            MessageBox.Show("Quantity is too much for the stock");
                        }
                        else
                        {
                            myData.ComputeProduct(itemcode, int.Parse(txtquantity.Value.ToString()));
                            myData.UpdateQuantity(Convert.ToInt32(txtquantity.Value.ToString()), 3);
                            dataGridView1[2, 3].Value = myData.Newstock.ToString();
                            
                            AddRecords(myData.Productid[3].ToString(), myData.Productname[3].ToString(),
                            txtquantity.Value.ToString(), myData.Lcd.ToString(), myData.Amount.ToString());
                        }
                    }

                }
                txttotalamount.Text = myData.Totalamount.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping!");
            Application.Exit();
        }
    }
}
