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
        public int Count()
        {
            foreach (int c in lista) return c;
        }
        public T Top() { return lista.Peek(); }
        public void Pop() { lista.Remove(); }
        public void Push(T obj) { lista.Push(obj); }
    }
}
