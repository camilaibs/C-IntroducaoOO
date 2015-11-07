namespace AluraTrilhaCSharp.Modelo
{
    public abstract class Conta
    {
        public static int quantidade = 0;

        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
            quantidade++;
        }

        public Conta(string titular, int idade, string cpf, int agencia, int numero) : this()
        {
            this.Titular = new Cliente(titular, idade, cpf);
            this.Agencia = agencia;
            this.Numero = numero;
        }

        public virtual void Saca(double valor)
        {
            if (valor >= 0 && valor <= this.Saldo)
            {
                if (Titular.EhMaiorDeIdade() || (!Titular.EhMaiorDeIdade() && valor < 200))
                {
                    Saldo -= valor;
                }
            }
        }

        public void Deposita(double valor)
        {
            if (valor >= 0)
            {
                Saldo += valor;
            }
        }

        public void Transfere(double valor, Conta conta)
        {
            this.Saca(valor);
            conta.Deposita(valor);
        }
    }
}