using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
    public class UserCRUD : ICodeLabDB<User>
    {

        protected  IMongoDatabase _database = DbFactory._database;
        protected IMongoCollection<BsonDocument> table = DbFactory.Users;

        public async Task<bool> Delete(string _id)
        {
            try
            {
                BsonDocument filter = new BsonDocument { { "_id", _id } };
                var result = await table.DeleteOneAsync(filter);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<User>> GetAll(BsonDocument filter)
        {
            try
            {
                List<User> results = new List<User>();
                using (var cursor = await table.FindAsync(filter))
                {

                    var x = cursor.ToEnumerable().Where(z => 1 == 1).ToList();
                    foreach (var item in x)
                    {
                        User obj = Newtonsoft.Json.JsonConvert.DeserializeObject<User>(item.ToString());
                        results.Add(obj);
                    }

                }
                return results;
            }
            catch (Exception)
            {

                return new List<User>();
            }
            
        }

        public async Task<User> GetOne(string _id)
        {
            try
            {
                BsonDocument filter = new BsonDocument { { "_id", _id } };
                using (var cursor = await table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<User>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new User { _id = null };
            }
           
        }

        public async Task<bool> Insert(User entity)
        {
            try
            {
                
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
                var bsonDocument = BsonDocument.Parse(json);
                await table.InsertOneAsync(bsonDocument);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
            
        }

        public async Task<bool> Update(string _id, User entity)
        {
            try
            {
                BsonDocument filter = new BsonDocument { { "_id",_id}};
                await table.UpdateOneAsync(filter, JsonConvert.SerializeObject(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
        }
    }
}
