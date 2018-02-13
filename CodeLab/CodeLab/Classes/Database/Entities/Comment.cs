using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
    public class Comment : DbObject
    {    
        public string Text { get; set; }
        public string UserId { get; set; }
        public Vote Vote { get; set; }
        public List<Comment> SubComments { get; set; }


        public Comment()
        {
            SubComments = new List<Comment>();
            Vote = new Vote();
        }
        
    }




}
