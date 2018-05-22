using CodeLab.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CodeLab.Custom_Controls
{
    public partial class CommentContainer : FlowLayoutPanel
    {
        public event Action<object, EventArgs> CommentAnswerClick;
        private int _lastPosition = 0;
        private const int POSITION_BUFFER = 20;
        private CommentControl _prevCommentControl;
        public const int RANK_BUFFER = 25;
        public int PnlNameCounter = 1;
        public CommentContainer()
        {
            InitializeComponent();
            CommentAnswerClick += CommentContainer_CommentAnswerClick;
        }
        public void CommentContainer_CommentAnswerClick(object sender, EventArgs arg2)
        {
            if (_prevCommentControl != null)
            {
                _prevCommentControl.BackColor = Color.SteelBlue;
            }
            _prevCommentControl = (sender as CommentControl);
            var commentControl = sender as CommentControl;
            if (commentControl != null) commentControl.BackColor = Color.Green;
        }
        public void RemoveSelectedColor()
        {

            if (_prevCommentControl != null)
            {
                _prevCommentControl.BackColor = Color.SteelBlue;
            }
        }
        public void LoadMore()
        {
            _lastPosition += POSITION_BUFFER;
        }
        public void Init()
        {
            this.Controls.Clear();

            int horizontalBuffer;
            
            FlowLayoutPanel flw;
            var comments = Forms.Code.CurrentCodePiece.Comments;
            var selectedComments = comments.Take(POSITION_BUFFER).Skip(_lastPosition);
            int rank;
            foreach (var comment in selectedComments)
            {
                flw = new FlowLayoutPanel
                {
                    AutoSize = true,
                    Name = "panel" + ++PnlNameCounter
                };
                rank = RANK_BUFFER;
                horizontalBuffer = 7;
                PlaceComment(comment);
                rank += RANK_BUFFER;
                horizontalBuffer = 3;
                SubCommentCreate(comment.SubComments);
                void SubCommentCreate(IEnumerable<Comment> subComments)
                {
                    var commentsArray = subComments as Comment[] ?? subComments.ToArray();
                    if (commentsArray.Any())
                    {
                        foreach (var subComment in commentsArray)
                        {
                            PlaceComment((Comment)subComment);
                            rank += RANK_BUFFER;
                            SubCommentCreate(subComment.SubComments);
                            rank -= RANK_BUFFER;
                        }
                    }
                }
                this.Controls.Add(flw);
            }


            void PlaceComment(Comment comment)
            {
                var cc = new CommentControl(comment, CommentAnswerClick);
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
                cc.Margin = new Padding(rank, horizontalBuffer, 0, 0);
                flw.Controls.Add(cc);
            }

        }
        internal CommentControl CreateCommentControl(Comment subComment)
        {
            var cc = new CommentControl(subComment, CommentAnswerClick);
            return cc;
        }

    }
}
