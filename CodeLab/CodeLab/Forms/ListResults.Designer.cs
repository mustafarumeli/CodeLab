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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListResults));
            this.resultContainer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // resultContainer1
            // 
            this.resultContainer1.AutoScroll = true;
            this.resultContainer1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.resultContainer1.Location = new System.Drawing.Point(15, 64);
            this.resultContainer1.Name = "resultContainer1";
            this.resultContainer1.Size = new System.Drawing.Size(525, 579);
            this.resultContainer1.TabIndex = 0;
            // 
            // ListResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(562, 640);
            this.Controls.Add(this.resultContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListResults";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "ListResults";
            this.TransparencyKey = System.Drawing.SystemColors.Info;
            this.Load += new System.EventHandler(this.ListResults_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel resultContainer1;
    }
}