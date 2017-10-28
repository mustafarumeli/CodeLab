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
 public   class CodePieceCrud : ICodeLabDb<CodePiece>
    {

        protected IMongoDatabase Database = DbFactory.Database;
        protected IMongoCollection<BsonDocument> Table = DbFactory.CodePieces;

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

        public async Task<List<CodePiece>> GetAll(BsonDocument filter)
        {
            try
            {
                var results = new List<CodePiece>();
                using (var cursor = await Table.FindAsync(filter))
                {

                    var x = cursor.ToList();
                    foreach (var item in x)
                    {
                        var obj = JsonConvert.DeserializeObject<CodePiece>(item.ToString());
                        results.Add(obj);
                    }

                }
                return results;
            }
            catch (Exception)
            {

                return new List<CodePiece>();
            }

        }

        public async Task<CodePiece> GetOne(string id)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                using (var cursor = await Table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<CodePiece>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new CodePiece { Id = null };
            }

        }

        public async Task<bool> Insert(CodePiece entity)
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

        public async Task<bool> Update(string id, CodePiece entity)
        {
            try
            {
                var filter = new BsonDocument { { "_id", id } };
                await Table.UpdateOneAsync(filter, JsonConvert.SerializeObject(entity));
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
