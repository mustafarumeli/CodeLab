namespace CodeLab.Forms
{
    partial class UserAddCodeForm
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
            this.RtxtCodes = new System.Windows.Forms.RichTextBox();
            this.ClbLanguages = new System.Windows.Forms.CheckedListBox();
            this.CbtnSend = new CodeLab.Custom_Controls.CustomButton();
            this.TxtCodeTitle = new System.Windows.Forms.TextBox();
            this.TxtCodeDescription = new System.Windows.Forms.TextBox();
            this.TxtCodeTags = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RtxtCodes
            // 
            this.RtxtCodes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtCodes.Location = new System.Drawing.Point(23, 138);
            this.RtxtCodes.Name = "RtxtCodes";
            this.RtxtCodes.Size = new System.Drawing.Size(397, 287);
            this.RtxtCodes.TabIndex = 0;
            this.RtxtCodes.Text = "Code";
            // 
            // ClbLanguages
            // 
            this.ClbLanguages.FormattingEnabled = true;
            this.ClbLanguages.HorizontalExtent = 3;
            this.ClbLanguages.Items.AddRange(new object[] {
            "C#",
            "Java",
            "C++",
            "C",
            "JavaScript"});
            this.ClbLanguages.Location = new System.Drawing.Point(440, 343);
            this.ClbLanguages.Name = "ClbLanguages";
            this.ClbLanguages.Size = new System.Drawing.Size(327, 49);
            this.ClbLanguages.TabIndex = 4;
            // 
            // CbtnSend
            // 
            this.CbtnSend.BackColor = System.Drawing.Color.Black;
            this.CbtnSend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CbtnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbtnSend.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbtnSend.ForeColor = System.Drawing.Color.White;
            this.CbtnSend.Location = new System.Drawing.Point(440, 395);
            this.CbtnSend.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CbtnSend.MinimumSize = new System.Drawing.Size(100, 30);
            this.CbtnSend.Name = "CbtnSend";
            this.CbtnSend.Padding = new System.Windows.Forms.Padding(3);
            this.CbtnSend.Size = new System.Drawing.Size(327, 30);
            this.CbtnSend.TabIndex = 1;
            this.CbtnSend.Text = "Send";
            this.CbtnSend.UseVisualStyleBackColor = false;
            this.CbtnSend.Click += new System.EventHandler(this.CbtnSend_Click);
            // 
            // TxtCodeTitle
            // 
            this.TxtCodeTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeTitle.Location = new System.Drawing.Point(23, 112);
            this.TxtCodeTitle.Name = "TxtCodeTitle";
            this.TxtCodeTitle.Size = new System.Drawing.Size(397, 22);
            this.TxtCodeTitle.TabIndex = 6;
            this.TxtCodeTitle.Text = "Code Title";
            // 
            // TxtCodeDescription
            // 
            this.TxtCodeDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeDescription.Location = new System.Drawing.Point(440, 112);
            this.TxtCodeDescription.Multiline = true;
            this.TxtCodeDescription.Name = "TxtCodeDescription";
            this.TxtCodeDescription.Size = new System.Drawing.Size(327, 196);
            this.TxtCodeDescription.TabIndex = 7;
            this.TxtCodeDescription.Text = "Code Description";
            // 
            // TxtCodeTags
            // 
            this.TxtCodeTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeTags.Location = new System.Drawing.Point(440, 317);
            this.TxtCodeTags.Name = "TxtCodeTags";
            this.TxtCodeTags.Size = new System.Drawing.Size(327, 22);
            this.TxtCodeTags.TabIndex = 8;
            this.TxtCodeTags.Text = "Tags";
            // 
            // UserAddCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 448);
            this.Controls.Add(this.TxtCodeTags);
            this.Controls.Add(this.TxtCodeDescription);
            this.Controls.Add(this.TxtCodeTitle);
            this.Controls.Add(this.ClbLanguages);
            this.Controls.Add(this.CbtnSend);
            this.Controls.Add(this.RtxtCodes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 448);
            this.MinimumSize = new System.Drawing.Size(790, 448);
            this.Name = "UserAddCodeForm";
            this.Text = "Add Your Code Here";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RtxtCodes;
        private Custom_Controls.CustomButton CbtnSend;
        private System.Windows.Forms.CheckedListBox ClbLanguages;
        private System.Windows.Forms.TextBox TxtCodeTitle;
        private System.Windows.Forms.TextBox TxtCodeDescription;
        private System.Windows.Forms.TextBox TxtCodeTags;
    }
}