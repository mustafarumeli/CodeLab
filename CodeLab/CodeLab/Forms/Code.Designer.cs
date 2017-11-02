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
            this.BtnRun = new MetroFramework.Controls.MetroButton();
            this.BtnOriginal = new CodeLab.Custom_Controls.CustomButton();
            TbStatus = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PBpicture
            // 
            this.PBpicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBpicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PBpicture.Location = new System.Drawing.Point(688, 193);
            this.PBpicture.Name = "PBpicture";
            this.PBpicture.Size = new System.Drawing.Size(419, 352);
            this.PBpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PBpicture.TabIndex = 0;
            this.PBpicture.TabStop = false;
            this.PBpicture.Tag = "AsyncItem";
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.Location = new System.Drawing.Point(23, 623);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(0, 18);
            this.LblDesc.TabIndex = 1;
            this.LblDesc.Tag = "AsyncItem";
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
            this.TbCode.Tag = "AsyncItem";
            this.TbCode.Text = "";
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(566, 45);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(89, 23);
            this.BtnRun.TabIndex = 3;
            this.BtnRun.Text = "Run ->";
            this.BtnRun.UseSelectable = true;
            this.BtnRun.Visible = false;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnOriginal
            // 
            this.BtnOriginal.BackColor = System.Drawing.Color.Black;
            this.BtnOriginal.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOriginal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOriginal.ForeColor = System.Drawing.Color.White;
            this.BtnOriginal.Location = new System.Drawing.Point(377, 41);
            this.BtnOriginal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOriginal.MinimumSize = new System.Drawing.Size(100, 30);
            this.BtnOriginal.Name = "BtnOriginal";
            this.BtnOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.BtnOriginal.Size = new System.Drawing.Size(181, 30);
            this.BtnOriginal.TabIndex = 4;
            this.BtnOriginal.Text = "Convert to original";
            this.BtnOriginal.UseVisualStyleBackColor = false;
            this.BtnOriginal.Click += new System.EventHandler(this.BtnOriginal_Click);
            // 
            // TbStatus
            // 
            TbStatus.ForeColor = System.Drawing.Color.Red;
            TbStatus.Location = new System.Drawing.Point(688, 74);
            TbStatus.Name = "TbStatus";
            TbStatus.Size = new System.Drawing.Size(419, 102);
            TbStatus.TabIndex = 5;
            TbStatus.Text = "";
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 661);
            this.Controls.Add(TbStatus);
            this.Controls.Add(this.BtnOriginal);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.TbCode);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.PBpicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1162, 661);
            this.MinimumSize = new System.Drawing.Size(1162, 661);
            this.Name = "Code";
            this.Load += new System.EventHandler(this.Code_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.PBpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBpicture;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.RichTextBox TbCode;
        private MetroFramework.Controls.MetroButton BtnRun;
        private Custom_Controls.CustomButton BtnOriginal;
        public static System.Windows.Forms.RichTextBox TbStatus;
    }
}