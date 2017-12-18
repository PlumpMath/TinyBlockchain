using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;
using System.Text;

namespace TinyBlockchain
{
    public static class Hasher
    {
        public static string GetHash(Block block)
        {

            var mySha256 = SHA256.Create();

            var hashValue = mySha256.ComputeHash(
                Encoding.UTF8.GetBytes(
                    block.Index
                    + block.Timestamp.ToUniversalTime().ToLongTimeString()
                    + block.Data
                    + block.PreviousHashCode
                ));

            return StringifyHash(hashValue);
        }

        public static string StringifyHash(byte[] hashValue)
        {
            if (hashValue.Length == 0)
                return string.Empty;

            var sb = new StringBuilder();

            foreach (Byte b in hashValue)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
