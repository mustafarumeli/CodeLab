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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.clbLanguages = new System.Windows.Forms.CheckedListBox();
            this.PbContribute = new System.Windows.Forms.PictureBox();
            this.PbLoginRegister = new System.Windows.Forms.PictureBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbContribute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoginRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.Font = new System.Drawing.Font("Arial", 42F);
            this.TbSearch.ForeColor = System.Drawing.Color.Silver;
            this.TbSearch.Location = new System.Drawing.Point(156, 202);
            this.TbSearch.MaximumSize = new System.Drawing.Size(1080, 80);
            this.TbSearch.MinimumSize = new System.Drawing.Size(629, 80);
            this.TbSearch.Multiline = true;
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(629, 80);
            this.TbSearch.TabIndex = 0;
            this.TbSearch.Text = "Search here...";
            this.TbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbSearch.Enter += new System.EventHandler(this.TbSearch_Enter);
            // 
            // clbLanguages
            // 
            this.clbLanguages.FormattingEnabled = true;
            this.clbLanguages.Items.AddRange(new object[] {
            ""});
            this.clbLanguages.Location = new System.Drawing.Point(156, 288);
            this.clbLanguages.MultiColumn = true;
            this.clbLanguages.Name = "clbLanguages";
            this.clbLanguages.Size = new System.Drawing.Size(706, 19);
            this.clbLanguages.TabIndex = 2;
            // 
            // PbContribute
            // 
            this.PbContribute.Image = global::CodeLab.Properties.Resources.file__1_;
            this.PbContribute.Location = new System.Drawing.Point(926, 23);
            this.PbContribute.Name = "PbContribute";
            this.PbContribute.Size = new System.Drawing.Size(48, 48);
            this.PbContribute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbContribute.TabIndex = 6;
            this.PbContribute.TabStop = false;
            this.PbContribute.Visible = false;
            this.PbContribute.Click += new System.EventHandler(this.PbContribute_Click);
            this.PbContribute.MouseHover += new System.EventHandler(this.PbContribute_MouseHover);
            // 
            // PbLoginRegister
            // 
            this.PbLoginRegister.Image = global::CodeLab.Properties.Resources.lgn64;
            this.PbLoginRegister.Location = new System.Drawing.Point(980, 23);
            this.PbLoginRegister.Name = "PbLoginRegister";
            this.PbLoginRegister.Size = new System.Drawing.Size(48, 48);
            this.PbLoginRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLoginRegister.TabIndex = 6;
            this.PbLoginRegister.TabStop = false;
            this.PbLoginRegister.Click += new System.EventHandler(this.PbLoginRegister_Click);
            this.PbLoginRegister.MouseHover += new System.EventHandler(this.PbLoginRegister_MouseHover);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackgroundImage = global::CodeLab.Properties.Resources.magnifier__1_;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(782, 202);
            this.BtnSearch.MaximumSize = new System.Drawing.Size(80, 80);
            this.BtnSearch.MinimumSize = new System.Drawing.Size(80, 80);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(80, 80);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 431);
            this.Controls.Add(this.PbContribute);
            this.Controls.Add(this.PbLoginRegister);
            this.Controls.Add(this.clbLanguages);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Welcome to CodeLab";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbContribute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLoginRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.CheckedListBox clbLanguages;
        private System.Windows.Forms.PictureBox PbLoginRegister;
        private System.Windows.Forms.PictureBox PbContribute;
    }
}