using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceDictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> monDictionnaire = new Dictionary<string, int>();
            monDictionnaire.Add("Georges", 34);
            monDictionnaire.Add("Bill", 14);
            monDictionnaire.Add("Raphael", 20);
            monDictionnaire.Add("Geoffrey", 40);
            monDictionnaire.Add("Axel", 28);
            monDictionnaire.Add("Tiffaine", 21);
            Console.WriteLine(monDictionnaire["Georges"]);
            Console.WriteLine(monDictionnaire["Bill"]);
            Console.WriteLine(monDictionnaire["Axel"]);
            monDictionnaire.Remove(monDictionnaire.Keys.ElementAt(2));
            monDictionnaire.Remove(monDictionnaire.Keys.ElementAt(3));
            int count = 0;
            foreach (var item in monDictionnaire)
            {
                Console.WriteLine(" prenom : " + item.Key + " age " + item.Value);
                count++;
            }
            Console.ReadLine();
        }
    }
}
