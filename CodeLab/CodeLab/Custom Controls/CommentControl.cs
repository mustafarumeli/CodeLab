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
    public partial class CommentControl : UserControl
    {
        Comment _currentComment;
        private readonly Action<object, EventArgs> _clickEvent;

        public Comment Comment => _currentComment;

        // CodePiece _currentCodePiece = Code.CurrentCodePiece;
        public CommentControl(Comment comment,Action<object,EventArgs> clickEvent)
        {
            InitializeComponent();
            _currentComment = comment;
            this._clickEvent = clickEvent;
            LbUserName.Text = Forms.MainForm.CurrentUser.UserName;
            LblCommentText.Text = comment.Text;
            LblCommentDate.Text = comment.CreationDate.ToString();
            LbTotalPoint.Text = comment.Vote?.TotalPoint.ToString();
        }

        private async void PbUpVote_Click(object sender, EventArgs e)
        {
            if (PbDownVote.Enabled == false)
            {
                _currentComment.Vote.DownVoteCount--;
                Forms.MainForm.CurrentUser.VoteTracks.Remove(Forms.MainForm.CurrentUser.VoteTracks.First(x => x.CodePieceOrCommentId == _currentComment._id));
            }
            _currentComment.Vote.UpVoteCount++;
            await Classes.Database.DbFactory.CodePieceCrud.Update(Forms.Code.CurrentCodePiece._id, Forms.Code.CurrentCodePiece);
            VoteTrack vt = new VoteTrack()
            {
                CodePieceOrCommentId = _currentComment._id,
                VotePlace = VotePlace.Comment,
                VoteType= VoteType.UpVote
            };
            Forms.MainForm.CurrentUser.VoteTracks.Add(vt);
            await Classes.Database.DbFactory.UserCrud.Update(Forms.MainForm.CurrentUser._id, Forms.MainForm.CurrentUser);
            LbTotalPoint.Text = _currentComment.Vote?.TotalPoint.ToString();
            (sender as PictureBox).Enabled = false;
            PbDownVote.Enabled = true;
        }

        private async void PbDownVote_Click(object sender, EventArgs e)
        {
            if (PbUpVote.Enabled == false)
            {
                _currentComment.Vote.UpVoteCount--;
                Forms.MainForm.CurrentUser.VoteTracks.Remove(Forms.MainForm.CurrentUser.VoteTracks.First(x => x.CodePieceOrCommentId == _currentComment._id));
            }
            _currentComment.Vote.DownVoteCount++;
            await Classes.Database.DbFactory.CodePieceCrud.Update(Forms.Code.CurrentCodePiece._id, Forms.Code.CurrentCodePiece);
            VoteTrack vt = new VoteTrack()
            {
                CodePieceOrCommentId = _currentComment._id,
                VotePlace = VotePlace.Comment,
                VoteType = VoteType.DownVote
            };
            Forms.MainForm.CurrentUser.VoteTracks.Add(vt);
            await Classes.Database.DbFactory.UserCrud.Update(Forms.MainForm.CurrentUser._id, Forms.MainForm.CurrentUser);
            LbTotalPoint.Text = _currentComment.Vote?.TotalPoint.ToString();
           (sender as PictureBox).Enabled = false;
            PbUpVote.Enabled = true;
        }

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            _clickEvent?.Invoke(this, e);
        }
    }
}
