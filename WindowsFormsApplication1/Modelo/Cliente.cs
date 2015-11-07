namespace AluraTrilhaCSharp.Modelo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string titular, int idade, string cpf)
        {
            this.Nome = titular;
            this.Idade = idade;
            this.Cpf = cpf;
        }

        public bool EhMaiorDeIdade()
        {
            return Idade >= 18;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}