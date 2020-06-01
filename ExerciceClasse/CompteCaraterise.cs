using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceClasse
{
    class CompteCaraterise : Client
    {
        private string _numeroCompte { get; set; }
         
        public CompteCaraterise(string c, string n, string p, string num) : base(c, n, p, num)
        {
        }
    }
}
