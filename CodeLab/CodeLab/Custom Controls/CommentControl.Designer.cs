namespace CodeLab.Custom_Controls
{
    partial class CommentControl
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
            this.PbDownVote = new System.Windows.Forms.PictureBox();
            this.PbUpVote = new System.Windows.Forms.PictureBox();
            this.LbUserName = new System.Windows.Forms.Label();
            this.LblCommentText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbTotalPoint = new System.Windows.Forms.Label();
            this.ButtonAnswer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbDownVote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUpVote)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbDownVote
            // 
            this.PbDownVote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PbDownVote.Image = global::CodeLab.Properties.Resources.DownArrow;
            this.PbDownVote.Location = new System.Drawing.Point(261, 3);
            this.PbDownVote.MaximumSize = new System.Drawing.Size(32, 32);
            this.PbDownVote.MinimumSize = new System.Drawing.Size(32, 32);
            this.PbDownVote.Name = "PbDownVote";
            this.PbDownVote.Size = new System.Drawing.Size(32, 32);
            this.PbDownVote.TabIndex = 0;
            this.PbDownVote.TabStop = false;
            this.PbDownVote.Click += new System.EventHandler(this.PbDownVote_Click);
            // 
            // PbUpVote
            // 
            this.PbUpVote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbUpVote.Image = global::CodeLab.Properties.Resources.UpArrow;
            this.PbUpVote.Location = new System.Drawing.Point(201, 3);
            this.PbUpVote.MaximumSize = new System.Drawing.Size(32, 32);
            this.PbUpVote.MinimumSize = new System.Drawing.Size(16, 16);
            this.PbUpVote.Name = "PbUpVote";
            this.PbUpVote.Size = new System.Drawing.Size(32, 32);
            this.PbUpVote.TabIndex = 0;
            this.PbUpVote.TabStop = false;
            this.PbUpVote.Click += new System.EventHandler(this.PbUpVote_Click);
            // 
            // LbUserName
            // 
            this.LbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Arial", 10F);
            this.LbUserName.Location = new System.Drawing.Point(3, 12);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(77, 16);
            this.LbUserName.TabIndex = 1;
            this.LbUserName.Text = "UserName:";
            // 
            // LblCommentText
            // 
            this.LblCommentText.AutoSize = true;
            this.LblCommentText.Font = new System.Drawing.Font("Arial", 12F);
            this.LblCommentText.Location = new System.Drawing.Point(3, 14);
            this.LblCommentText.Name = "LblCommentText";
            this.LblCommentText.Size = new System.Drawing.Size(103, 18);
            this.LblCommentText.TabIndex = 1;
            this.LblCommentText.Text = "CommentText";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.LblCommentText);
            this.panel1.Location = new System.Drawing.Point(18, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 58);
            this.panel1.TabIndex = 3;
            // 
            // LbTotalPoint
            // 
            this.LbTotalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LbTotalPoint.AutoSize = true;
            this.LbTotalPoint.Font = new System.Drawing.Font("Arial", 12F);
            this.LbTotalPoint.ForeColor = System.Drawing.Color.Yellow;
            this.LbTotalPoint.Location = new System.Drawing.Point(235, 10);
            this.LbTotalPoint.Name = "LbTotalPoint";
            this.LbTotalPoint.Size = new System.Drawing.Size(26, 18);
            this.LbTotalPoint.TabIndex = 4;
            this.LbTotalPoint.Text = "10";
            // 
            // ButtonAnswer
            // 
            this.ButtonAnswer.BackColor = System.Drawing.Color.OrangeRed;
            this.ButtonAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnswer.ForeColor = System.Drawing.Color.White;
            this.ButtonAnswer.Location = new System.Drawing.Point(218, 105);
            this.ButtonAnswer.Name = "ButtonAnswer";
            this.ButtonAnswer.Size = new System.Drawing.Size(75, 23);
            this.ButtonAnswer.TabIndex = 5;
            this.ButtonAnswer.Text = "Answer";
            this.ButtonAnswer.UseVisualStyleBackColor = false;
            this.ButtonAnswer.Click += new System.EventHandler(this.ButtonAnswer_Click);
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.Controls.Add(this.ButtonAnswer);
            this.Controls.Add(this.LbTotalPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbUserName);
            this.Controls.Add(this.PbDownVote);
            this.Controls.Add(this.PbUpVote);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(314, 135);
            ((System.ComponentModel.ISupportInitialize)(this.PbDownVote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUpVote)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PbUpVote;
        internal System.Windows.Forms.PictureBox PbDownVote;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label LblCommentText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbTotalPoint;
        private System.Windows.Forms.Button ButtonAnswer;
    }
}
