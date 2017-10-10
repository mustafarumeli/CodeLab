using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    public  class Server
    {
        protected static IMongoClient _client = new MongoClient();
        protected static IMongoDatabase _database = _client.GetDatabase("test4");

        public static async Task InsertAsync<T>(T obj) where T:DbObject
        {
            var table = _database.GetCollection<BsonDocument>(typeof(T).Name);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            var bsonDocument = BsonDocument.Parse(json);
            await table.InsertOneAsync(bsonDocument);
        } 
        public static async Task<List<T>> GetValuesAsync<T>(BsonDocument filter) where T:DbObject
        {
            var table = _database.GetCollection<BsonDocument>(typeof(T).Name);
   
            List<T> results = new List<T>();
            using (var cursor = await table.FindAsync(filter))
            {
            
                var x = cursor.ToEnumerable().Where(z=> 1==1).ToList();
                foreach (var item in x)
                {
                    T obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(item.ToString());
                    results.Add(obj);
                }
            
            }
            return results ;
        }
        public static async Task<T> GetValue<T>(BsonDocument filter) where T : DbObject
        {
            
            var table = _database.GetCollection<BsonDocument>(typeof(T).Name);
            using (var cursor = await table.FindAsync(filter))
            {
                T obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(cursor.First().ToString());
                return obj;
            }
            
        }

        public async Task UpdateOneAsync<T>() where T : DbObject
        {
            var table = _database.GetCollection<BsonDocument>(typeof(T).Name);
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Mahmut");
            var update = Builders<BsonDocument>.Update.Set("Name", "Mahmut-san");
            var result = await table.UpdateOneAsync(filter, update);

        }

        public async Task DeleteOneAsync<T>() where T : DbObject
        {
            var table = _database.GetCollection<BsonDocument>(typeof(T).Name);
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Mahmut");
            var result = await table.DeleteOneAsync(filter);

        }
    }
}
