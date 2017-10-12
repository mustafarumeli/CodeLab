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
 public   class CodePieceCRUD : ICodeLabDB<CodePiece>
    {

        protected IMongoDatabase _database = DbFactory._database;
        protected IMongoCollection<BsonDocument> table = DbFactory.CodePieces;

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

        public async Task<List<CodePiece>> GetAll(BsonDocument filter)
        {
            try
            {
                List<CodePiece> results = new List<CodePiece>();
                using (var cursor = await table.FindAsync(filter))
                {

                    var x = cursor.ToEnumerable().Where(z => 1 == 1).ToList();
                    foreach (var item in x)
                    {
                        CodePiece obj = JsonConvert.DeserializeObject<CodePiece>(item.ToString());
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

        public async Task<CodePiece> GetOne(string _id)
        {
            try
            {
                BsonDocument filter = new BsonDocument { { "_id", _id } };
                using (var cursor = await table.FindAsync(filter))
                {
                    return JsonConvert.DeserializeObject<CodePiece>(cursor.First().ToString());
                }

            }
            catch (Exception)
            {

                return new CodePiece { _id = null };
            }

        }

        public async Task<bool> Insert(CodePiece entity)
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

        public async Task<bool> Update(string _id, CodePiece entity)
        {
            try
            {
                BsonDocument filter = new BsonDocument { { "_id", _id } };
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
