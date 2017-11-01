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
        public static IMongoClient Client = new MongoClient("mongodb://mustafarumeli:2dDfShKEX9rbc6e2eHxedLaouu8glHyZE9Ghz5PauBTfBkhpIWhvZuwxsgal1bnhQ2ZIQdIgjxDSrfT6XjS9YA==@mustafarumeli.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
      //  public static IMongoClient Client = new MongoClient();
        private static IMongoDatabase _database;

        public static IMongoDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = Client.GetDatabase("test7");
                }
                return _database;
            }
        }

        private static IMongoCollection<BsonDocument> _users;

        public static IMongoCollection<BsonDocument> Users
        {
            get
            {
                if (_users == null)
                {
                    _users = _database.GetCollection<BsonDocument>(typeof(User).Name);
                }
                return _users;
            }
        }

        private static IMongoCollection<BsonDocument> _codePieces;
        public static IMongoCollection<BsonDocument> CodePieces
        {
            get
            {
                if (_codePieces == null)
                {
                    _codePieces = _database.GetCollection<BsonDocument>(typeof(CodePiece).Name);
                }
                return _codePieces;
            }
        }

       
    }
}
