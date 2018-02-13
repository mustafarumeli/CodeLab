using CodeLab.Classes.Database.Entities;
using CodeLab.Custom_Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab.Forms
{
    public partial class SeeComments : MetroFramework.Forms.MetroForm
    {

        bool _isSubComment = false;
        string _idOfAssignment = "";
        Comment _refComment;
        public SeeComments()
        {
            InitializeComponent();
            this.Size = new Size(466, 549);
            CommentContainer.CommentAnswerClick += CommentContainer_CommentAnswerClick;
            CommentContainer.Init();
        }

        private void CommentContainer_CommentAnswerClick(object sender, EventArgs e)
        {
            _isSubComment = true;
            _refComment = (sender as CommentControl).Comment;
            this.MinimumSize = new Size(774, 549);
            SetVisibiltyOfNewCommentControls(true);
        }
        private void SetVisibiltyOfNewCommentControls(bool visible)
        {
            TextBoxNewComment.Visible = visible;
            ButtonGiveAnswer.Visible = visible;
        } 

        private async void ButtonGiveAnswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxNewComment.Text) || TextBoxNewComment.TextLength > 5)
            {
                var subComment = new Comment
                {
                    UserId = MainForm.CurrentUser._id,
                    Text = TextBoxNewComment.Text,
                };
                if (_isSubComment)
                {
                    _refComment.SubComments.Add(subComment);
                }
                else if (!_isSubComment)
                {
                    Code.CurrentCodePiece.Comments.Add(subComment);
                }
                MessageBox.Show("Your Comment Has Added"+Environment.NewLine+"Thank You");
                this.MinimumSize = new Size(466, 549);
                this.Size = new Size(466, this.Height);
                SetVisibiltyOfNewCommentControls(false);
                await Classes.Database.DbFactory.CodePieceCrud.Update(Code.CurrentCodePiece._id, Code.CurrentCodePiece);
                CommentContainer.Init();
            }
        }

        internal void PrepareForm()
        {
            this.MinimumSize =  this.Size = new Size(774, 549);
            SetVisibiltyOfNewCommentControls(true);
        }
    }
}
