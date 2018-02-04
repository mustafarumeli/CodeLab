using MongoDB.Bson;
using System;

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
        public VoteTrack[] VoteTracks{ get; set; } // This field is for checking Wheter the User Voted on given CodePiece or Comment
        
        
        public static explicit operator User(BsonDocument v)
        {
            throw new NotImplementedException();
        }
    }
}
