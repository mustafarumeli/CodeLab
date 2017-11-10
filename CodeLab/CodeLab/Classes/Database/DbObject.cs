using System;

namespace CodeLab.Classes
{
    public class DbObject
    {
        public string _id { get; set; }
        public DateTime CreationDate { get; set; }
        public DbObject()
        {
            _id = Guid.NewGuid().ToString();
            CreationDate = DateTime.Now;
        }
    }
}
