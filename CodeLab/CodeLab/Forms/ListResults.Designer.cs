namespace CodeLab.Forms
{
    partial class ListResults
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
            this.LblResult = new System.Windows.Forms.Label();
            this.resultContainer1 = new CodeLab.Custom_Controls.ResultContainer();
            this.SuspendLayout();
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(175, 108);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(210, 38);
            this.LblResult.TabIndex = 0;
            this.LblResult.Text = "Results For : ";
            // 
            // resultContainer1
            // 
            this.resultContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultContainer1.AutoScroll = true;
            this.resultContainer1.Location = new System.Drawing.Point(182, 169);
            this.resultContainer1.Name = "resultContainer1";
            this.resultContainer1.Size = new System.Drawing.Size(1047, 376);
            this.resultContainer1.TabIndex = 1;
            // 
            // ListResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 524);
            this.Controls.Add(this.resultContainer1);
            this.Controls.Add(this.LblResult);
            this.Name = "ListResults";
            this.Text = "ListResults";
            this.Load += new System.EventHandler(this.ListResults_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblResult;
        private Custom_Controls.ResultContainer resultContainer1;
    }
}