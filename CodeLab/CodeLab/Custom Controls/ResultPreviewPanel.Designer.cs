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
            this.PbStars = new System.Windows.Forms.PictureBox();
            this.IlStartImages = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PbStars)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDate.Location = new System.Drawing.Point(895, 19);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(42, 18);
            this.LblDate.TabIndex = 0;
            this.LblDate.Text = "Date";
            // 
            // LblHeader
            // 
            this.LblHeader.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.LblHeader.Location = new System.Drawing.Point(54, 88);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(891, 87);
            this.LblHeader.TabIndex = 1;
            this.LblHeader.Text = "Header";
            // 
            // LblLang
            // 
            this.LblLang.AutoSize = true;
            this.LblLang.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLang.ForeColor = System.Drawing.SystemColors.Control;
            this.LblLang.Location = new System.Drawing.Point(58, 190);
            this.LblLang.Name = "LblLang";
            this.LblLang.Size = new System.Drawing.Size(56, 24);
            this.LblLang.TabIndex = 2;
            this.LblLang.Text = "Lang";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAuthor.Location = new System.Drawing.Point(210, 190);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(70, 24);
            this.LblAuthor.TabIndex = 2;
            this.LblAuthor.Text = "Author";
            // 
            // PbStars
            // 
            this.PbStars.Location = new System.Drawing.Point(797, 190);
            this.PbStars.Name = "PbStars";
            this.PbStars.Size = new System.Drawing.Size(187, 50);
            this.PbStars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbStars.TabIndex = 4;
            this.PbStars.TabStop = false;
            // 
            // IlStartImages
            // 
            this.IlStartImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IlStartImages.ImageStream")));
            this.IlStartImages.TransparentColor = System.Drawing.Color.Transparent;
            this.IlStartImages.Images.SetKeyName(0, "StarFull.png");
            this.IlStartImages.Images.SetKeyName(1, "StarHalf.png");
            this.IlStartImages.Images.SetKeyName(2, "StarSchema.png");
            // 
            // ResultPreviewPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Controls.Add(this.PbStars);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblLang);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.LblDate);
            this.Name = "ResultPreviewPanel";
            this.Size = new System.Drawing.Size(1021, 256);
            this.Load += new System.EventHandler(this.ResultPreviewPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblLang;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.PictureBox PbStars;
        private System.Windows.Forms.ImageList IlStartImages;
    }
}
