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
    [XmlType(AnonymousType = true), DebuggerStepThrough, GeneratedCode("xsd", "4.0.30319.1")]
    public class ListBucketResultContents
    {
        private string eTagField;
        private string keyField;
        private DateTime lastModifiedField;
        private Owner ownerField;
        private long sizeField;
        private string storageClassField;
        private string typeField;

        [XmlElement("ETag")]
        public string ETag
        {
            get
            {
                return this.eTagField;
            }
            set
            {
                this.eTagField = value;
            }
        }

        [XmlElement("Key")]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        [XmlElement("LastModified")]
        public DateTime LastModified
        {
            get
            {
                return this.lastModifiedField;
            }
            set
            {
                this.lastModifiedField = value;
            }
        }

        [XmlElement("Owner")]
        public Owner Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }

        [XmlElement("Size")]
        public long Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        [XmlElement("StorageClass")]
        public string StorageClass
        {
            get
            {
                return this.storageClassField;
            }
            set
            {
                this.storageClassField = value;
            }
        }

         [XmlElement("Type")]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}
