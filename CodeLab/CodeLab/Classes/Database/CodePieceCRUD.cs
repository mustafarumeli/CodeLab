using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLab.Classes.Database.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CodeLab.Classes.Database
{
    public class CodePieceCRUD : CRUD<CodePiece>
    {
        public CodePieceCRUD()
        {
            Table = DbFactory.CodePieces;
        }

        public string[] GetDistinctLanguages()
        {
            try
            {
                var filter = new BsonDocument();
                return Table.Distinct<string>("Language",filter).ToList().ToArray();
            }
            catch (Exception)
            {
                return new string[0];
            }

        }
    }
}
