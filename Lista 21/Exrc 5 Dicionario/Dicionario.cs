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
        public List<k> Chaves { get => chaves; }
        public int Count { get => valores.Count; }
        //public v this[];
        public void Add(k chave, v valor) { chaves.Add(chave); valores.Add(valor); }
        public void Clear() { chaves.Clear(); valores.Clear(); }
        public bool Contains(k chave)
        {
            bool x = false;

            return x;
        }
    }
}
