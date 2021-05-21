using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ToDoList
{
    public class Crypto
    {
        TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

        public Crypto(string key)
        {
            if (key.isEmpty())
                key = secretKey;

            TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
        }

        /// <summary>
        /// Şifreleme işlevleirni yapar
        /// </summary>
        public Crypto()
            : this(null)
        {
            //
        }
        public string Encrypt(string val)
        {
            try
            {
                byte[] plaintextBytes = System.Text.Encoding.Unicode.GetBytes(val);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                CryptoStream encStream = new CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write);
                encStream.Write(plaintextBytes, 0, plaintextBytes.Length);
                encStream.FlushFinalBlock();

                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
