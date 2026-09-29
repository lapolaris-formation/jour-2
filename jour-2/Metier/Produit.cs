using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jour_2.Metier
{
    internal class Produit
    {
        public string Reference { get; }
        public string Nom { get; }
        public double Prix { get; }

        public Produit(string reference, string nom, double prix)
            {
                Reference = reference;
                Nom = nom;
                Prix = prix;
            }
        }
}
