using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLab.Classes.Database.Entities;

namespace CodeLab.Classes.Database
{
    public class CodePieceCRUD : CRUD<CodePiece>
    {
        public CodePieceCRUD()
        {
            Table = DbFactory.CodePieces;
        }
    }
}
