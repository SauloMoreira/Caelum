namespace Banco
{
    public class ContaCorrente:Conta
    {
        private static int totalContaCorrente;

        public ContaCorrente()
        {
            ContaCorrente.totalContaCorrente++;
        }
        public int proximaConta()
        {
            return ContaCorrente.totalContaCorrente + 1;
        }

    }
}