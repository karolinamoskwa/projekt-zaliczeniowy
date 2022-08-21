using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Gatunek
    {
        public int Id { get; set; }
        public string NameGatunek { get; set; }
        public Gatunek(string nameGatunek)
        {
            NameGatunek = nameGatunek;
        }

        public override string ToString()
        {
            return $"{NameGatunek}";
        }
    }
}
