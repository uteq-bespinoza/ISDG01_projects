﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBase64
{
    public static class Base64EncryptService
    {

        public static string Encriptar(string dato)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(dato))
            {
                byte[] byteArray = Encoding.UTF8.GetBytes(dato);
                result = Convert.ToBase64String(byteArray);
            }
            return result;
        }

        public static string Decriptar(string base64)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(base64))
            {
                byte[] array = Convert.FromBase64String(base64);
                result = Encoding.UTF8.GetString(array);
            }

            return result;
        }
    }
}
