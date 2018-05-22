namespace CodeLab.Classes.Database.Entities
{
    /// <summary>
    /// This is the search history of the user it stores two thing first the CodePieceId which is the CodePiece that user checks for details
    /// and Point this property indicates how long that user used this CodePiece ie. If user comments this CodePiece Point property will increase
    /// What this does is whenever the user searches the same CodePiece second time we will give a better result to the User
    /// </summary>
    public class SearchHistory
    {
        public string CodePieceId { get; set; }
        public int Point { get; set; }
    }
}
