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
            this.customButton1 = new CodeLab.Custom_Controls.CustomButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Black;
            this.customButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(349, 299);
            this.customButton1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.customButton1.MinimumSize = new System.Drawing.Size(100, 30);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(3);
            this.customButton1.Size = new System.Drawing.Size(100, 30);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "deneme";
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_ClickAsync);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(448, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_ClickAsync);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_ClickAsync);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 431);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.LblContribute);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TbSearch);
            this.Controls.Add(this.LblDisc);
            this.Controls.Add(this.LblAuth);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
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
        private Custom_Controls.CustomButton customButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}