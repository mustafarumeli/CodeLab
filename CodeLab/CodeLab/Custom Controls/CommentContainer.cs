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
        private int _lastPosition = 0;
        private const int POSITION_BUFFER = 20;
        CommentControl _prevCommentControl;
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
            (sender as CommentControl).BackColor = Color.Green;

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
        public const int RANK_BUFFER = 25;
        public int pnlNameCounter = 1;
        public void Init()
        {
            this.Controls.Clear();
           
            int horizontalBuffer = 7;
            
            FlowLayoutPanel flw;
            var comments = Forms.Code.CurrentCodePiece.Comments;
            var selectedComments = comments.Take(POSITION_BUFFER).Skip(_lastPosition);
            int _Rank;
            foreach (var comment in selectedComments)
            {
                flw = new FlowLayoutPanel();
                flw.AutoSize = true;
                flw.Name = "panel" + ++pnlNameCounter;
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
                this.Controls.Add(flw);
            }
            void PlaceComment(Comment comment)
            {
                CommentControl cc = new CommentControl(comment, CommentAnswerClick);
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
                flw.Controls.Add(cc);
            }

        }
        internal CommentControl CreateCommentControl(Comment subComment)
        {
            CommentControl cc = new CommentControl(subComment, CommentAnswerClick);
            return cc;
        }

    }
}
