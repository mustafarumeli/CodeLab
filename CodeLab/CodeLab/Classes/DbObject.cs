using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    public class DbObject
    {
        public string _id { get; set; }
        public DbObject()
        {
            _id = Guid.NewGuid().ToString();
        }
    }
}
