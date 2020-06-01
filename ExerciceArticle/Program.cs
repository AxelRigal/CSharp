using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArticle
{
    class Program
    {
        static void Main(string[] args)
        {
            Article a = new Article("ref1", "des1", 1000.60, 19.7);
            Console.WriteLine("Calculer prix TTC" +  a.CalculerPrixTTC());

            Console.WriteLine(a.AfficherArticle());
            Console.ReadLine();
        }
    }
}
