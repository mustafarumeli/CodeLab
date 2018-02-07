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
        public CommentContainer()
        {
            InitializeComponent();
        }
    
        public void Init()
        {
            const int RANK_BUFFER = 25;
            int HORIZANTAL_BUFFER = 7;
            var comments = Forms.Code.CurrentCodePiece.Comments;
            int _Rank;
            foreach (var comment in comments)
            {
                _Rank = 0;
                PlaceComment(comment);
                _Rank += RANK_BUFFER;
                HORIZANTAL_BUFFER = 3;
                SubCommentCreate(comment.SubComments);

                void SubCommentCreate(IEnumerable<SubComment> subComments)
                {
                    if (subComments != null)
                    {
                        foreach (var subComment in subComments)
                        {

                            PlaceComment((Comment)subComment);
                            _Rank += RANK_BUFFER;
                            SubCommentCreate(subComment.SubSubComments);
                        }
                    }
                    else
                    {
                        _Rank -= RANK_BUFFER;
                        return;
                    }
                }
            }
            void PlaceComment(Comment comment)
            {
                CommentControl cc = new CommentControl(comment);
                cc.Margin = new Padding(_Rank, HORIZANTAL_BUFFER, 0, 0);
                //_lastY += cc.Size.Height + 10;
                //cc.Location = new Point(0 + _Rank, _lastY);
                this.Controls.Add(cc);
            }
        }
        //int _lastY = 0;
      

     
    }
}
