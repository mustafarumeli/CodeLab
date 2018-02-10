namespace CodeLab.Classes.Database.Entities
{
    public class SubComment : DbObject
    {
        public string Text { get; set; }
        public string UserId { get; set; }
        public Vote Vote { get; set; }
        public System.Collections.Generic.List<SubComment> SubSubComments { get; set; }
        public SubComment()
        {
            SubSubComments = new System.Collections.Generic.List<SubComment>();
          
        }
        public static implicit operator Comment(SubComment x)
        {
           return new Comment {_id = x._id, Text = x.Text, SubComments = x.SubSubComments, Vote = x.Vote, UserId = x.UserId,CreationDate=x.CreationDate };
        }
    }
}