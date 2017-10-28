using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
   public interface ICodeLabDb<T> where T : DbObject
    {
        Task<bool> Insert(T entity);
        Task<bool> Delete(string id);
        Task<bool> Update(string id,T entity);
        Task<List<T>> GetAll(BsonDocument filter);
        Task<T> GetOne(string id);



    }
}
