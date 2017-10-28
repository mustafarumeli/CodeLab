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
    public class UserCrud : ICodeLabDb<User>
    {

        protected  IMongoDatabase Database = DbFactory.Database;
        protected IMongoCollection<BsonDocument> Table = DbFactory.Users;

        public async Task<bool> Delete(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                await Table.DeleteOneAsync(filter);
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
                var results = new List<User>();
                using (var cursor = await Table.FindAsync(filter))
                {
                    var x = cursor.ToEnumerable().Where(z => true).ToList();
                    results.AddRange(x.Select(item => Newtonsoft.Json.JsonConvert.DeserializeObject<User>(item.ToString())));
                }
                return results;
            }
            catch (Exception)
            {

                return new List<User>();
            }
            
        }

        public async Task<User> GetOne(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<User>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new User { Id = null };
            }
           
        }

        public async Task<bool> Insert(User entity)
        {
            try
            {
                
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
                var bsonDocument = BsonDocument.Parse(json);
                await Table.InsertOneAsync(bsonDocument);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
            
        }

        public async Task<bool> Update(string id, User entity)
        {
            try
            {
                var filter = new BsonDocument { { "_id",id}};
                await Table.UpdateOneAsync(filter, JsonConvert.SerializeObject(entity));
                return true;
            }
            catch (Exception)
            {
                return false;
              
            }
        }

        public async Task<bool> UserNameValidation(string userName)
        {
            var filter = new BsonDocument { {"UserName",userName } };
            using (var cursor = await Table.FindAsync(filter))
            {
                return cursor.Any();
            }
        }
        public async Task<bool> EMailValidation(string email)
        {
            var filter = new BsonDocument { { "EMail", email } };
            using (var cursor = await Table.FindAsync(filter))
            {
                return cursor.Any();
            }
        }


        public async Task<User> CheckAuthentication(string userName, string password)
        {
            try
            {
                var filter = new BsonDocument { { "UserName", userName }, { "Password", password } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<User>(cursor.FirstOrDefault().ToString());
                }
            }
            catch (Exception)
            {

                return null;
            }
           
        }
    }
}
