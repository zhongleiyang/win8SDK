using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Oss.Model
{
    [XmlRoot("CommonPrefixes"), XmlType(AnonymousType = true)]
    public class ListBucketResultCommonPrefixes
    {
        private string[] prefixField;

        [XmlElement("Prefix")]
        public string[] Prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }
    }
}
