using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraTrilhaCSharp.Modelo
{
    class ContaPoupanca : Conta, ITributavel
    {

        public ContaPoupanca()
        {
        }
        public ContaPoupanca(string titular, int idade, string cpf, int agencia, int numero) : base(titular, idade, cpf, agencia, numero)
        {
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.1);
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }
    }
}
