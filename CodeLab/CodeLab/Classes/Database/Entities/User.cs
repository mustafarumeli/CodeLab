using MongoDB.Bson;
using System;

using System.Collections.Generic;
using System.Linq;
namespace CodeLab.Classes.Database.Entities
{
    public class User : DbObject
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public List<VoteTrack> VoteTracks { get; set; } // This field is for checking Wheter the User Voted on given CodePiece or Comment
        public List<SearchHistory> SearchHistories { get; }
        public User()
        {
            VoteTracks = new List<VoteTrack>();
            SearchHistories = new List<SearchHistory>();
        }
        public async void AddOrUpdateSearchHistory(string codePieceID, int point)
        {
            var hasCodePiece = SearchHistories.FirstOrDefault(x => x.CodePieceId == codePieceID);
            if (hasCodePiece == null)
            {
                SearchHistory voteTrack = new SearchHistory() { CodePieceId = codePieceID, Point = point };
                SearchHistories.Add(voteTrack);
            }
            else
            {
                int index = SearchHistories.IndexOf(hasCodePiece);
                SearchHistories[index].Point += point;
            }
          await  DbFactory.UserCrud.Update(Forms.MainForm.CurrentUser._id, Forms.MainForm.CurrentUser);
           
        }
        public static explicit operator User(BsonDocument v)
        {
            throw new NotImplementedException();
        }
    }
}
