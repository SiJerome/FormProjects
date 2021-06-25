namespace Activity2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EmpID = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.OvertimeHours = new System.Windows.Forms.Label();
            this.HoursWork = new System.Windows.Forms.NumericUpDown();
            this.OvertimeBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.HoursWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvertimeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Hours Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Type";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(442, 273);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "My Salary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salary Calculator";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contractual",
            "Probationary",
            "Permanent"});
            this.comboBox1.Location = new System.Drawing.Point(215, 177);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // EmpID
            // 
            this.EmpID.Location = new System.Drawing.Point(215, 56);
            this.EmpID.Name = "EmpID";
            this.EmpID.Size = new System.Drawing.Size(245, 22);
            this.EmpID.TabIndex = 13;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(215, 84);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(245, 22);
            this.EmpName.TabIndex = 14;
            // 
            // OvertimeHours
            // 
            this.OvertimeHours.AutoSize = true;
            this.OvertimeHours.Location = new System.Drawing.Point(12, 150);
            this.OvertimeHours.Name = "OvertimeHours";
            this.OvertimeHours.Size = new System.Drawing.Size(107, 17);
            this.OvertimeHours.TabIndex = 16;
            this.OvertimeHours.Text = "Overtime Hours";
            // 
            // HoursWork
            // 
            this.HoursWork.Location = new System.Drawing.Point(216, 117);
            this.HoursWork.Name = "HoursWork";
            this.HoursWork.Size = new System.Drawing.Size(120, 22);
            this.HoursWork.TabIndex = 18;
            // 
            // OvertimeBox
            // 
            this.OvertimeBox.Location = new System.Drawing.Point(215, 150);
            this.OvertimeBox.Name = "OvertimeBox";
            this.OvertimeBox.Size = new System.Drawing.Size(120, 22);
            this.OvertimeBox.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 549);
            this.Controls.Add(this.OvertimeBox);
            this.Controls.Add(this.HoursWork);
            this.Controls.Add(this.OvertimeHours);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HoursWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OvertimeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox EmpID;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label OvertimeHours;
        private System.Windows.Forms.NumericUpDown HoursWork;
        private System.Windows.Forms.NumericUpDown OvertimeBox;
    }
}

