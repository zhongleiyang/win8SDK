using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;

namespace Oss
{
     //KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(this.SignatureMethod.ToString().ToUpperInvariant()
    internal class HmacSHA1Signature : ServiceSignature
    {
        private Encoding _encoding = Encoding.UTF8;

        protected override string ComputeSignatureCore(string key, string data)
        {
            MacAlgorithmProvider algorithm = MacAlgorithmProvider.OpenAlgorithm(MacAlgorithmNames.HmacSha1);
        
            // Create a buffer that contains the message to be signed.
            BinaryStringEncoding encoding = BinaryStringEncoding.Utf8;
            IBuffer buffMsg = CryptographicBuffer.ConvertStringToBinary(data, encoding);

            IBuffer buffKey = CryptographicBuffer.ConvertStringToBinary(key, encoding);


            CryptographicKey hmacKey = algorithm.CreateKey(buffKey);

            // Sign the key and message together.
            IBuffer buffHMAC = CryptographicEngine.Sign(hmacKey, buffMsg);
            return CryptographicBuffer.EncodeToHexString(buffHMAC);

        }

        public override string SignatureMethod
        {
            get
            {
                return "HmacSHA1";
            }
        }

        public override string SignatureVersion
        {
            get
            {
                return "1";
            }
        }
    }
}
