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
        public int Count()
        {
            ArrayList r = new ArrayList(k);
            Array.Copy(v, r, k);
            return int.Parse(r);
        }
        public T Top() { return v[v.Length - 1]; }
        public T Pop() { q1.Remove(); q2.Remove(); }
        public void Push(T obj)
        {
            q1.Add(obj); q2.Add(obj);
        }
    }
}
