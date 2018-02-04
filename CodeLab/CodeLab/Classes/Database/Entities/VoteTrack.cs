using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
    public enum VoteType { UpVote,DownVote}
    public enum VotePlace { Comment,CodePiece}
    public class VoteTrack
    {
        public string CodePieceOrCommentId { get; set; } 
        public VotePlace VotePlace { get; set; }
        public VoteType  VoteType { get; set; }
    }
}
