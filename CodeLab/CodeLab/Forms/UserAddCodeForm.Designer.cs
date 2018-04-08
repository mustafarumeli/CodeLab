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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddCodeForm));
            this.ClbLanguages = new System.Windows.Forms.CheckedListBox();
            this.BtnAddCode = new CodeLab.Custom_Controls.CustomButton();
            this.TxtCodeTitle = new System.Windows.Forms.TextBox();
            this.TxtCodeDescription = new System.Windows.Forms.TextBox();
            this.TxtCodeTags = new System.Windows.Forms.TextBox();
            this.BtnPicture = new CodeLab.Custom_Controls.CustomButton();
            this.SuspendLayout();
            // 
            // ClbLanguages
            // 
            this.ClbLanguages.FormattingEnabled = true;
            this.ClbLanguages.HorizontalExtent = 3;
            this.ClbLanguages.Location = new System.Drawing.Point(23, 140);
            this.ClbLanguages.Name = "ClbLanguages";
            this.ClbLanguages.Size = new System.Drawing.Size(397, 49);
            this.ClbLanguages.TabIndex = 4;
            // 
            // BtnAddCode
            // 
            this.BtnAddCode.BackColor = System.Drawing.Color.Black;
            this.BtnAddCode.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAddCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCode.ForeColor = System.Drawing.Color.White;
            this.BtnAddCode.Location = new System.Drawing.Point(55, 445);
            this.BtnAddCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAddCode.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnAddCode.Name = "BtnAddCode";
            this.BtnAddCode.Padding = new System.Windows.Forms.Padding(3);
            this.BtnAddCode.Size = new System.Drawing.Size(327, 30);
            this.BtnAddCode.TabIndex = 1;
            this.BtnAddCode.Text = "Insert Code";
            this.BtnAddCode.UseVisualStyleBackColor = false;
            this.BtnAddCode.Click += new System.EventHandler(this.CbtnSend_ClickAsync);
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
            this.TxtCodeDescription.Location = new System.Drawing.Point(23, 195);
            this.TxtCodeDescription.Multiline = true;
            this.TxtCodeDescription.Name = "TxtCodeDescription";
            this.TxtCodeDescription.Size = new System.Drawing.Size(397, 156);
            this.TxtCodeDescription.TabIndex = 7;
            this.TxtCodeDescription.Text = "Code Description";
            // 
            // TxtCodeTags
            // 
            this.TxtCodeTags.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodeTags.Location = new System.Drawing.Point(55, 403);
            this.TxtCodeTags.Name = "TxtCodeTags";
            this.TxtCodeTags.Size = new System.Drawing.Size(327, 22);
            this.TxtCodeTags.TabIndex = 8;
            this.TxtCodeTags.Text = "Tags";
            // 
            // BtnPicture
            // 
            this.BtnPicture.BackColor = System.Drawing.Color.Black;
            this.BtnPicture.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPicture.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPicture.ForeColor = System.Drawing.Color.White;
            this.BtnPicture.Location = new System.Drawing.Point(55, 370);
            this.BtnPicture.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnPicture.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnPicture.Name = "BtnPicture";
            this.BtnPicture.Padding = new System.Windows.Forms.Padding(3);
            this.BtnPicture.Size = new System.Drawing.Size(327, 30);
            this.BtnPicture.TabIndex = 1;
            this.BtnPicture.Text = "Add Picture";
            this.BtnPicture.UseVisualStyleBackColor = false;
            this.BtnPicture.Click += new System.EventHandler(this.BtnPicture_Click);
            // 
            // UserAddCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 495);
            this.Controls.Add(this.TxtCodeTags);
            this.Controls.Add(this.TxtCodeDescription);
            this.Controls.Add(this.TxtCodeTitle);
            this.Controls.Add(this.ClbLanguages);
            this.Controls.Add(this.BtnPicture);
            this.Controls.Add(this.BtnAddCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAddCodeForm";
            this.Text = "Add Your Code Here";
            this.Load += new System.EventHandler(this.UserAddCodeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Custom_Controls.CustomButton BtnAddCode;
        private System.Windows.Forms.CheckedListBox ClbLanguages;
        private System.Windows.Forms.TextBox TxtCodeTitle;
        private System.Windows.Forms.TextBox TxtCodeDescription;
        private System.Windows.Forms.TextBox TxtCodeTags;
        private Custom_Controls.CustomButton BtnPicture;
    }
}