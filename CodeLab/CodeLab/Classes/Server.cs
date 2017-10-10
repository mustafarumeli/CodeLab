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
        protected static IMongoDatabase _database = _client.GetDatabase("test3");
        protected static IMongoCollection<BsonDocument> _collection = _database.GetCollection<BsonDocument>("test3");

        public  async Task InsertAsync()
        {
            Person person = new Person() {
                _id =2,
                Name ="Mahmut",
                Surname="Mahmutoğlu",
                Age=12,
                Email="mahmut@memo.com",
                Password="mahmutsanınabisi"
            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(person);
            var bsonDocument = BsonDocument.Parse(json);
            await _collection.InsertOneAsync(bsonDocument);
        } 
        public async Task GetValuesAsync()
        {
            var filter = new BsonDocument();
           
            var count = 0;
            using (var cursor = await _collection.FindAsync(filter))
            {

                var x = cursor.ToEnumerable().Where(z=> 1==1).ToList();
                foreach (var item in x)
                {
                    Person person = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(item.ToString());
                    System.Windows.Forms.MessageBox.Show(person.Name);
                }
       
            }
        }

        public async Task UpdateOneAsync()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Mahmut");
            var update = Builders<BsonDocument>.Update.Set("Name", "Mahmut-san");
            var result = await _collection.UpdateOneAsync(filter, update);

        }

        public async Task DeleteOneAsync()
        {
            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Mahmut");
            var result = await _collection.DeleteOneAsync(filter);

        }
    }
}
