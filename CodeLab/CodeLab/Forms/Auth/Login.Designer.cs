namespace CodeLab.Forms.Auth
{
    partial class Login
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
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.LblRegister = new System.Windows.Forms.Label();
            this.LoginButton = new CodeLab.Custom_Controls.CustomButton();
            this.SuspendLayout();
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("Arial", 12F);
            this.LblUserName.Location = new System.Drawing.Point(12, 116);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(95, 18);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "User Name :";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.LblPassword.Location = new System.Drawing.Point(12, 175);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(86, 18);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Password :";
            // 
            // TbUserName
            // 
            this.TbUserName.Font = new System.Drawing.Font("Arial", 18.5F);
            this.TbUserName.Location = new System.Drawing.Point(113, 107);
            this.TbUserName.Multiline = true;
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(228, 36);
            this.TbUserName.TabIndex = 2;
            this.TbUserName.Text = "User Name";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Culture = new System.Globalization.CultureInfo("tr-TR");
            this.maskedTextBox1.Font = new System.Drawing.Font("Arial", 18.5F);
            this.maskedTextBox1.Location = new System.Drawing.Point(113, 164);
            this.maskedTextBox1.MaximumSize = new System.Drawing.Size(228, 36);
            this.maskedTextBox1.MinimumSize = new System.Drawing.Size(228, 36);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PasswordChar = '*';
            this.maskedTextBox1.Size = new System.Drawing.Size(228, 36);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // LblRegister
            // 
            this.LblRegister.AutoSize = true;
            this.LblRegister.Font = new System.Drawing.Font("Arial Black", 12F);
            this.LblRegister.Location = new System.Drawing.Point(109, 315);
            this.LblRegister.Name = "LblRegister";
            this.LblRegister.Size = new System.Drawing.Size(207, 23);
            this.LblRegister.TabIndex = 4;
            this.LblRegister.Text = "Click Here To Register";
            this.LblRegister.Click += new System.EventHandler(this.LblRegister_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Green;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(113, 229);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LoginButton.MinimumSize = new System.Drawing.Size(100, 30);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Padding = new System.Windows.Forms.Padding(3);
            this.LoginButton.Size = new System.Drawing.Size(193, 57);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 371);
            this.Controls.Add(this.LblRegister);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.TbUserName);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LoginButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 371);
            this.MinimumSize = new System.Drawing.Size(439, 371);
            this.Name = "Login";
            this.Text = "Login To Your Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls.CustomButton LoginButton;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label LblRegister;
    }
}