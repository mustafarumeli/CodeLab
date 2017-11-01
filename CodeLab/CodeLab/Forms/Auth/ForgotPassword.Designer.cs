namespace CodeLab.Forms.Auth
{
    partial class ForgotPassword
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccept = new CodeLab.Custom_Controls.CustomButton();
            this.PUser = new System.Windows.Forms.Panel();
            this.GBAuthentication = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBAnswer = new System.Windows.Forms.TextBox();
            this.PUser.SuspendLayout();
            this.GBAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(3, 26);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(238, 20);
            this.TBUser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username or E-Mail";
            // 
            // BtnAccept
            // 
            this.BtnAccept.BackColor = System.Drawing.Color.Black;
            this.BtnAccept.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccept.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccept.ForeColor = System.Drawing.Color.White;
            this.BtnAccept.Location = new System.Drawing.Point(21, 250);
            this.BtnAccept.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAccept.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Padding = new System.Windows.Forms.Padding(3);
            this.BtnAccept.Size = new System.Drawing.Size(254, 30);
            this.BtnAccept.TabIndex = 2;
            this.BtnAccept.Text = "Continue";
            this.BtnAccept.UseVisualStyleBackColor = false;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_ClickAsync);
            // 
            // PUser
            // 
            this.PUser.Controls.Add(this.GBAuthentication);
            this.PUser.Controls.Add(this.TBUser);
            this.PUser.Controls.Add(this.label1);
            this.PUser.Location = new System.Drawing.Point(21, 63);
            this.PUser.Name = "PUser";
            this.PUser.Size = new System.Drawing.Size(256, 184);
            this.PUser.TabIndex = 3;
            // 
            // GBAuthentication
            // 
            this.GBAuthentication.Controls.Add(this.label3);
            this.GBAuthentication.Controls.Add(this.TBQuestion);
            this.GBAuthentication.Controls.Add(this.label2);
            this.GBAuthentication.Controls.Add(this.TBAnswer);
            this.GBAuthentication.Location = new System.Drawing.Point(6, 52);
            this.GBAuthentication.Name = "GBAuthentication";
            this.GBAuthentication.Size = new System.Drawing.Size(248, 129);
            this.GBAuthentication.TabIndex = 6;
            this.GBAuthentication.TabStop = false;
            this.GBAuthentication.Text = "Authenication";
            this.GBAuthentication.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Answer";
            // 
            // TBQuestion
            // 
            this.TBQuestion.Enabled = false;
            this.TBQuestion.Location = new System.Drawing.Point(9, 39);
            this.TBQuestion.Name = "TBQuestion";
            this.TBQuestion.Size = new System.Drawing.Size(235, 20);
            this.TBQuestion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Your Security Quesion";
            // 
            // TBAnswer
            // 
            this.TBAnswer.Location = new System.Drawing.Point(9, 87);
            this.TBAnswer.Name = "TBAnswer";
            this.TBAnswer.Size = new System.Drawing.Size(235, 20);
            this.TBAnswer.TabIndex = 3;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.PUser);
            this.Controls.Add(this.BtnAccept);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.PUser.ResumeLayout(false);
            this.PUser.PerformLayout();
            this.GBAuthentication.ResumeLayout(false);
            this.GBAuthentication.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Label label1;
        private Custom_Controls.CustomButton BtnAccept;
        private System.Windows.Forms.Panel PUser;
        private System.Windows.Forms.GroupBox GBAuthentication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBAnswer;
    }
}