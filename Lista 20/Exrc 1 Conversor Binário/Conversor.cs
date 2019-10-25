using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrc_1_Conversor_Binário
{
    class Conversor
    {
        private int num;
        private Stack <int> pilha;

        public void SetNum(int num) { this.num = num; }
        public string Binario()
        {
            string x = "";
            while(num % 2 != 0) { x += (num % 2).ToString(); }
            return x;
        }
    }
}
