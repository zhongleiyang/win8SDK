using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oss.Deserial
{
    internal class ResponseDeserializationException : InvalidOperationException
    {
        public ResponseDeserializationException()
        {
        }

        public ResponseDeserializationException(string message)
            : base(message)
        {
        }


        public ResponseDeserializationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
