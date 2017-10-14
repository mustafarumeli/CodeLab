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
            this.BtnApply = new CodeLab.Custom_Controls.CustomButton();
            this.CbSecurityQuestion = new MetroFramework.Controls.MetroComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(100, 63);
            this.TbName.MaxLength = 25;
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 20);
            this.TbName.TabIndex = 0;
            this.TbName.Leave += new System.EventHandler(this.TbName_Leave);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(59, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Name";
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(100, 89);
            this.TbEmail.MaxLength = 25;
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(100, 20);
            this.TbEmail.TabIndex = 2;
            this.TbEmail.Leave += new System.EventHandler(this.TbEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Security Question";
            // 
            // TbSecurityAnswer
            // 
            this.TbSecurityAnswer.Location = new System.Drawing.Point(100, 142);
            this.TbSecurityAnswer.MaxLength = 15;
            this.TbSecurityAnswer.Name = "TbSecurityAnswer";
            this.TbSecurityAnswer.Size = new System.Drawing.Size(100, 20);
            this.TbSecurityAnswer.TabIndex = 6;
            this.TbSecurityAnswer.Leave += new System.EventHandler(this.TbSecurityAnswer_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 7;
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
            this.groupBox1.Location = new System.Drawing.Point(7, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Options";
            // 
            // LRePassword
            // 
            this.LRePassword.AutoSize = true;
            this.LRePassword.ForeColor = System.Drawing.Color.Red;
            this.LRePassword.Location = new System.Drawing.Point(199, 74);
            this.LRePassword.Name = "LRePassword";
            this.LRePassword.Size = new System.Drawing.Size(0, 13);
            this.LRePassword.TabIndex = 15;
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.ForeColor = System.Drawing.Color.Red;
            this.LPassword.Location = new System.Drawing.Point(199, 48);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(0, 13);
            this.LPassword.TabIndex = 14;
            // 
            // LUsername
            // 
            this.LUsername.AutoSize = true;
            this.LUsername.ForeColor = System.Drawing.Color.Red;
            this.LUsername.Location = new System.Drawing.Point(199, 22);
            this.LUsername.Name = "LUsername";
            this.LUsername.Size = new System.Drawing.Size(0, 13);
            this.LUsername.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Re-Password";
            // 
            // TbRePassword
            // 
            this.TbRePassword.Location = new System.Drawing.Point(93, 71);
            this.TbRePassword.MaxLength = 20;
            this.TbRePassword.Name = "TbRePassword";
            this.TbRePassword.Size = new System.Drawing.Size(100, 20);
            this.TbRePassword.TabIndex = 12;
            this.TbRePassword.UseSystemPasswordChar = true;
            this.TbRePassword.Leave += new System.EventHandler(this.TbRePassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(93, 45);
            this.TbPassword.MaxLength = 20;
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(100, 20);
            this.TbPassword.TabIndex = 10;
            this.TbPassword.UseSystemPasswordChar = true;
            this.TbPassword.Leave += new System.EventHandler(this.TbPassword_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Name";
            // 
            // TbUserName
            // 
            this.TbUserName.Location = new System.Drawing.Point(93, 19);
            this.TbUserName.MaxLength = 15;
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(100, 20);
            this.TbUserName.TabIndex = 9;
            this.TbUserName.Leave += new System.EventHandler(this.TbUserName_Leave);
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.ForeColor = System.Drawing.Color.Red;
            this.LName.Location = new System.Drawing.Point(206, 66);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(0, 13);
            this.LName.TabIndex = 9;
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.ForeColor = System.Drawing.Color.Red;
            this.LEmail.Location = new System.Drawing.Point(206, 92);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(0, 13);
            this.LEmail.TabIndex = 10;
            // 
            // LSecurityAnswer
            // 
            this.LSecurityAnswer.AutoSize = true;
            this.LSecurityAnswer.ForeColor = System.Drawing.Color.Red;
            this.LSecurityAnswer.Location = new System.Drawing.Point(206, 145);
            this.LSecurityAnswer.Name = "LSecurityAnswer";
            this.LSecurityAnswer.Size = new System.Drawing.Size(0, 13);
            this.LSecurityAnswer.TabIndex = 11;
            // 
            // BtnApply
            // 
            this.BtnApply.BackColor = System.Drawing.Color.Black;
            this.BtnApply.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApply.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApply.ForeColor = System.Drawing.Color.White;
            this.BtnApply.Location = new System.Drawing.Point(100, 341);
            this.BtnApply.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnApply.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Padding = new System.Windows.Forms.Padding(3);
            this.BtnApply.Size = new System.Drawing.Size(100, 35);
            this.BtnApply.TabIndex = 12;
            this.BtnApply.Text = "Register";
            this.BtnApply.UseVisualStyleBackColor = false;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
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
            this.CbSecurityQuestion.Location = new System.Drawing.Point(100, 113);
            this.CbSecurityQuestion.Name = "CbSecurityQuestion";
            this.CbSecurityQuestion.Size = new System.Drawing.Size(216, 25);
            this.CbSecurityQuestion.TabIndex = 13;
            this.CbSecurityQuestion.UseSelectable = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 612);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(438, 612);
            this.MinimumSize = new System.Drawing.Size(438, 612);
            this.Name = "Register";
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