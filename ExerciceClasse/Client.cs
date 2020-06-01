using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceClasse
{
    class Client
    {
        public string _cin { get; set; }
        public string _nom { get; set; }
        public string _prenom { get; set; }
        public string _numero { get; set; }

        public Client(string c, string n, string p, string num)
        {
            _cin = c;
            _nom = n;
            _prenom = p;
            _numero = num;
        }

        internal string Afficher()
        {
            return " CIN : " + _cin + " Nom : " + _nom + " Prenom " + _prenom + " Numero " + _numero;
        }
    }
}
