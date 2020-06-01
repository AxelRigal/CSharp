using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> mesFruits = new List<string>();
            mesFruits.Add("banane");
            mesFruits.Add("pomme");
            mesFruits.Add("fruit de la passion");
            mesFruits.Add("orange");
            mesFruits.Add("mangue");
            mesFruits.Remove("banane");

            foreach (string fruit in mesFruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadLine();
        }
    }
}
