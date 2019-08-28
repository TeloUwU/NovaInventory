using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace NovaInventory.Config
{
    class Validaciones
    {
        public static string md5(string value)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(value);
            data = x.ComputeHash(data);
            string rest = "";
            for (int i = 0; i < data.Length; i++)
                rest += data[i].ToString("x2").ToLower();
            return rest;


        }
    }
}
