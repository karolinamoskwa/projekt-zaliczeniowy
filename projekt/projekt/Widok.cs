using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Widok
    {
        public int Id { get; set; }
        public string NameWidok { get; set; }
        public Widok(string nameWidok)
        {
            NameWidok = nameWidok;
        }

        public override string ToString()
        {
            return $"{NameWidok}";
        }
    }
}
