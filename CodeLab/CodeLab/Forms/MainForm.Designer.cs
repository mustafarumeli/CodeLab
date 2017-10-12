namespace CodeLab.Forms
{
    partial class MainForm
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
            this.LblAuth = new System.Windows.Forms.Label();
            this.LblDisc = new System.Windows.Forms.Label();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblContribute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAuth
            // 
            this.LblAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblAuth.AutoSize = true;
            this.LblAuth.Font = new System.Drawing.Font("Calibri", 14F);
            this.LblAuth.Location = new System.Drawing.Point(880, 31);
            this.LblAuth.Name = "LblAuth";
            this.LblAuth.Size = new System.Drawing.Size(128, 23);
            this.LblAuth.TabIndex = 0;
            this.LblAuth.Text = "Login / Register";
            this.LblAuth.Click += new System.EventHandler(this.LblAuth_Click);
            // 
            // LblDisc
            // 
            this.LblDisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblDisc.AutoSize = true;
            this.LblDisc.Location = new System.Drawing.Point(23, 398);
            this.LblDisc.Name = "LblDisc";
            this.LblDisc.Size = new System.Drawing.Size(569, 13);
            this.LblDisc.TabIndex = 1;
            this.LblDisc.Text = "Bu proje Mahmut-san Bilişim Hizmetleri ve Yazılım Ticaret A.Ş. Limited Şirketler " +
    "Grubu tarafından Pervaneh için yapılmıştır";
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSearch.Location = new System.Drawing.Point(156, 181);
            this.TbSearch.MaximumSize = new System.Drawing.Size(1080, 80);
            this.TbSearch.MinimumSize = new System.Drawing.Size(629, 80);
            this.TbSearch.Multiline = true;
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(629, 80);
            this.TbSearch.TabIndex = 2;
            this.TbSearch.Text = "asdas";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackgroundImage = global::CodeLab.Properties.Resources.Glass1;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(782, 181);
            this.BtnSearch.MaximumSize = new System.Drawing.Size(80, 80);
            this.BtnSearch.MinimumSize = new System.Drawing.Size(80, 80);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(80, 80);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LblContribute
            // 
            this.LblContribute.AutoSize = true;
            this.LblContribute.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContribute.Location = new System.Drawing.Point(881, 54);
            this.LblContribute.Name = "LblContribute";
            this.LblContribute.Size = new System.Drawing.Size(80, 18);
            this.LblContribute.TabIndex = 4;
            this.LblContribute.Text = "Contribute";
            this.LblContribute.Click += new System.EventHandler(this.LblContribute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 431);
            this.Controls.Add(this.LblContribute);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LblDisc);
            this.Controls.Add(this.LblAuth);
            this.Name = "MainForm";
            this.Text = "Welcome to CodeLab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAuth;
        private System.Windows.Forms.Label LblDisc;
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblContribute;
    }
}