using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaInvestimento: Conta,ITributavel
    {
        public double CalculaTributo()
        {
            return this.saldo + 0.03;
        }
    }
}
