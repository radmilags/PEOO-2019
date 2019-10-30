using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_4_Jogo
{
    class Jogo
    {
        private string nome;
        private List<Jogador> jogs = new List<Jogador>();
        private int k;
        public Jogo(string n) { nome = n; }
        public void Inserir(Jogador j)
        {
            jogs[k++] = j;
        }
        public List<Jogador> Listar()
        {
            List<Jogador> r = new List<Jogador>(k);
            Array.Copy(jogs, r, k);
            return r;
        }
    }
}
