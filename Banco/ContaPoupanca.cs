using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
  public  class ContaPoupanca: Conta, ITributavel
    {
        public override void Saca(double valorOperacao)
        {
            base.Saca(valorOperacao + 0.05);
        }
        public override void Deposita(double valorOperacao)
        {
            base.Deposita(valorOperacao + 0.10);
        }
        public double CalculaTributo()
        {
            return this.saldo + 0.02;
        }
    }
}
