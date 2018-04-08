using CodeLab.Classes.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database
{
    public class DebugCRUD : CRUD<Debug>
    {
        public DebugCRUD()
        {
            Table = DbFactory.Debugs;
        }
    }
}
