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
        CommentControl _refCommentControl;
        public SeeComments()
        {
            InitializeComponent();
            this.Size = new Size(466, 549);
            CommentContainer.CommentAnswerClick += CommentContainer_CommentAnswerClick;
            CommentContainer.Init();
        }

        FlowLayoutPanel _parentFlowLayoutPanel;
        private void CommentContainer_CommentAnswerClick(object sender, EventArgs e)
        {
            _isSubComment = true;
            _refCommentControl = (sender as CommentControl);
            _refComment = (_refCommentControl).Comment;
            _parentFlowLayoutPanel = ((_refCommentControl).Parent as FlowLayoutPanel);
            this.MinimumSize = new Size(774, 549);
            SetVisibiltyOfNewCommentControls(true);
        }
        private void SetVisibiltyOfNewCommentControls(bool visible)
        {
            TextBoxNewComment.Visible = visible;
            TextBoxNewComment.Clear();
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
                CommentControl cc = CommentContainer.CreateCommentControl(subComment);
                if (_isSubComment)
                {
                    _refComment.SubComments.Add(subComment);
                    cc.Margin = new Padding(_refCommentControl.Margin.Left + CommentContainer.RANK_BUFFER, _refCommentControl.Margin.Top, 0, 0);
                    List<Control> newControlList = new List<Control>();
                    for (int i = 0; i < _parentFlowLayoutPanel.Controls.Count; i++)
                    {
                        var item = _parentFlowLayoutPanel.Controls[i];
                        if (item == _refCommentControl)
                        {
                            newControlList.Add(item);
                            newControlList.Add(cc);
                            continue;
                        }
                        newControlList.Add(item);
                    }
                    _parentFlowLayoutPanel.Controls.Clear();
                    _parentFlowLayoutPanel.Controls.AddRange(newControlList.ToArray());
                }
                else if (!_isSubComment)
                {
                    Code.CurrentCodePiece.Comments.Add(subComment);
                    var flw = new FlowLayoutPanel();
                    flw.AutoSize = true;
                    flw.Name = "panel" + ++CommentContainer.pnlNameCounter;
                    flw.Controls.Add(cc);
                    CommentContainer.Controls.Add(flw);

                }
                MessageBox.Show("Your Comment Has Added"+Environment.NewLine+"Thank You");

                this.MinimumSize = new Size(466, 549);
                this.Size = new Size(466, this.Height);
                SetVisibiltyOfNewCommentControls(false);
                await Classes.Database.DbFactory.CodePieceCrud.Update(Code.CurrentCodePiece._id, Code.CurrentCodePiece);
        
            }
        }

      

        internal void PrepareForm()
        {
            this.MinimumSize =  this.Size = new Size(774, 549);
            SetVisibiltyOfNewCommentControls(true);
        }
    }
}
