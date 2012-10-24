using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oss.Model
{
    public class ListPartModel
    {
         [XmlElement("PartNumber")]
        public UInt32 PartNumber { get; set; }
         [XmlElement("ETag")]
        public string ETag { get; set; }
        [XmlElement("Size")]
        public UInt32 Size { get; set; }
        [XmlElement("LastModified")]
        public DateTime LastModified { get; set; }
    }
}
