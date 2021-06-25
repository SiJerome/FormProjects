namespace LoanCalculator
{
    partial class MembersMenu
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
            this.lblMembershipBond = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnApplyForLoan = new System.Windows.Forms.Button();
            this.btnViewLoanDetails = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 33);
            this.panel2.TabIndex = 1;
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
            this.panel3.Size = new System.Drawing.Size(688, 59);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "DASHBOARD";
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
            // lblMembershipBond
            // 
            this.lblMembershipBond.AutoSize = true;
            this.lblMembershipBond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipBond.Location = new System.Drawing.Point(174, 151);
            this.lblMembershipBond.Name = "lblMembershipBond";
            this.lblMembershipBond.Size = new System.Drawing.Size(77, 16);
            this.lblMembershipBond.TabIndex = 25;
            this.lblMembershipBond.Text = "Display Bal";
            this.lblMembershipBond.Click += new System.EventHandler(this.lblMembershipBond_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(34, 147);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(134, 27);
            this.panel10.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Membership Bond";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(174, 118);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(85, 16);
            this.lblAccountNumber.TabIndex = 22;
            this.lblAccountNumber.Text = "Display Num";
            this.lblAccountNumber.Click += new System.EventHandler(this.lblAccountNumber_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(34, 114);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(134, 27);
            this.panel11.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(7, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Account Number:";
            // 
            // btnApplyForLoan
            // 
            this.btnApplyForLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnApplyForLoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnApplyForLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyForLoan.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyForLoan.Location = new System.Drawing.Point(342, 114);
            this.btnApplyForLoan.Name = "btnApplyForLoan";
            this.btnApplyForLoan.Size = new System.Drawing.Size(291, 40);
            this.btnApplyForLoan.TabIndex = 26;
            this.btnApplyForLoan.Text = "APPLY FOR LOAN";
            this.btnApplyForLoan.UseVisualStyleBackColor = false;
            this.btnApplyForLoan.Click += new System.EventHandler(this.btnApplyForLoan_Click);
            // 
            // btnViewLoanDetails
            // 
            this.btnViewLoanDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnViewLoanDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnViewLoanDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewLoanDetails.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLoanDetails.Location = new System.Drawing.Point(342, 160);
            this.btnViewLoanDetails.Name = "btnViewLoanDetails";
            this.btnViewLoanDetails.Size = new System.Drawing.Size(291, 40);
            this.btnViewLoanDetails.TabIndex = 26;
            this.btnViewLoanDetails.Text = "VIEW LOAN DETAILS";
            this.btnViewLoanDetails.UseVisualStyleBackColor = false;
            this.btnViewLoanDetails.Click += new System.EventHandler(this.btnViewLoanDetails_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(78)))), ((int)(((byte)(53)))));
            this.btnViewProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(56)))), ((int)(((byte)(39)))));
            this.btnViewProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProfile.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(342, 206);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(291, 40);
            this.btnViewProfile.TabIndex = 26;
            this.btnViewProfile.Text = "VIEW PROFILE";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // MembersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 273);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnViewLoanDetails);
            this.Controls.Add(this.btnApplyForLoan);
            this.Controls.Add(this.lblMembershipBond);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "MembersMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members Menu";
            this.Load += new System.EventHandler(this.MembersMenu_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblMembershipBond;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApplyForLoan;
        private System.Windows.Forms.Button btnViewLoanDetails;
        private System.Windows.Forms.Button btnViewProfile;
    }
}