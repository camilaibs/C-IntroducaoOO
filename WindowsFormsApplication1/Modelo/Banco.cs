using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTrilhaCSharp.Modelo
{
    class Banco
    {
        private int i = 0;
        public Conta[] contas { get; private set; }

        public void adiciona(Conta conta)
        {
            if (contas == null)
            {
                contas = new Conta[100];
            }
            
            if (contas.Length - 1 < i)
            {
                contas[++i] = conta;
            }
        }
    }
}
