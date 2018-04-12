using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes.Database.Entities
{
    public enum Languages
    {
        [EnumAttributes(DisplayName ="C#")]
        csharp,
        [EnumAttributes(DisplayName = "C")]
        c,
        [EnumAttributes(DisplayName = "C++")]
        cpp,
        [EnumAttributes(DisplayName = "Python")]
        python,
        [EnumAttributes(DisplayName = "Java")]
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
