using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTrilhaCSharp.Modelo
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {
        }

        public ContaCorrente(string titular, int idade, string cpf, int agencia, int numero) : base(titular, idade, cpf, agencia, numero)
        {
        }
    }
}
