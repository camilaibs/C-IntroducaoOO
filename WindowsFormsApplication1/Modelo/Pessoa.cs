using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTrilhaCSharp.Modelo
{
    class Pessoa
    {
        public int idade;
        public bool brasileira;

        public Pessoa(int idade, bool brasileira)
        {
            this.idade = idade;
            this.brasileira = brasileira;
        }

        public bool podeVotar()
        {
            return idade > 16 && brasileira;
        }
    }
}
