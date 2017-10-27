namespace CodeLab.Forms
{
    partial class Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code));
            this.PBpicture = new System.Windows.Forms.PictureBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.TbCode = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PBpicture
            // 
            this.PBpicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBpicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBpicture.Location = new System.Drawing.Point(688, 74);
            this.PBpicture.Name = "PBpicture";
            this.PBpicture.Size = new System.Drawing.Size(419, 471);
            this.PBpicture.TabIndex = 0;
            this.PBpicture.TabStop = false;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(23, 623);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(162, 18);
            this.LblDesc.TabIndex = 1;
            this.LblDesc.Text = "Put Description here...";
            // 
            // TbCode
            // 
            this.TbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TbCode.Font = new System.Drawing.Font("Arial", 12F);
            this.TbCode.Location = new System.Drawing.Point(37, 74);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(618, 519);
            this.TbCode.TabIndex = 2;
            this.TbCode.Text = "Put Code Here";
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 661);
            this.Controls.Add(this.TbCode);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.PBpicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 661);
            this.MinimumSize = new System.Drawing.Size(1162, 661);
            this.Name = "Code";
            this.Text = "Code";
            this.Load += new System.EventHandler(this.Code_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBpicture;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.RichTextBox TbCode;
    }
}