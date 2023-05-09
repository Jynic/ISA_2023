using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace rawatJalan_LIB
{
    public class DesCrypto
    {
        public string Encrypt(string key, string plaintext)
        {
            using (DESCryptoServiceProvider crypto = new DESCryptoServiceProvider())
            {
                byte[] keys = Encoding.UTF8.GetBytes(key);
                ICryptoTransform encryptor = crypto.CreateEncryptor(keys, keys);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);
                byte[] cipher = Encoding.UTF8.GetBytes(plaintext);
                cs.Write(cipher, 0, cipher.Length);
                cs.FlushFinalBlock();
                // ubah menjadi string agar bisa dibaca
                string encryptedMessage = Convert.ToBase64String(ms.ToArray());

                return encryptedMessage;
            }
        }

        public string Decrypt(string key, string cipherText)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);
            using (DESCryptoServiceProvider crypto = new DESCryptoServiceProvider())
            {
                byte[] keys = Encoding.UTF8.GetBytes(key);
                ICryptoTransform decryptor = crypto.CreateDecryptor(keys, keys);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write);
                cs.Write(buffer, 0, buffer.Length);
                cs.FlushFinalBlock();

                string decryptedMessage = Encoding.UTF8.GetString(ms.ToArray());
                return decryptedMessage;
            }
        }
    }
}
