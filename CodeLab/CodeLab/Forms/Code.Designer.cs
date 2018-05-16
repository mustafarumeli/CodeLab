using CodeLab.Custom_Controls;

namespace CodeLab.Forms
{
    partial class Code
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Code));
            this.TbStatus = new CodeLab.Custom_Controls.CustomRichTextBox();
            this.TbCode = new CodeLab.Custom_Controls.CustomRichTextBox();
            this.PbRun = new System.Windows.Forms.PictureBox();
            this.PbOriginal = new System.Windows.Forms.PictureBox();
            this.PbCopy = new System.Windows.Forms.PictureBox();
            this.PbMakeComment = new System.Windows.Forms.PictureBox();
            this.PbSeeComments = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMakeComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSeeComments)).BeginInit();
            this.SuspendLayout();
            // 
            // TbStatus
            // 
            this.TbStatus.ForeColor = System.Drawing.Color.Red;
            this.TbStatus.Location = new System.Drawing.Point(37, 524);
            this.TbStatus.Name = "TbStatus";
            this.TbStatus.Size = new System.Drawing.Size(618, 114);
            this.TbStatus.TabIndex = 1;
            this.TbStatus.Text = "";
            // 
            // TbCode
            // 
            this.TbCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TbCode.Font = new System.Drawing.Font("Arial", 12F);
            this.TbCode.Location = new System.Drawing.Point(37, 74);
            this.TbCode.Name = "TbCode";
            this.TbCode.Size = new System.Drawing.Size(618, 433);
            this.TbCode.TabIndex = 0;
            this.TbCode.Tag = "AsyncItem";
            this.TbCode.Text = "";
            // 
            // PbRun
            // 
            this.PbRun.Image = global::CodeLab.Properties.Resources.play_button;
            this.PbRun.Location = new System.Drawing.Point(610, 18);
            this.PbRun.Name = "PbRun";
            this.PbRun.Size = new System.Drawing.Size(45, 40);
            this.PbRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbRun.TabIndex = 11;
            this.PbRun.TabStop = false;
            this.PbRun.Click += new System.EventHandler(this.BtnRun_ClickAsync);
            this.PbRun.MouseHover += new System.EventHandler(this.BtnRun_MouseHover);
            // 
            // PbOriginal
            // 
            this.PbOriginal.Image = global::CodeLab.Properties.Resources.undo_arrow_of_circular_shape_with_half_broken_line;
            this.PbOriginal.Location = new System.Drawing.Point(565, 18);
            this.PbOriginal.Name = "PbOriginal";
            this.PbOriginal.Size = new System.Drawing.Size(45, 40);
            this.PbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbOriginal.TabIndex = 11;
            this.PbOriginal.TabStop = false;
            this.PbOriginal.Click += new System.EventHandler(this.BtnOrginal_Click);
            this.PbOriginal.MouseHover += new System.EventHandler(this.BtnOrginal_MouseLeave);
            // 
            // PbCopy
            // 
            this.PbCopy.Image = global::CodeLab.Properties.Resources.copy32;
            this.PbCopy.Location = new System.Drawing.Point(520, 18);
            this.PbCopy.Name = "PbCopy";
            this.PbCopy.Size = new System.Drawing.Size(45, 40);
            this.PbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbCopy.TabIndex = 11;
            this.PbCopy.TabStop = false;
            this.PbCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            this.PbCopy.MouseHover += new System.EventHandler(this.BtnCopy_MouseHover);
            // 
            // PbMakeComment
            // 
            this.PbMakeComment.Image = global::CodeLab.Properties.Resources.makecomment32;
            this.PbMakeComment.Location = new System.Drawing.Point(475, 18);
            this.PbMakeComment.Name = "PbMakeComment";
            this.PbMakeComment.Size = new System.Drawing.Size(45, 40);
            this.PbMakeComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbMakeComment.TabIndex = 11;
            this.PbMakeComment.TabStop = false;
            this.PbMakeComment.Click += new System.EventHandler(this.BtnMakeComment_Click);
            this.PbMakeComment.MouseHover += new System.EventHandler(this.BtnMakeComment_MouseHover);
            // 
            // PbSeeComments
            // 
            this.PbSeeComments.Image = global::CodeLab.Properties.Resources.chat;
            this.PbSeeComments.Location = new System.Drawing.Point(430, 18);
            this.PbSeeComments.Name = "PbSeeComments";
            this.PbSeeComments.Size = new System.Drawing.Size(45, 40);
            this.PbSeeComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbSeeComments.TabIndex = 11;
            this.PbSeeComments.TabStop = false;
            this.PbSeeComments.Click += new System.EventHandler(this.BtnSeeComments_Click);
            this.PbSeeComments.MouseHover += new System.EventHandler(this.BtnSeeComments_MouseHover);
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 661);
            this.Controls.Add(this.PbRun);
            this.Controls.Add(this.PbOriginal);
            this.Controls.Add(this.PbCopy);
            this.Controls.Add(this.PbMakeComment);
            this.Controls.Add(this.PbSeeComments);
            this.Controls.Add(this.TbStatus);
            this.Controls.Add(this.TbCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 661);
            this.MinimumSize = new System.Drawing.Size(680, 661);
            this.Name = "Code";
            this.Load += new System.EventHandler(this.Code_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.PbRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMakeComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSeeComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomRichTextBox TbCode;
        public CustomRichTextBox TbStatus;
        private System.Windows.Forms.PictureBox PbRun;
        private System.Windows.Forms.PictureBox PbCopy;
        private System.Windows.Forms.PictureBox PbOriginal;
        private System.Windows.Forms.PictureBox PbSeeComments;
        private System.Windows.Forms.PictureBox PbMakeComment;
    }
}