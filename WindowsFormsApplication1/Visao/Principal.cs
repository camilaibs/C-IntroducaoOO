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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaCorrente();
            conta.Numero = 1111;
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Victor";
            conta.Titular.Rg = "12345697-9";

            MessageBox.Show("Nome: " + conta.Titular.Nome);
            MessageBox.Show("RG: " + conta.Titular.Rg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu primeiro programa C#");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi!");
            MessageBox.Show("Tudo bem?");
        }

        private void btnIdadeMedia_Click(object sender, EventArgs e)
        {
            int idade1 = Convert.ToInt32(txtIdade1.Text);
            int idade2 = Convert.ToInt32(txtIdade2.Text);
            int idade3 = Convert.ToInt32(txtIdade3.Text);
            int media = (idade1 + idade2 + idade3) / 3;
            MessageBox.Show("A média das idades é: " + media);
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);
            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);
            MessageBox.Show("a1: " + a1);
            MessageBox.Show("a2: " + a2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void btnPodeVotar_Click(object sender, EventArgs e)
        {
            string idade = txtPessoaIdade.Text;
            string podeVotar = "Não Pode votar.";

            if (idade != null && idade != String.Empty)
            {
                Pessoa pessoa = new Pessoa(Convert.ToInt32(idade), chkPessoaBrasileira.Checked);
                if (pessoa.podeVotar())
                {
                    podeVotar = "Pode votar.";
                }
            }

            MessageBox.Show(podeVotar);
        }

        private void btnCacularImposto_Click(object sender, EventArgs e)
        {
            string texto = txtNotaValor.Text;
            if (texto != null && texto != String.Empty)
            {
                double valor = Convert.ToDouble(texto);
                double imposto;
                if (valor < 1000)
                {
                    imposto = 0.02; 
                }
                else if (valor < 3000)
                {
                    imposto = 0.025;
                }
                else if (valor < 7000)
                {
                    imposto = 0.028;
                }
                else
                {
                    imposto = 0.03;
                }
                MessageBox.Show("Valor do Imposto: " + valor * imposto);
            }
            else
            {
                MessageBox.Show("Nota inválida.");
            }
        }

        private void btnSoma1A1000_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 0; i < 1000; i++)
            {
                soma += i;
            }
            MessageBox.Show(soma.ToString());
        }

        private void btnImprimirMultiplos_Click(object sender, EventArgs e)
        {
            string multiplos = "";
            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    multiplos += ", " + i;
                }
            }
            MessageBox.Show("Múltiplos: " + multiplos.Substring(2, multiplos.Length - 2));
        }

        private void btnContas_Click(object sender, EventArgs e)
        {
            Contas formulario = new Contas();
            formulario.ShowDialog();
        }
    }
}
