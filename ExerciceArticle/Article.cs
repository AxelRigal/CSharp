using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArticle
{
    class Article
    {
        public string _ref { get; set; }
        public string _designation { get; set; }
        public double _prixHT { get; set; }
        public double _tauxTVA { get; set; }

        public Article()
        {

        }

        public Article(string r, string d, double p, double t)
        {
            _ref = r;
            _designation = d;
            _prixHT = p;
            _tauxTVA = t;
        }

        public Article(string r, string d)
        {
            _ref = r;
            _designation = d;
        }

        internal double CalculerPrixTTC()
        {
            return _prixHT + (_prixHT * _tauxTVA / 100);
        }

        internal string AfficherArticle()
        {
            return " Ref : " + _ref + " Designation " + _designation + " PrixHT " + _prixHT + " TauxTVA : " + _tauxTVA ;
        }
    }
}
