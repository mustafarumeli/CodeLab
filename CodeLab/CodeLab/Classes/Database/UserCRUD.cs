using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
    public class UserCrud : CRUD<User>
    {

        public UserCrud()
        {
            Table = DbFactory.Users;
        }

        public async Task<bool> CheckIfExists(string column,string value)
        {
            var filter = new BsonDocument { { column, value } };
            using (var cursor = await Table.FindAsync(filter))
            {
                return cursor.Any();
            }
        }
        public async Task<User> FindUser(string userNameOrEmail)
        {
            try
            {
                var builder = Builders<BsonDocument>.Filter;
                var filter = builder.Eq("UserName", userNameOrEmail) | builder.Eq("EMail", userNameOrEmail);
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
