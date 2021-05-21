using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ToDoList
{
    public static class Extensions
    {
        public static string encrypt(string val, string key)
        {
            return new Crypto(key).Encrypt(val);
        }
    }
}
