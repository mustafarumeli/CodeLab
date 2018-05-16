namespace CodeLab.Forms.Auth
{
    partial class PasswordRecovery
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
            this.components = new System.ComponentModel.Container();
            this.LabelTimer = new System.Windows.Forms.Label();
            this.TimerCounter = new System.Windows.Forms.Timer(this.components);
            this.TextBoxGeneratedCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBefore = new System.Windows.Forms.Panel();
            this.TextBoxNewPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPasswordAgain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSend = new CodeLab.Custom_Controls.CustomButton();
            this.PanelPasswordSend = new System.Windows.Forms.Panel();
            this.PanelBefore.SuspendLayout();
            this.PanelPasswordSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Arial", 24F);
            this.LabelTimer.Location = new System.Drawing.Point(113, 9);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(69, 36);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "180";
            // 
            // TimerCounter
            // 
            this.TimerCounter.Interval = 1000;
            this.TimerCounter.Tick += new System.EventHandler(this.TimerCounter_Tick);
            // 
            // TextBoxGeneratedCode
            // 
            this.TextBoxGeneratedCode.Font = new System.Drawing.Font("Arial", 16F);
            this.TextBoxGeneratedCode.Location = new System.Drawing.Point(128, 53);
            this.TextBoxGeneratedCode.Name = "TextBoxGeneratedCode";
            this.TextBoxGeneratedCode.Size = new System.Drawing.Size(189, 32);
            this.TextBoxGeneratedCode.TabIndex = 1;
            this.TextBoxGeneratedCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxGeneratedCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Code";
            // 
            // PanelBefore
            // 
            this.PanelBefore.Controls.Add(this.label1);
            this.PanelBefore.Controls.Add(this.LabelTimer);
            this.PanelBefore.Controls.Add(this.TextBoxGeneratedCode);
            this.PanelBefore.Location = new System.Drawing.Point(10, 63);
            this.PanelBefore.Name = "PanelBefore";
            this.PanelBefore.Size = new System.Drawing.Size(331, 100);
            this.PanelBefore.TabIndex = 0;
            // 
            // TextBoxNewPassword
            // 
            this.TextBoxNewPassword.Font = new System.Drawing.Font("Arial", 16F);
            this.TextBoxNewPassword.Location = new System.Drawing.Point(143, 20);
            this.TextBoxNewPassword.Name = "TextBoxNewPassword";
            this.TextBoxNewPassword.Size = new System.Drawing.Size(189, 32);
            this.TextBoxNewPassword.TabIndex = 0;
            // 
            // TextBoxPasswordAgain
            // 
            this.TextBoxPasswordAgain.Font = new System.Drawing.Font("Arial", 16F);
            this.TextBoxPasswordAgain.Location = new System.Drawing.Point(143, 69);
            this.TextBoxPasswordAgain.Name = "TextBoxPasswordAgain";
            this.TextBoxPasswordAgain.Size = new System.Drawing.Size(189, 32);
            this.TextBoxPasswordAgain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(29, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(-6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Re-Password";
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.Black;
            this.ButtonSend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSend.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.ForeColor = System.Drawing.Color.White;
            this.ButtonSend.Location = new System.Drawing.Point(120, 115);
            this.ButtonSend.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ButtonSend.MinimumSize = new System.Drawing.Size(100, 30);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonSend.Size = new System.Drawing.Size(100, 30);
            this.ButtonSend.TabIndex = 2;
            this.ButtonSend.Text = "Send";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // PanelPasswordSend
            // 
            this.PanelPasswordSend.Controls.Add(this.label2);
            this.PanelPasswordSend.Controls.Add(this.ButtonSend);
            this.PanelPasswordSend.Controls.Add(this.TextBoxNewPassword);
            this.PanelPasswordSend.Controls.Add(this.label3);
            this.PanelPasswordSend.Controls.Add(this.TextBoxPasswordAgain);
            this.PanelPasswordSend.Location = new System.Drawing.Point(2, 179);
            this.PanelPasswordSend.Name = "PanelPasswordSend";
            this.PanelPasswordSend.Size = new System.Drawing.Size(339, 148);
            this.PanelPasswordSend.TabIndex = 1;
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 170);
            this.Controls.Add(this.PanelPasswordSend);
            this.Controls.Add(this.PanelBefore);
            this.Name = "PasswordRecovery";
            this.Text = "PasswordRecovery";
            this.PanelBefore.ResumeLayout(false);
            this.PanelBefore.PerformLayout();
            this.PanelPasswordSend.ResumeLayout(false);
            this.PanelPasswordSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Timer TimerCounter;
        private System.Windows.Forms.TextBox TextBoxGeneratedCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelBefore;
        private System.Windows.Forms.TextBox TextBoxNewPassword;
        private System.Windows.Forms.TextBox TextBoxPasswordAgain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Custom_Controls.CustomButton ButtonSend;
        private System.Windows.Forms.Panel PanelPasswordSend;
    }
}