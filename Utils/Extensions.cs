using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using RomGeo.QuizObjects;

namespace RomGeo.Utils
{
    static class Extensions
    {
        // Quiz domain parser from string
        public static Domain GetDomain(this MySqlDataReader str, int index)
        {
            Domain result = 0;



            return result;
        }
    }
}
