using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oss.Utilities
{
     static class EnumUtils
    {
        //private static IDictionary<Enum, StringValueAttribute> _stringValues = new Dictionary<Enum, StringValueAttribute>();

        public static string GetStringValue(CannedAccessControlList value)
        {
            if (value == CannedAccessControlList.Private)
            {
               return  "private";
            }
            else if(value == CannedAccessControlList.PublicRead)
            {
                return  "public-read";
            }
            else if (value == CannedAccessControlList.PublicReadWrite)
            {
                return "public-read-write";
            }
            return null;
        }
    }
}
