using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
   public class DbFactory
    {
        public static IMongoClient _client = new MongoClient();
        public static IMongoDatabase _database = _client.GetDatabase("test4");
        public static IMongoCollection<BsonDocument>  Users = _database.GetCollection<BsonDocument>(typeof(User).Name);
        public static IMongoCollection<BsonDocument> CodePieces = _database.GetCollection<BsonDocument>(typeof(CodePiece).Name);


    }
}
