using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AluraTrilhaCSharp.Modelo;

namespace AluraTrilhaCSharp.Visao
{
    public partial class NovaConta : Form
    {
        private Contas contas;

        public NovaConta(Contas contas)
        {
            this.contas = contas;
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string titular = textoTitular.Text;
            int idade = Convert.ToInt32(textoIdade.Text);
            string cpf = textoCPF.Text;
            int agencia = Convert.ToInt32(textoAgencia.Text);
            int numero = Convert.ToInt32(textoNumero.Text);
            double saldo = Convert.ToDouble(textoSaldo.Text);

            Conta conta;
            if (radioCorrente.Checked)
            {
                conta = new ContaCorrente(titular, idade, cpf, agencia, numero);
            }
            else
            {
                conta = new ContaPoupanca(titular, idade, cpf, agencia, numero);
            }
            conta.Deposita(saldo);
            contas.Adiciona(conta);

            MessageBox.Show(
                "Conta adicionada com sucesso!\n"
                + "\nNome do Titular: " + conta.Titular.Nome
                + "\nIdade do Titular: " + conta.Titular.Idade
                + "\nCPF do Titular: " + conta.Titular.Cpf
                + "\nAgencia: " + conta.Agencia
                + "\nNúmero: " + conta.Numero
                + "\nSaldo: " + conta.Saldo
            );
        }
    }
}
