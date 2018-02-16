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
            this.TextBoxNewComment = new System.Windows.Forms.RichTextBox();
            this.ButtonGiveAnswer = new CodeLab.Custom_Controls.CustomButton();
            this.CommentContainer = new CodeLab.Custom_Controls.CommentContainer();
            this.SuspendLayout();
            // 
            // TextBoxNewComment
            // 
            this.TextBoxNewComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNewComment.Location = new System.Drawing.Point(453, 63);
            this.TextBoxNewComment.Name = "TextBoxNewComment";
            this.TextBoxNewComment.Size = new System.Drawing.Size(295, 96);
            this.TextBoxNewComment.TabIndex = 1;
            this.TextBoxNewComment.Text = "";
            this.TextBoxNewComment.Visible = false;
            // 
            // ButtonGiveAnswer
            // 
            this.ButtonGiveAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGiveAnswer.BackColor = System.Drawing.Color.Black;
            this.ButtonGiveAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ButtonGiveAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGiveAnswer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGiveAnswer.ForeColor = System.Drawing.Color.White;
            this.ButtonGiveAnswer.Location = new System.Drawing.Point(646, 162);
            this.ButtonGiveAnswer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ButtonGiveAnswer.MinimumSize = new System.Drawing.Size(100, 30);
            this.ButtonGiveAnswer.Name = "ButtonGiveAnswer";
            this.ButtonGiveAnswer.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonGiveAnswer.Size = new System.Drawing.Size(100, 30);
            this.ButtonGiveAnswer.TabIndex = 2;
            this.ButtonGiveAnswer.Text = "Send";
            this.ButtonGiveAnswer.UseVisualStyleBackColor = false;
            this.ButtonGiveAnswer.Visible = false;
            this.ButtonGiveAnswer.Click += new System.EventHandler(this.ButtonGiveAnswer_Click);
            // 
            // CommentContainer
            // 
            this.CommentContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CommentContainer.AutoScroll = true;
            this.CommentContainer.BackColor = System.Drawing.Color.FloralWhite;
            this.CommentContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CommentContainer.Location = new System.Drawing.Point(10, 40);
            this.CommentContainer.MinimumSize = new System.Drawing.Size(430, 227);
            this.CommentContainer.Name = "CommentContainer";
            this.CommentContainer.Size = new System.Drawing.Size(430, 486);
            this.CommentContainer.TabIndex = 0;
            this.CommentContainer.WrapContents = false;
            // 
            // SeeComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(752, 549);
            this.Controls.Add(this.ButtonGiveAnswer);
            this.Controls.Add(this.TextBoxNewComment);
            this.Controls.Add(this.CommentContainer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeeComments";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.CommentContainer CommentContainer;
        private System.Windows.Forms.RichTextBox TextBoxNewComment;
        private Custom_Controls.CustomButton ButtonGiveAnswer;
    }
}