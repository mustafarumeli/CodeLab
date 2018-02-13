using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeLab.Classes.Database.Entities;

namespace CodeLab.Custom_Controls
{
    public partial class CommentContainer : FlowLayoutPanel
    {
        public event Action<object, EventArgs> CommentAnswerClick;
        CommentControl _prevCommentControl;
        public CommentContainer()
        {
            InitializeComponent();
            CommentAnswerClick += CommentContainer_CommentAnswerClick;
        }
        
        private void CommentContainer_CommentAnswerClick(object sender, EventArgs arg2)
        {
            if (_prevCommentControl != null)
            {
                _prevCommentControl.BackColor = Color.SteelBlue;
            }
            _prevCommentControl = (sender as CommentControl);
            (sender as CommentControl).BackColor = Color.Green;

        }
          public void RemoveSelectedColor()
        {

            if (_prevCommentControl != null)
            {
                _prevCommentControl.BackColor = Color.SteelBlue;
            }
        }
        public void Init()
        {
            this.Controls.Clear();
            const int RANK_BUFFER = 25;
            int horizontalBuffer = 7;
            var comments = Forms.Code.CurrentCodePiece.Comments;
            int _Rank;
            foreach (var comment in comments)
            {
                _Rank = RANK_BUFFER;
                horizontalBuffer = 7;
                PlaceComment(comment);
                _Rank += RANK_BUFFER;
                horizontalBuffer = 3;
                SubCommentCreate(comment.SubComments);
               void SubCommentCreate(IEnumerable<Comment> subComments)
                {
                    if (subComments != null && subComments.Any())
                    {
                        foreach (var subComment in subComments)
                        {
                            PlaceComment((Comment)subComment);
                            _Rank += RANK_BUFFER;
                            SubCommentCreate(subComment.SubComments);
                            _Rank -= RANK_BUFFER;
                        }
                    }
                  
                }
            }
            void PlaceComment(Comment comment)
            {
                CommentControl cc = new CommentControl(comment,CommentAnswerClick);
                var currentUsersVoteTrack = Forms.MainForm.CurrentUser.VoteTracks;
                var vote = currentUsersVoteTrack.FirstOrDefault(x => x.CodePieceOrCommentId == comment._id);
                if (vote != null)
                {
                    if (vote.VoteType == VoteType.UpVote)
                    {
                        cc.PbUpVote.Enabled = false;
                    }
                    else
                    {
                        cc.PbDownVote.Enabled = false;
                    }
                }
                cc.Margin = new Padding(_Rank, horizontalBuffer, 0, 0);
                this.Controls.Add(cc);
            }
        }
        //int _lastY = 0;
      

     
    }
}
