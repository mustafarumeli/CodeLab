namespace CodeLab.Forms
{
    partial class SeeComments
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
            this.CommentContainer = new CodeLab.Custom_Controls.CommentContainer();
            this.SuspendLayout();
            // 
            // CommentContainer
            // 
            this.CommentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentContainer.AutoScroll = true;
            this.CommentContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CommentContainer.Location = new System.Drawing.Point(10, 40);
            this.CommentContainer.MinimumSize = new System.Drawing.Size(630, 227);
            this.CommentContainer.Name = "CommentContainer";
            this.CommentContainer.Size = new System.Drawing.Size(630, 486);
            this.CommentContainer.TabIndex = 0;
            this.CommentContainer.WrapContents = false;
            // 
            // SeeComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(663, 549);
            this.Controls.Add(this.CommentContainer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(663, 549);
            this.MinimizeBox = false;
            this.Name = "SeeComments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.CommentContainer CommentContainer;
    }
}