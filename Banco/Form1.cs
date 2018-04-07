using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        
       // private ContaPoupanca c1;
       // private ContaCorrente c2;
       // private Conta[] contas;
        private int numerodeContas;
        private List<Conta> contas;

        public void AdicionarContas(Conta conta)
        {
            this.contas.Add(conta);
            this.numerodeContas++;
            ComboContas.Items.Add(conta);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.contas = new List<Conta>();
            Conta c1 = new ContaCorrente();
            c1.Titutar = new Cliente("Lucas");
            c1.numero = 1;
            this.AdicionarContas(c1);
            Conta c2  = new ContaPoupanca();
            c2.Titutar = new Cliente("Saulo");
            c2.numero = 2;
            this.AdicionarContas(c2);
            Conta c3 = new ContaCorrente();
            c3.Titutar = new Cliente("Roberto");
            c3.numero = 3;
            this.AdicionarContas(c3);
         
        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            if (textBusca.Text == "")
            {

                int indice1 = ComboContas.SelectedIndex;
                Conta selecionada = this.contas[indice1];
                string valorDigitado = textValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                selecionada.Deposita(valorOperacao);
                textSaldo.Text = Convert.ToString(selecionada.saldo);
            }
            else
            {
                int indice = Convert.ToInt32(textBusca.Text);
                Conta selecionada = this.contas[indice];
                string valorDigitado = textValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                selecionada.Deposita(valorOperacao);
                textSaldo.Text = Convert.ToString(selecionada.saldo);
            }

           MessageBox.Show("Deposito feito com sucesso");
        }

        private void btnSaca_Click(object sender, EventArgs e)
        {
            if (textBusca.Text == "")
            {
            
              int indice1 =  ComboContas.SelectedIndex;
                Conta selecionada = this.contas[indice1];
                string valorDigitado = textValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                selecionada.Saca(valorOperacao);
                textSaldo.Text = Convert.ToString(selecionada.saldo);
            }
            else
            {
                int indice = Convert.ToInt32(textBusca.Text);
                Conta selecionada = this.contas[indice];
                string valorDigitado = textValor.Text;
                double valorOperacao = Convert.ToDouble(valorDigitado);
                selecionada.Saca(valorOperacao);
                textSaldo.Text = Convert.ToString(selecionada.saldo);
            }

            MessageBox.Show("Saque feito com sucesso");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(textBusca.Text);
            Conta selecionada = this.contas[indice];
            textNumero.Text = Convert.ToString(selecionada.numero);
            textTitular.Text = Convert.ToString(selecionada.Titutar.Nome);
            textSaldo.Text = Convert.ToString(selecionada.saldo);
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textTitular.Text = selecionada.Titutar.Nome;
            textNumero.Text = Convert.ToString(selecionada.numero);
            textSaldo.Text = Convert.ToString(selecionada.saldo);
        }

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta origen = this.contas[indice];
            int indice2 = comboDestinoTransferencia.SelectedIndex;
            Conta destino = this.contas[indice2];
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            origen.Saca(valorOperacao);
            destino.Deposita(valorOperacao);
            textTitular2.Text = destino.Titutar.Nome;
            textNumero2.Text = Convert.ToString(destino.numero);
            textSaldo2.Text = Convert.ToString(destino.saldo);

        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formulariodeCadastro = new FormCadastroConta(this);
            formulariodeCadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contaSaldoPositiva = contas.Where(c => c.saldo > 0).OrderBy(c => c.Titutar.Nome);

            foreach (var conta in contaSaldoPositiva)
            {
                MessageBox.Show("Conta: " + conta.numero);
            }
            var TitulareseSaldos = contas.Select(c => new { c.saldo, c.Titutar.Nome });
            foreach (var conta in TitulareseSaldos)
            {
                MessageBox.Show("Titulares: " + conta.Nome);
            }
            var TotaldeSaldos = contas.Sum(c => c.saldo);
            MessageBox.Show("Saldo no Banco de todas as contas: " + TotaldeSaldos);


        }
    }
}
