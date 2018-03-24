using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 FormPrincipal;

        public FormCadastroConta(Form1 FormPrincipal)
        {
            this.FormPrincipal = FormPrincipal;
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titutar = new Cliente(textToTitular.Text);
            novaConta.numero = Convert.ToInt32(textToNumero.Text);
            
            this.FormPrincipal.AdicionarContas(novaConta);
            this.Close();
        }


    }
}
