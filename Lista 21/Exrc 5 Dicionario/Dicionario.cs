using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_5_Dicionario
{
    class Dicionario<k,v>
    {
        private List<k> chaves = new List<k>();
        private List<v> valores = new List<v>();
    }
}
