using System;

namespace Banco
{
    public abstract class Conta
    {
        public int numero { get; set; }
        public double saldo { get;private set; }
        internal Cliente Titutar { get; set; }

        public Conta()
        {
        }
        public override string ToString()
        {
            return Titutar.Nome;
        }

        public virtual void Deposita(double valorOperacao)
        {
            saldo += valorOperacao;
        }

        public virtual void Saca(double valorOperacao)
        {
            saldo -= valorOperacao;
        }
    }
}