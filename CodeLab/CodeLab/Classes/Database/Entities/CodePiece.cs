using CodeLab.Forms;
using System;

namespace CodeLab.Classes.Database.Entities
{
   public class CodePiece : DbObject
    {
        public string Code { get; set; }
        public string Contributer { get; set; }
        public DateTime Date { get; set; }
        public Rate Scores { get; set; }
        public Vote Votes { get; set; }
        public System.Collections.Generic.List<Comment> Comments { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public byte[] Picture { get; set; }
        public CodePiece()
        {
            Votes = new Vote();
            Comments = new System.Collections.Generic.List<Comment>();
        }
    }

}
