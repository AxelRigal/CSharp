using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceInitiale
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Veuillez rentrer votre prénom suivis de votre nom");

            var prenomNom = Console.ReadLine();

            Console.WriteLine(ClassChaine.RetourneChaine(prenomNom));


            Console.ReadLine();
        }
    }
}
