using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace CodeLab.Classes
{
    class Person
    {
        
        public int _id { get; set; }

        public string Name { get; set; }
  
        public string Surname { get; set; }
    
        public string Email { get; set; }
    
        public string Password { get; set; }
  
        public int Age { get; set; }

        public static explicit operator Person(BsonDocument v)
        {
            throw new NotImplementedException();
        }
    }
}
