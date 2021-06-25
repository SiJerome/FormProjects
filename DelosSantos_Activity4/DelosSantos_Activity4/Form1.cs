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

namespace DelosSantos_Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            ChildClass.CheckMdiChildren(reg);
        }

        private void viewRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRecord viewrecord = new ViewRecord();
            ChildClass.CheckMdiChildren(viewrecord);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataAccess myData = new DataAccess();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (DataAccess.UserTypeAccount == "admin")
            {
                MenuFM.Enabled = true;
                TransacTab.Enabled = false;
            }
            else
                MenuFM.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
