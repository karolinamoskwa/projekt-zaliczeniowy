using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class Admini
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public Admini(string login, string haslo)
        {
            Login = login;
            Haslo = haslo;
        }
    }
}
