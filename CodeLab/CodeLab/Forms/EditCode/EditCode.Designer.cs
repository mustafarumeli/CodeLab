namespace CodeLab.Forms
{
    partial class EditCode
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
            this.TbCode = new System.Windows.Forms.RichTextBox();
            this.BtnComplete = new CodeLab.Custom_Controls.CustomButton();
            this.SuspendLayout();
            // 
            // TbCode
            // 
            this.TbCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbCode.Location = new System.Drawing.Point(20, 67);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(665, 436);
            this.TbCode.TabIndex = 0;
            this.TbCode.Text = "";
            // 
            // BtnComplete
            // 
            this.BtnComplete.BackColor = System.Drawing.Color.Black;
            this.BtnComplete.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComplete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComplete.ForeColor = System.Drawing.Color.White;
            this.BtnComplete.Location = new System.Drawing.Point(585, 34);
            this.BtnComplete.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnComplete.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Padding = new System.Windows.Forms.Padding(3);
            this.BtnComplete.Size = new System.Drawing.Size(100, 30);
            this.BtnComplete.TabIndex = 1;
            this.BtnComplete.Text = "Complete";
            this.BtnComplete.UseVisualStyleBackColor = false;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // InsertCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 523);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.TbCode);
            this.Name = "InsertCode";
            this.Text = "Insert Code";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TbCode;
        private Custom_Controls.CustomButton BtnComplete;
    }
}