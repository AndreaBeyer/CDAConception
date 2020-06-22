using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorEcommerce
{
    public class Livre : IProduit
    {
        private string titre;
        private double prix;

        public Livre(string titre, double prix)
        {
            this.titre = titre;
            this.prix = prix;
        }

        public string Titre { get => titre; set => titre = value; }
        public double Prix { get => prix; set => prix = value; }

        public double Accept(IPanierVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
