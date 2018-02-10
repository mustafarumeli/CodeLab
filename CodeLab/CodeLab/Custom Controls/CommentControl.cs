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
       // CodePiece _currentCodePiece = Code.CurrentCodePiece;
        public CommentControl(Comment comment)
        {
            InitializeComponent();
            _currentComment = comment;
            LbUserName.Text = Forms.MainForm.CurrentUser.UserName;
            LblCommentText.Text = comment.Text;
            LbTotalPoint.Text = comment.Vote?.TotalPoint.ToString();
        }

        private void PbUpVote_Click(object sender, EventArgs e)
        {

        }

        private void PbDownVote_Click(object sender, EventArgs e)
        {

        }
    }
}
