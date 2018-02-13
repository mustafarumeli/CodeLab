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
        public CommentContainer()
        {
            InitializeComponent();
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
                cc.Margin = new Padding(_Rank, horizontalBuffer, 0, 0);

                this.Controls.Add(cc);
            }
        }
        //int _lastY = 0;
      

     
    }
}
