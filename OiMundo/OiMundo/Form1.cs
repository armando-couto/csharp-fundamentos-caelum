using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorDoSaque = 10.0;
            double valorAposSaque = saldo - valorDoSaque;

            MessageBox.Show("O saldo da conta após o saque é: " + valorAposSaque);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            bool realmentePodeSacar = (saldo >= valorSaque) && (valorSaque > 0);

            if (realmentePodeSacar)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            for (int i = 1; i <= 12; i += 1)
            {
                valorInvestido = valorInvestido * 1.01;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorInvestido = 1000.0;
            int i = 1;
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }
            MessageBox.Show("Valor investido agora é " + valorInvestido);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    MessageBox.Show("numero = " + i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int valor = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    valor += i;
                }
            }
            MessageBox.Show("Valor total é: " + valor);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Conta conta1 = new Conta();
            conta1.titular = "Armando Couto";
            conta1.numero = 0206;
            conta1.saldo = 2530.00;

            Conta conta2 = new Conta();
            conta2.titular = "Jéssica Adamy";
            conta2.numero = 21;
            conta2.saldo = 20000.56;

            MessageBox.Show(conta1.titular);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            mauricio.saldo = 1000.0;
            mauricio.Saca(150.0);

            MessageBox.Show("Valor é: "+mauricio.saldo);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Conta mauricio = new Conta();
            Conta guilherme = new Conta();

            mauricio.Transfere(100, guilherme);

            MessageBox.Show("Saldo do Maurício é: " + mauricio.saldo);
            MessageBox.Show("Saldo do Guilherme é: " + guilherme.saldo);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cliente victor = new Cliente(); // Tem que instanciar antes o Objeto mais interno e depois atribuir no Objeto mais externo.
            Conta umaConta = new Conta();
            umaConta.cliente = victor;
            umaConta.cliente.nome = "victor";
            umaConta.cliente.rg = "12345678-9";

            MessageBox.Show(umaConta.cliente.nome);
        }
    }
}
