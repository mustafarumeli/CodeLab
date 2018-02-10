using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace CodeLab.Classes.Database
{
    public class CRUD<T> : ICodeLabDb<T> where T : DbObject, new()
    {
        protected IMongoDatabase Database;
        protected IMongoCollection<BsonDocument> Table;

        public CRUD(IMongoCollection<BsonDocument> tableInstance)
        {
            Database = DbFactory.Database;
            Table = tableInstance;
        }

        protected CRUD()
        {

        }


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

        public async Task<List<T>> GetAll(BsonDocument filter)
        {
            try
            {
                var results = new List<T>();
                using (var cursor = await Table.FindAsync(filter))
                {
                    var x = cursor.ToList();
                    results.AddRange(x.Select(item => JsonConvert.DeserializeObject<T>(item.ToString())));
                }
                return results;
            }
            catch (Exception)
            {

                return new List<T>();
            }

        }

        public async Task<T> GetOne(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<T>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new T { _id = null };
            }

        }

        public async Task<bool> Insert(T entity)
        {
                var json = Newtonsoft.Json.JsonConvert.SerializeObject(entity);
                var bsonDocument = BsonDocument.Parse(json);
                await Table.InsertOneAsync(bsonDocument);
                return true;


        }

        public async Task<bool> Update(string id, T entity)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                var json = JsonConvert.SerializeObject(entity);
                await Table.ReplaceOneAsync(filter, BsonDocument.Parse(json));
                   
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}