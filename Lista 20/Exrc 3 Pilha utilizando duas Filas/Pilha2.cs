using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_3_Pilha_utilizando_duas_Filas
{
    class Pilha2<T>
    {
        private Queue<T> q1, q2;
        ArrayList v = new ArrayList();
        ArrayList z = new ArrayList();
        private int k, x;
        public int Count()
        {
            ArrayList r = new ArrayList(k);
            Array.Copy(v, r, k);
            return int.Parse(r);
        }
        public T Top() { return v[v.Length - 1]; }
        public T Pop() { v.Remove(); z.Remove(); }
        public void Push(T obj) { if (k < 50) v[k++] = obj; }
    }
}
