using Oss.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oss
{
    public class ListObjectsRequest
    {
        public ListObjectsRequest(string bucketName)
        {
            var loader = new Windows.ApplicationModel.Resources.ResourceLoader();
            
            if (string.IsNullOrEmpty(bucketName))
            {
                var text = loader.GetString("ExceptionIfArgumentStringIsNullOrEmpty");
                throw new ArgumentException(text, "bucketName");
            }
            if (!OssUtils.IsBucketNameValid(bucketName))
            {
                var text = loader.GetString("BucketNameInvalid");
                throw new ArgumentException(text, "bucketName");
            }
            this.BucketName = bucketName;
        }

        public string BucketName { get; private set; }

        public string Delimiter { get; set; }

        public string Marker { get; set; }

        public int? MaxKeys { get; set; }

        public string Prefix { get; set; }
    }
}
