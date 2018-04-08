using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
    public enum Languages
    {
        csharp,
        c,
        cpp,
        python,
        java
    }
    public class Debug : DbObject
    {
        public Debug()
        {
            SuccessResult = "test";
            ErrorResult = "test";
        }
        public string Code { get; set; }
        public Languages Language { get; set; }
        public string SuccessResult { get; set; }
        public string ErrorResult { get; set; }
    }
}
