using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_cv_.EFCore
{
    internal class Hodnoceni
    {
        public int IdStudent { get; set; }
        public string ZkratkaPredmet { get; set; }
        public DateTime Datum { get; set; }
        public short Znamka { get; set; }
    }
}
