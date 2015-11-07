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
    public partial class Contas : Form
    {
        private List<Conta> Lista = new List<Conta>();

        public Contas()
        {
            InitializeComponent();
        }

        private void MostraConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);
        }

        private Conta BuscaContaSelecionada()
        {
            return (Conta) comboContas.SelectedItem;
        }

        private double BuscaValor()
        {
            return Convert.ToDouble(textoValor.Text);
        }

        private void Contas_Load(object sender, EventArgs e)
        {
            Lista[0] = new ContaCorrente()
            {
                Numero = 1,
                Titular = new Cliente("Titular1")
            };

            Lista[1] = new ContaPoupanca()
            {
                Numero = 2,
                Titular = new Cliente("Titular2")
            };

            foreach (Conta conta in Lista)
            {
                comboContas.DisplayMember = "Titular";
                comboContas.Items.Add(conta);
                comboDestinoDeTransferencia.DisplayMember = "Titular";
                comboDestinoDeTransferencia.Items.Add(conta);
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta selecionada = BuscaContaSelecionada();
            MostraConta(selecionada);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            Conta selecionada = BuscaContaSelecionada();
            double valor = BuscaValor();
            selecionada.Saca(valor);
            MostraConta(selecionada);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            Conta selecionada = BuscaContaSelecionada();
            double valor = BuscaValor();
            selecionada.Deposita(valor);
            MostraConta(selecionada);
        }

        private void botaoTransferir_Click(object sender, EventArgs e)
        {
            double valor = BuscaValor();
            Conta selecionada = BuscaContaSelecionada();
            Conta destinoDeTransferencia = Lista[comboDestinoDeTransferencia.SelectedIndex];
            selecionada.Transfere(valor, destinoDeTransferencia);
            MostraConta(selecionada);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            NovaConta formulario = new NovaConta(this);
            formulario.ShowDialog();
        }

        public void Adiciona(Conta conta)
        {
            Lista.Add(conta);
            comboContas.Items.Add(conta);
        }
    }
}
