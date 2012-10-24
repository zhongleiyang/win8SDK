using Oss.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Oss.Deserial
{
    internal class GetObjectMetadataResponseDeserializer : IDeserializer<HttpResponseMessage, ObjectMetadata>
    {
        public GetObjectMetadataResponseDeserializer()
        {
        }

        public ObjectMetadata Deserialize(HttpResponseMessage response)
        {
            ObjectMetadata metadata = new ObjectMetadata();
            foreach (KeyValuePair<string, IEnumerable<string>> header in response.Headers)
            {
                if (header.Key.StartsWith("x-oss-meta-"))
                {
                    metadata.UserMetadata.Add(header.Key.Substring("x-oss-meta-".Length), header.Value.First());
                }
                else
                {
                    if (string.Equals(header.Key, "Content-Length"))
                    {
                        metadata.ContentLength = long.Parse(header.Value.First(), CultureInfo.InvariantCulture);
                        continue;
                    }
                    if (string.Equals(header.Key, "ETag"))
                    {
                        metadata.ETag = OssUtils.TrimETag(header.Value.First());
                        continue;
                    }
                    if (string.Equals(header.Key, "Last-Modified"))
                    {
                        metadata.LastModified = DateUtils.ParseRfc822Date(header.Value.First());
                        continue;
                    }
                    metadata.AddHeader(header.Key, header.Value);
                }
            }
            return metadata;
        }
    }
}
