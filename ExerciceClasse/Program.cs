using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBancaire cp = new CompteBancaire("Moi", 10000, "euros");
            cp.Crediter(500);
            Console.WriteLine(cp.Decrire());
            cp.Debiter(500);
            Console.WriteLine(cp.Decrire());
            Console.ReadLine();
        }
    }
}
