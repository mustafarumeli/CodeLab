using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    public class DbObject
    {
        public string Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DbObject()
        {
            Id = Guid.NewGuid().ToString();
            CreationDate = DateTime.Now;
        }
    }
}
