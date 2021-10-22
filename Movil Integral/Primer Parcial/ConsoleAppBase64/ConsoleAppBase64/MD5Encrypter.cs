using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;

namespace ConsoleAppBase64
{
    public static class MD5Encrypter
    {
        public static string MD5Encrypt(string data)
        {
            string encripted = string.Empty;
            using (MD5 md5Handler = MD5.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                var hash = md5Handler.ComputeHash(bytes);
                StringBuilder strBuilder = new StringBuilder();
                foreach (byte b in hash)
                {
                    //change it into 2 hexadecimal digits  
                    //for each byte  
                    strBuilder.Append(b.ToString("x2"));
                }

                encripted = strBuilder.ToString();
            }
            return encripted;
        }

        public static bool ValidateMD5(string original, string encripted)
        {
            StringComparer comparer = StringComparer.InvariantCultureIgnoreCase;

            return comparer.Compare(original, encripted) == 0;

        }
    }
}
