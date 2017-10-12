using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
   public class CodePiece : DbObject
    {
        public string Code { get; set; }
        public string Contributer { get; set; }
        public DateTime Date { get; set; }
        public Rate Scores { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
    }
}
