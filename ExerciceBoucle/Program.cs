using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceBoucle
{
    class Program
    {
        static void CalculMoyenne(int x, int y)
        {

        }
        static void Main(string[] args)
        {
            var nb = Console.ReadLine();
            int resultat = 0;
            for(int i = 1; i <= Convert.ToInt32(nb); i++)
            {
                resultat += i;
            }
            Console.WriteLine(resultat);
            Console.ReadLine();
            Console.WriteLine("Saisir 5 nombres");
            int[] array = new int[5];
            for (int j = 0; j < 4; j++)
            {
                var nbSaisis = Console.ReadLine();
                array[j] = Convert.ToInt32(nbSaisis);
            }
            int resultat2 = 0;
            foreach (int n in array)
            {
                resultat2 += n;
            }
            Console.WriteLine("La moyenne est de : " + resultat2 / array.Length);


        }
    }
}
