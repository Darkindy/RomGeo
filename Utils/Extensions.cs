using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

using RomGeo.QuizObjects;

namespace RomGeo.Utils
{
    static class Extensions
    {
        // Quiz domain parser from string
        public static Domain GetDomain(this MySqlDataReader str, int index)
        {
            // Will do some parsing here (too lazy right now)
            String aux = str.GetString(index);

            return Utils.Coverters.StringToDomain(aux);
        }

        // MD5 Hash object to string conversion
        public static string GetHash(this MD5 str, string pass)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] hash = str.ComputeHash(inputBytes);

            // Convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
