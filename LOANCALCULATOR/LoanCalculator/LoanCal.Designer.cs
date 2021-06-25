namespace LoanCalculator
{
    partial class LoanCal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbLoanType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonthsToPay = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AccNum = new System.Windows.Forms.Label();
            this.MemBond = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 33);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(605, 59);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOAN CALCULATOR";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 57);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.cmbLoanType);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(238, 114);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 27);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // cmbLoanType
            // 
            this.cmbLoanType.FormattingEnabled = true;
            this.cmbLoanType.Items.AddRange(new object[] {
            "Regular Loan",
            "Emergency Loan",
            "Privellage Loan"});
            this.cmbLoanType.Location = new System.Drawing.Point(123, 3);
            this.cmbLoanType.Name = "cmbLoanType";
            this.cmbLoanType.Size = new System.Drawing.Size(212, 21);
            this.cmbLoanType.TabIndex = 5;
            this.cmbLoanType.SelectedIndexChanged += new System.EventHandler(this.cmbLoanType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Type of Loan";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(238, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 27);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(122, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(213, 20);
            this.txtAmount.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(7, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(112, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interest";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnCompute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(416, 213);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(160, 40);
            this.btnCompute.TabIndex = 27;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtMonthsToPay);
            this.panel6.Location = new System.Drawing.Point(238, 180);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 27);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Month-To-Pay";
            // 
            // txtMonthsToPay
            // 
            this.txtMonthsToPay.Location = new System.Drawing.Point(122, 4);
            this.txtMonthsToPay.Name = "txtMonthsToPay";
            this.txtMonthsToPay.Size = new System.Drawing.Size(213, 20);
            this.txtMonthsToPay.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(22, 112);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 149);
            this.panel7.TabIndex = 28;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(112, 122);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "0.25%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(9, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "19-24";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(112, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "0.35%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(9, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "13-18";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(112, 63);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "0.4%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(9, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "7-12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(112, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "0.5%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "1-6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(9, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Months";
            // 
            // AccNum
            // 
            this.AccNum.AutoSize = true;
            this.AccNum.Location = new System.Drawing.Point(342, 98);
            this.AccNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccNum.Name = "AccNum";
            this.AccNum.Size = new System.Drawing.Size(48, 13);
            this.AccNum.TabIndex = 5;
            this.AccNum.Text = "AccNum";
            // 
            // MemBond
            // 
            this.MemBond.AutoSize = true;
            this.MemBond.Location = new System.Drawing.Point(514, 98);
            this.MemBond.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemBond.Name = "MemBond";
            this.MemBond.Size = new System.Drawing.Size(55, 13);
            this.MemBond.TabIndex = 6;
            this.MemBond.Text = "MemBond";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(248, 98);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Account Number:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(419, 98);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Membership bond:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 40);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LoanCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 273);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.AccNum);
            this.Controls.Add(this.MemBond);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "LoanCal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanCal";
            this.Load += new System.EventHandler(this.LoanCal_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbLoanType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonthsToPay;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AccNum;
        private System.Windows.Forms.Label MemBond;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCancel;
    }
}