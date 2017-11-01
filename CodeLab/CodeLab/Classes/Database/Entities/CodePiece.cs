using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Drawing;
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

        public string[] Languages;

        public string GetLanguages()
        {
            string returnText = "";
            foreach (var lang in Languages)
            {
                returnText += lang + "-";
            }
            returnText = returnText.Remove(returnText.Length - 1);
            return returnText;
        }

        public string Description { get; set; }
        public string Title { get; set; }
        public string[] Tags { get; set; }
        public byte[] Picture { get; set; }
    }
}
