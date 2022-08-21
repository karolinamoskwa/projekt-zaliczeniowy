using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class NazwaGra
    {
        public int Id { get; set; }
        public string NameGry { get; set; }
        public NazwaGra(string nameGry)
        {
            NameGry = nameGry;
        }

        public override string ToString()
        {
            return $"{NameGry}";
        }
    }
}
