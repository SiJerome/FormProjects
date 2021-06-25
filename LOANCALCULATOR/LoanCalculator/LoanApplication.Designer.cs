
namespace LoanCalculator
{
    partial class LoanApplication
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDecline = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(408, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 27);
            this.panel1.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(31, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(51, 20);
            this.txtID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(558, 172);
            this.dataGridView1.TabIndex = 43;
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnDecline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecline.Location = new System.Drawing.Point(220, 351);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(182, 40);
            this.btnDecline.TabIndex = 41;
            this.btnDecline.Text = "DECLINE";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // btnTerminate
            // 
            this.btnTerminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnTerminate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminate.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminate.Location = new System.Drawing.Point(409, 351);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(182, 40);
            this.btnTerminate.TabIndex = 42;
            this.btnTerminate.Text = "TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = false;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
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
            this.panel3.Size = new System.Drawing.Size(624, 59);
            this.panel3.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOAN APPLICATION";
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
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 33);
            this.panel2.TabIndex = 38;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(503, 318);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 26);
            this.btnFind.TabIndex = 42;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(32, 351);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(182, 40);
            this.btnApprove.TabIndex = 41;
            this.btnApprove.Text = "APPROVE";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(34, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(45, 26);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.txtAccountNum);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Location = new System.Drawing.Point(64, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 27);
            this.panel5.TabIndex = 46;
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Location = new System.Drawing.Point(122, 4);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(213, 20);
            this.txtAccountNum.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoSize = true;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSearch.Location = new System.Drawing.Point(7, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(115, 16);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.Text = "Search Account #:";
            // 
            // LoanApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 405);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "LoanApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanApplication";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Label txtSearch;
    }
}