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
            foreach (int c in lista) return c;
        }
        public T Top() { }
        public T Pop() { int x = q1.Count(); x--; q1.RemoveAt(x); q2.RemoveAt(x); }
        public void Push(T obj)
        {
            q1.Add(obj); q2.Add(obj);
        }
    }
}
