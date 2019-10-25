using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_2_Pilha_utilizando_uma_Lista
{
    class Pilha1<T>
    {
        private List<T> lista;
        ArrayList v = new ArrayList();
        private int k;
        public int Count()
        {
            ArrayList r = new ArrayList(k);
            Array.Copy(v, r, k);
            return int.Parse(r);
        }
        public T Top() { return v[v.Length-1]; }
        public void Pop() { v.Remove(); }
        public void Push(T obj) { if (k < 50) v[k++] = obj; }
    }
}
