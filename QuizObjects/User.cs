using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGeo.QuizObjects
{
    public class User
    {
        private int id;
        private string username;

        public override string ToString()
        {
            return username;
        }

        public User(string username, int id = 0)
        {
            this.username = username;
            this.id = id;
        }
    }
}
