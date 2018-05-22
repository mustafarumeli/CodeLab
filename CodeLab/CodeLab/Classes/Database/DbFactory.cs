using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CodeLab.Classes.Database
{
   public class DbFactory
    {
        static readonly string server_username = "ohm";
        static readonly string server_password = "741895623ohm";
        static readonly string server_host = "35.231.112.9";
        static readonly int server_port = 27017;
        static readonly string database_name = "cool_db";
        public static IMongoClient Client = new MongoClient($"mongodb://{server_username}:{server_password}@{server_host}:{server_port}/{database_name}");

        private static IMongoDatabase _database;
        public static IMongoDatabase Database => _database ?? (_database = Client.GetDatabase(database_name));

        private static UserCrud _userCrud;
        public static UserCrud UserCrud => _userCrud ?? (_userCrud = new UserCrud());

        private static CodePieceCRUD _codePieceCrud;
        public static CodePieceCRUD CodePieceCrud => _codePieceCrud ?? (_codePieceCrud = new CodePieceCRUD());

        private static DebugCRUD _debugCRUD;
        public static DebugCRUD DebugCrud => _debugCRUD ?? (_debugCRUD = new DebugCRUD());

        private static IMongoCollection<BsonDocument> _users;
        public static IMongoCollection<BsonDocument> Users => _users ?? (_users = Database.GetCollection<BsonDocument>(typeof(User).Name));

        private static IMongoCollection<BsonDocument> _codePieces;
        public static IMongoCollection<BsonDocument> CodePieces => _codePieces ?? (_codePieces = Database.GetCollection<BsonDocument>(typeof(CodePiece).Name));

        private static IMongoCollection<BsonDocument> _debugs;
        public static IMongoCollection<BsonDocument> Debugs => _debugs ?? (_debugs = Database.GetCollection<BsonDocument>(typeof(Debug).Name));
    }
}
