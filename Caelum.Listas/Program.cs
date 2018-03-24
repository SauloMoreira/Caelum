using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var Lista = new List<string>();
            Lista.Add("Maçã");
            Lista.Add("Banana");
            Lista.Add("Uva");
            Lista.Add("Uva");
            Console.WriteLine(Lista.Count);
            var conj = new HashSet<string> { "Maçã", "Banana", "Uva" };
            conj.Add("Uva");
            Console.WriteLine(conj.Count);
        }
    }
}
