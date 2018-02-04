namespace CodeLab.Classes.Database.Entities
{
    public class SubComments : DbObject
    {
        public string Text { get; set; }
        public string UserId { get; set; }
        public SubComments[] SubSubComments { get; set; }
    }
}