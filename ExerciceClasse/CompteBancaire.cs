using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceClasse
{
    class CompteBancaire
    {
        public string _titulaire { get; set; }

        public string _devise { get; set; }
        private double _solde;
        private int _nbCompte;

        public CompteBancaire(string t, double s, string d)
        {
            _solde = s;
            _titulaire = t;
            _devise = d;
        }

        internal void Crediter(double montant)
        {
            _solde = _solde + montant;
        }
        internal void Debiter(double montant)
        {
            _solde = _solde - montant;
        }

        public double GetSolde()
        {
            return _solde;
        }
        internal string Decrire()
        {
            return " Titulaire : " + _titulaire + " / Solde : " + _solde + " / Devise : " + _devise;
        }
    }
}
