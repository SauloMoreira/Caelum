namespace Banco
{
    internal class Cliente
    {
        
        public string Rg { get; set; }
        

        public Cliente(string nome)
        {
            this.Nome = nome;
        }


        public string Nome { get; set; }
    }
}