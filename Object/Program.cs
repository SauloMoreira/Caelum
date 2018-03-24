using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public override bool Equals(object obj)
        {
            Pessoa outro = (Pessoa)obj;
            return this.Nome == outro.Nome;
        }
        public override int GetHashCode()
        {
            return this.Nome.GetHashCode()+ "fer".GetHashCode();
        }
        public override string ToString()
        {
            return Nome;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa("fulano");
           // Console.WriteLine(p);
            var p1 = new Pessoa("fulano");
            // Console.WriteLine("são iguai?"+p.Equals(p1));
            //Console.WriteLine(p);
            //  object s = null;
            // p.Equals(s);
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(p1.GetHashCode());
        }
    }
}
