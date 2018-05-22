namespace CodeLab.Custom_Controls
{
    partial class ResultPreviewPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultPreviewPanel));
            this.LblDate = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblLang = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.IlStartImages = new System.Windows.Forms.ImageList(this.components);
            this.LblVote = new System.Windows.Forms.Label();
            this.BtnGotoCode = new CodeLab.Custom_Controls.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 10F);
            this.LblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDate.Location = new System.Drawing.Point(3, 0);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(38, 16);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date";
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHeader.Location = new System.Drawing.Point(20, 19);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(138, 42);
            this.LblHeader.TabIndex = 1;
            this.LblHeader.Text = "Header";
            // 
            // LblLang
            // 
            this.LblLang.AutoSize = true;
            this.LblLang.Font = new System.Drawing.Font("Arial", 10F);
            this.LblLang.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLang.Location = new System.Drawing.Point(24, 61);
            this.LblLang.Name = "LblLang";
            this.LblLang.Size = new System.Drawing.Size(40, 16);
            this.LblLang.TabIndex = 2;
            this.LblLang.Text = "Lang";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Arial", 10F);
            this.LblAuthor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAuthor.Location = new System.Drawing.Point(47, 0);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(50, 16);
            this.LblAuthor.TabIndex = 2;
            this.LblAuthor.Text = "Author";
            // 
            // IlStartImages
            // 
            this.IlStartImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IlStartImages.ImageStream")));
            this.IlStartImages.TransparentColor = System.Drawing.Color.Transparent;
            this.IlStartImages.Images.SetKeyName(0, "StarFull.png");
            this.IlStartImages.Images.SetKeyName(1, "StarHalf.png");
            this.IlStartImages.Images.SetKeyName(2, "StarSchema.png");
            // 
            // LblVote
            // 
            this.LblVote.AutoSize = true;
            this.LblVote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVote.ForeColor = System.Drawing.SystemColors.Control;
            this.LblVote.Location = new System.Drawing.Point(478, 9);
            this.LblVote.Name = "LblVote";
            this.LblVote.Size = new System.Drawing.Size(40, 18);
            this.LblVote.TabIndex = 0;
            this.LblVote.Text = "Vote";
            // 
            // BtnGotoCode
            // 
            this.BtnGotoCode.BackColor = System.Drawing.Color.Green;
            this.BtnGotoCode.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnGotoCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGotoCode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGotoCode.ForeColor = System.Drawing.Color.White;
            this.BtnGotoCode.Location = new System.Drawing.Point(395, 132);
            this.BtnGotoCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnGotoCode.MinimumSize = new System.Drawing.Size(100, 32);
            this.BtnGotoCode.Name = "BtnGotoCode";
            this.BtnGotoCode.Padding = new System.Windows.Forms.Padding(3);
            this.BtnGotoCode.Size = new System.Drawing.Size(123, 33);
            this.BtnGotoCode.TabIndex = 5;
            this.BtnGotoCode.Text = "Go To Code";
            this.BtnGotoCode.UseVisualStyleBackColor = false;
            this.BtnGotoCode.Click += new System.EventHandler(this.BtnGotoCode_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LblDate);
            this.flowLayoutPanel1.Controls.Add(this.LblAuthor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(21, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 17);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // ResultPreviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.BtnGotoCode);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblLang);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.LblVote);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ResultPreviewPanel";
            this.Size = new System.Drawing.Size(523, 171);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblLang;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.ImageList IlStartImages;
        private CustomButton BtnGotoCode;
        private System.Windows.Forms.Label LblVote;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
