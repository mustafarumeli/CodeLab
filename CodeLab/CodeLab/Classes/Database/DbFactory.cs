using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CodeLab.Classes.Database
{
   public class DbFactory
    {
       public static IMongoClient Client = new MongoClient("mongodb://mustafarumeli:2dDfShKEX9rbc6e2eHxedLaouu8glHyZE9Ghz5PauBTfBkhpIWhvZuwxsgal1bnhQ2ZIQdIgjxDSrfT6XjS9YA==@mustafarumeli.documents.azure.com:10255/?ssl=true&replicaSet=globaldb");
       //public static IMongoClient Client = new MongoClient();
        private static IMongoDatabase _database;

        public static IMongoDatabase Database => _database ?? (_database = Client.GetDatabase("test7"));

        private static IMongoCollection<BsonDocument> _users;

        public static IMongoCollection<BsonDocument> Users => _users ?? (_users = Database.GetCollection<BsonDocument>(typeof(User).Name));

        private static IMongoCollection<BsonDocument> _codePieces;
        public static IMongoCollection<BsonDocument> CodePieces => _codePieces ?? (_codePieces = Database.GetCollection<BsonDocument>(typeof(CodePiece).Name));
    }
}
