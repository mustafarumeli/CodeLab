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
            this.PbRun = new System.Windows.Forms.PictureBox();
            this.PbCopy = new System.Windows.Forms.PictureBox();
            this.PbOriginal = new System.Windows.Forms.PictureBox();
            this.PbSeeComments = new System.Windows.Forms.PictureBox();
            this.PbMakeComment = new System.Windows.Forms.PictureBox();
            this.TbStatus = new CodeLab.Custom_Controls.CustomRichTextBox();
            this.TbCode = new CodeLab.Custom_Controls.CustomRichTextBox();
            this.FlwOperationContainer = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PbRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSeeComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMakeComment)).BeginInit();
            this.FlwOperationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbRun
            // 
            this.PbRun.Image = global::CodeLab.Properties.Resources.run32;
            this.PbRun.Location = new System.Drawing.Point(155, 3);
            this.PbRun.Name = "PbRun";
            this.PbRun.Size = new System.Drawing.Size(32, 32);
            this.PbRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbRun.TabIndex = 11;
            this.PbRun.TabStop = false;
            this.PbRun.Visible = false;
            this.PbRun.Click += new System.EventHandler(this.BtnRun_Click);
            this.PbRun.MouseHover += new System.EventHandler(this.BtnRun_MouseHover);
            // 
            // PbCopy
            // 
            this.PbCopy.Image = global::CodeLab.Properties.Resources.copy32;
            this.PbCopy.Location = new System.Drawing.Point(79, 3);
            this.PbCopy.Name = "PbCopy";
            this.PbCopy.Size = new System.Drawing.Size(32, 32);
            this.PbCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbCopy.TabIndex = 11;
            this.PbCopy.TabStop = false;
            this.PbCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            this.PbCopy.MouseHover += new System.EventHandler(this.BtnCopy_MouseHover);
            // 
            // PbOriginal
            // 
            this.PbOriginal.Image = global::CodeLab.Properties.Resources.convert_to_original32;
            this.PbOriginal.Location = new System.Drawing.Point(117, 3);
            this.PbOriginal.Name = "PbOriginal";
            this.PbOriginal.Size = new System.Drawing.Size(32, 32);
            this.PbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbOriginal.TabIndex = 11;
            this.PbOriginal.TabStop = false;
            this.PbOriginal.Click += new System.EventHandler(this.BtnOrginal_Click);
            this.PbOriginal.MouseHover += new System.EventHandler(this.BtnOrginal_MouseLeave);
            // 
            // PbSeeComments
            // 
            this.PbSeeComments.Image = global::CodeLab.Properties.Resources.seecomments32;
            this.PbSeeComments.Location = new System.Drawing.Point(3, 3);
            this.PbSeeComments.Name = "PbSeeComments";
            this.PbSeeComments.Size = new System.Drawing.Size(32, 32);
            this.PbSeeComments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbSeeComments.TabIndex = 11;
            this.PbSeeComments.TabStop = false;
            this.PbSeeComments.Click += new System.EventHandler(this.BtnSeeComments_Click);
            this.PbSeeComments.MouseHover += new System.EventHandler(this.BtnSeeComments_MouseHover);
            // 
            // PbMakeComment
            // 
            this.PbMakeComment.Image = global::CodeLab.Properties.Resources.makecomment32;
            this.PbMakeComment.Location = new System.Drawing.Point(41, 3);
            this.PbMakeComment.Name = "PbMakeComment";
            this.PbMakeComment.Size = new System.Drawing.Size(32, 32);
            this.PbMakeComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbMakeComment.TabIndex = 11;
            this.PbMakeComment.TabStop = false;
            this.PbMakeComment.Click += new System.EventHandler(this.BtnMakeComment_Click);
            this.PbMakeComment.MouseHover += new System.EventHandler(this.BtnMakeComment_MouseHover);
            // 
            // TbStatus
            // 
            this.TbStatus.ForeColor = System.Drawing.Color.Red;
            this.TbStatus.Location = new System.Drawing.Point(37, 524);
            this.TbStatus.Name = "TbStatus";
            this.TbStatus.Size = new System.Drawing.Size(618, 114);
            this.TbStatus.TabIndex = 5;
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
            this.TbCode.TabIndex = 2;
            this.TbCode.Tag = "AsyncItem";
            this.TbCode.Text = "";
            // 
            // FlwOperationContainer
            // 
            this.FlwOperationContainer.Controls.Add(this.PbSeeComments);
            this.FlwOperationContainer.Controls.Add(this.PbMakeComment);
            this.FlwOperationContainer.Controls.Add(this.PbCopy);
            this.FlwOperationContainer.Controls.Add(this.PbOriginal);
            this.FlwOperationContainer.Controls.Add(this.PbRun);
            this.FlwOperationContainer.Location = new System.Drawing.Point(461, 29);
            this.FlwOperationContainer.Name = "FlwOperationContainer";
            this.FlwOperationContainer.Size = new System.Drawing.Size(196, 39);
            this.FlwOperationContainer.TabIndex = 12;
            // 
            // Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 661);
            this.Controls.Add(this.FlwOperationContainer);
            this.Controls.Add(this.TbStatus);
            this.Controls.Add(this.TbCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 661);
            this.MinimumSize = new System.Drawing.Size(680, 661);
            this.Name = "Code";
            this.Load += new System.EventHandler(this.Code_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.PbRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSeeComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMakeComment)).EndInit();
            this.FlwOperationContainer.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel FlwOperationContainer;
    }
}