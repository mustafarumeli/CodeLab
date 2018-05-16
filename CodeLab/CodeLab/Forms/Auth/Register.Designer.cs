namespace CodeLab.Forms.Auth
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.TbName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSecurityAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LRePassword = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.LUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbRePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LSecurityAnswer = new System.Windows.Forms.Label();
            this.CbSecurityQuestion = new MetroFramework.Controls.MetroComboBox();
            this.BtnApply = new CodeLab.Custom_Controls.CustomButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Arial", 12F);
            this.TbName.Location = new System.Drawing.Point(140, 103);
            this.TbName.Margin = new System.Windows.Forms.Padding(4);
            this.TbName.MaxLength = 25;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(148, 26);
            this.TbName.TabIndex = 0;
            this.TbName.Leave += new System.EventHandler(this.TbName_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(78, 108);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 18);
            this.label.TabIndex = 0;
            this.label.Text = "Name";
            // 
            // TbEmail
            // 
            this.TbEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.TbEmail.Location = new System.Drawing.Point(140, 139);
            this.TbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TbEmail.MaxLength = 25;
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(148, 26);
            this.TbEmail.TabIndex = 1;
            this.TbEmail.Leave += new System.EventHandler(this.TbEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-4, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Security Question";
            // 
            // TbSecurityAnswer
            // 
            this.TbSecurityAnswer.Font = new System.Drawing.Font("Arial", 12F);
            this.TbSecurityAnswer.Location = new System.Drawing.Point(140, 213);
            this.TbSecurityAnswer.Margin = new System.Windows.Forms.Padding(4);
            this.TbSecurityAnswer.MaxLength = 15;
            this.TbSecurityAnswer.Name = "TbSecurityAnswer";
            this.TbSecurityAnswer.Size = new System.Drawing.Size(148, 26);
            this.TbSecurityAnswer.TabIndex = 3;
            this.TbSecurityAnswer.Leave += new System.EventHandler(this.TbSecurityAnswer_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Security Answer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LRePassword);
            this.groupBox1.Controls.Add(this.LPassword);
            this.groupBox1.Controls.Add(this.LUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbRePassword);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbUserName);
            this.groupBox1.Location = new System.Drawing.Point(10, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(910, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Options";
            // 
            // LRePassword
            // 
            this.LRePassword.AutoSize = true;
            this.LRePassword.ForeColor = System.Drawing.Color.Red;
            this.LRePassword.Location = new System.Drawing.Point(306, 116);
            this.LRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRePassword.Name = "LRePassword";
            this.LRePassword.Size = new System.Drawing.Size(0, 18);
            this.LRePassword.TabIndex = 8;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.ForeColor = System.Drawing.Color.Red;
            this.LPassword.Location = new System.Drawing.Point(306, 80);
            this.LPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(0, 18);
            this.LPassword.TabIndex = 5;
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.ForeColor = System.Drawing.Color.Red;
            this.LUsername.Location = new System.Drawing.Point(306, 44);
            this.LUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(0, 18);
            this.LUsername.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Re-Password";
            // 
            // TbRePassword
            // 
            this.TbRePassword.Font = new System.Drawing.Font("Arial", 12F);
            this.TbRePassword.Location = new System.Drawing.Point(147, 108);
            this.TbRePassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbRePassword.MaxLength = 20;
            this.TbRePassword.Name = "TbRePassword";
            this.TbRePassword.Size = new System.Drawing.Size(148, 26);
            this.TbRePassword.TabIndex = 7;
            this.TbRePassword.UseSystemPasswordChar = true;
            this.TbRePassword.Leave += new System.EventHandler(this.TbRePassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.TbPassword.Location = new System.Drawing.Point(147, 72);
            this.TbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TbPassword.MaxLength = 20;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(148, 26);
            this.TbPassword.TabIndex = 4;
            this.TbPassword.UseSystemPasswordChar = true;
            this.TbPassword.Leave += new System.EventHandler(this.TbPassword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // TbUserName
            // 
            this.TbUserName.Font = new System.Drawing.Font("Arial", 12F);
            this.TbUserName.Location = new System.Drawing.Point(147, 36);
            this.TbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TbUserName.MaxLength = 15;
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(148, 26);
            this.TbUserName.TabIndex = 1;
            this.TbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.ForeColor = System.Drawing.Color.Red;
            this.LName.Location = new System.Drawing.Point(298, 108);
            this.LName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(0, 18);
            this.LName.TabIndex = 0;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.ForeColor = System.Drawing.Color.Red;
            this.LEmail.Location = new System.Drawing.Point(298, 144);
            this.LEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(0, 18);
            this.LEmail.TabIndex = 1;
            // 
            // LSecurityAnswer
            // 
            this.LSecurityAnswer.AutoSize = true;
            this.LSecurityAnswer.ForeColor = System.Drawing.Color.Red;
            this.LSecurityAnswer.Location = new System.Drawing.Point(298, 217);
            this.LSecurityAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LSecurityAnswer.Name = "LSecurityAnswer";
            this.LSecurityAnswer.Size = new System.Drawing.Size(0, 18);
            this.LSecurityAnswer.TabIndex = 3;
            // 
            // CbSecurityQuestion
            // 
            this.CbSecurityQuestion.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CbSecurityQuestion.FormattingEnabled = true;
            this.CbSecurityQuestion.ItemHeight = 19;
            this.CbSecurityQuestion.Items.AddRange(new object[] {
            "Name of your first pet",
            "Name of your first grade teacher",
            "Name of your favorite T.V. show",
            "Name of your favorite sport",
            "Your favorite colour",
            "Your mother\'s maiden name",
            "Your lucky number"});
            this.CbSecurityQuestion.Location = new System.Drawing.Point(140, 173);
            this.CbSecurityQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.CbSecurityQuestion.Name = "CbSecurityQuestion";
            this.CbSecurityQuestion.Size = new System.Drawing.Size(322, 25);
            this.CbSecurityQuestion.TabIndex = 2;
            this.CbSecurityQuestion.UseSelectable = true;
            // 
            // BtnApply
            // 
            this.BtnApply.BackColor = System.Drawing.Color.Black;
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApply.ForeColor = System.Drawing.Color.White;
            this.BtnApply.Location = new System.Drawing.Point(319, 482);
            this.BtnApply.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.BtnApply.MinimumSize = new System.Drawing.Size(150, 42);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Padding = new System.Windows.Forms.Padding(4);
            this.BtnApply.Size = new System.Drawing.Size(150, 48);
            this.BtnApply.TabIndex = 5;
            this.BtnApply.Text = "Register";
            this.BtnApply.UseVisualStyleBackColor = false;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 590);
            this.Controls.Add(this.CbSecurityQuestion);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.LSecurityAnswer);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSecurityAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TbName);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Register";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbSecurityAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbRePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.Label LRePassword;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.Label LUsername;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LSecurityAnswer;
        private Custom_Controls.CustomButton BtnApply;
        private MetroFramework.Controls.MetroComboBox CbSecurityQuestion;
    }
}