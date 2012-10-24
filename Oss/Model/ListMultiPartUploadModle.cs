using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oss.Model
{
    
    public class ListMultiPartUploadModle
    {
         [XmlElement("Key")]
        public string Key { get; set; }
         [XmlElement("UploadId")]
        public string UploadId { get; set; }
         [XmlElement("Initiated")]
        public DateTime Initiated { get; set; }
    }
}
