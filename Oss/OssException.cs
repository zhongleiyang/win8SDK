using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
//using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Oss
{
    public class OssException : ServiceException
    {
        public OssException()
        {
        }

        public OssException(string message)
            : base(message)
        {
        }


        public OssException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}
