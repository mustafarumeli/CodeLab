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
            Comment c = new Comment() { UserId = MainForm.CurrentUser._id, Text = "First Test", Vote = new Vote() { UpVoteCount = 2 } };
            c.SubComments.Add(new SubComment() { Text = "Sub Comment"});
            c.SubComments[0].SubSubComments.Add(new SubComment() { Text = "SubS Comment" });
            Comments = new System.Collections.Generic.List<Comment>();
            Comments.Add(c);
        }
    }

}
