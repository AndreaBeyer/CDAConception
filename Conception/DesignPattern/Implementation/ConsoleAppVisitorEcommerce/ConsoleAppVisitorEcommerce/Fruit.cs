using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorEcommerce
{
    public class Fruit : IProduit
    {
        private string nom;
        private double poids;
        private double prixAuKg;

        public Fruit(string nom, double poids, double prixAuKg)
        {
            this.nom = nom;
            this.poids = poids;
            this.prixAuKg = prixAuKg;
        }

        public string Nom { get => nom; set => nom = value; }
        public double Poids { get => poids; set => poids = value; }
        public double PrixAuKg { get => prixAuKg; set => prixAuKg = value; }

        public double Accept(IPanierVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
