using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluraTrilhaCSharp.Modelo;

namespace AluraTrilhaCSharp.Controle
{
    class TotalizadorDeContas
    {
        public double SaldoTotal { get; private set; }

        public void adiciona(Conta conta)
        {
            this.SaldoTotal += conta.Saldo;
        }
    }
}
