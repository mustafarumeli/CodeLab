using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
   public interface ICodeLabDB<T> where T : DbObject
    {
        Task<bool> Insert(T entity);
        Task<bool> Delete(string _id);
        Task<bool> Update(string _id,T entity);
        Task<List<T>> GetAll(BsonDocument filter);
        Task<T> GetOne(string _id);



    }
}
