using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceInitiale
{
    public class ClassChaine
    {
        public static string RetourneChaine(string prenomNom)
        {
            string[] array = prenomNom.Split(' ');
            return array[0].Substring(0, 1).ToUpper() + "." +array[1].Substring(0, 1).ToUpper() + "." ;
        }
    }
}
