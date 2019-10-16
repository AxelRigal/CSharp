using System;
using System.Text;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(12 + 5 * 12.5 - 1253.68);
            Console.WriteLine("Moyenne de {1.0,5.5,9.9,2.8,9.6");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" Rentre le rayon d'un Cercle ");
            var rayon = Console.ReadLine();
            StringBuilder stringBuilderPerimetre = new StringBuilder();
            stringBuilderPerimetre.Append("Le périmetre du Cercle est: ");
            double perimetre = (2 *  Convert.ToDouble(rayon)) * Math.PI ;
            stringBuilderPerimetre.Append(perimetre);
            Console.WriteLine(stringBuilderPerimetre);
            StringBuilder stringbuilderSurface = new StringBuilder();
            stringbuilderSurface.Append("La surface du Cercle est : ");
            double surface = (Convert.ToDouble(rayon) * Convert.ToDouble(rayon)) * Math.PI;
            stringbuilderSurface.Append(surface);
            Console.WriteLine(stringbuilderSurface);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Ecrire une chaine de 5 caractères");
            string chaineString = Console.ReadLine();
            char[] chaine = chaineString.ToCharArray();
            chaine[0] = Class1.RetourneChaine(chaine[0]);
            chaine[1] = Class1.RetourneChaine(chaine[1]);
            chaine[2] = Class1.RetourneChaine(chaine[2]);
            chaine[3] = Class1.RetourneChaine(chaine[3]);
            chaine[4] = Class1.RetourneChaine(chaine[4]);
            Console.WriteLine(chaine);
        }
    }
}
