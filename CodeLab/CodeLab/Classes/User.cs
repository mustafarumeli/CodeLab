using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CodeLab.Classes
{
    class User:DbObject
    {
        

        public string Name { get; set; }
      
        public string Email { get; set; }
    
        public string Password { get; set; }
  
        public int UserName { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }

        public static explicit operator User(BsonDocument v)
        {
            throw new NotImplementedException();
        }
    }
}
