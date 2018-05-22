using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeLab.Classes
{
    public static class EnumHelper<T>
    {
        public static IList<string> GetNames(Enum value)
        {
            return (value as Enum).GetType().GetFields(BindingFlags.Static | BindingFlags.Public).Select(fi => fi.Name).ToList();
        }
        public static T Parse(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static List<string> GetDisplayValues(Enum e)
        {
            return GetNames(e).Select(obj => GetDisplayValue(Parse(obj))).ToList();
        }
        public static T GetValueFromAttribute(string displayName)
        {
            if (!typeof(T).IsEnum) throw new InvalidOperationException();
            foreach (var field in typeof(T).GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(field,typeof(EnumAttributes)) as EnumAttributes;
                if (attribute != null)
                {
                    if (attribute.DisplayName == displayName)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == displayName)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException("Not found.", "description");
            // or return default(T);
        }



        public static string GetDisplayValue(T value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var enumAttributes = fieldInfo.GetCustomAttributes(typeof(EnumAttributes), false) as EnumAttributes[];
            if (enumAttributes.Length > 0)
            {
                return enumAttributes[0].DisplayName;
            }
            else
            {
                return "";
            }  
    
        }
    }
}
