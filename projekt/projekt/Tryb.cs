using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Tryb
    {
        public int Id { get; set; }
        public string NameTryb { get; set; }
        public Tryb(string nameTryb)
        {
            NameTryb = nameTryb;
        }

        public override string ToString()
        {
            return $"{NameTryb}";
        }
    }
}
