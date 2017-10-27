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
        public static IMongoClient _client = new MongoClient("mongodb://mustafarumeli:2dDfShKEX9rbc6e2eHxedLaouu8glHyZE9Ghz5PauBTfBkhpIWhvZuwxsgal1bnhQ2ZIQdIgjxDSrfT6XjS9YA==@mustafarumeli.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
        private static IMongoDatabase _database;

        public static IMongoDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    _database = _client.GetDatabase("test5");
                }
                return _database;
            }
        }

        private static IMongoCollection<BsonDocument> _Users;

        public static IMongoCollection<BsonDocument> Users
        {
            get
            {
                if (_Users == null)
                {
                    _Users = _database.GetCollection<BsonDocument>(typeof(User).Name);
                }
                return _Users;
            }
        }

        private static IMongoCollection<BsonDocument> _CodePieces;
        public static IMongoCollection<BsonDocument> CodePieces
        {
            get
            {
                if (_CodePieces == null)
                {
                    _CodePieces = _database.GetCollection<BsonDocument>(typeof(CodePiece).Name);
                }
                return _CodePieces;
            }
        }

       
    }
}
