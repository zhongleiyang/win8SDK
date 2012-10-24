﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oss
{

    public class ServiceException : Exception
    {
        public ServiceException()
        {
        }

        public ServiceException(string message)
            : base(message)
        {
        }



        public ServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

     
        public virtual string ErrorCode { get; internal set; }
    
        public virtual string HostId { get; internal set; }
    
        public virtual string RequestId { get; internal set; }
    }
}
