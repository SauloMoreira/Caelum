using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    class Carro
    {
        //Cor, Modelo, Marca, Ano e Preco 
        public string Cor { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            //Fusca Azul(VW) / 1974 - 527.99
            return $"{Modelo} { Cor}({ Marca})/{ Ano}-{ Preco}";
            
        }
        public override bool Equals(object obj)
           
        {
            if (!(obj is Carro))
            {
                return false;
            }
            Carro outro = (Carro)obj;
            return (this.Modelo == outro.Modelo) && (this.Cor == outro.Cor) && (this.Marca==outro.Marca) && (this.Ano==outro.Ano);
            
        }



        public override int GetHashCode()
        {
            return 154 + this.Modelo.GetHashCode()+ this.Cor.GetHashCode()+ this.Marca.GetHashCode()+.GetHashCode().GetHashCode();
        }
    }
}
