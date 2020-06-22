using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorEcommerce
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            List<IProduit> monPanier = new List<IProduit>();
            monPanier.Add(new Livre("Notre-Dame de Paris", 23));
            monPanier.Add(new Fruit("Pomme", 1.5, 3.5));
            monPanier.Add(new Livre("Germinal", 35));

            IPanierVisitor panierVisitor = new PanierVisitorImpl();

            Console.WriteLine("Panier");

            double coutTotal = 0;

            foreach(IProduit produit in monPanier)
            {
                coutTotal += produit.Accept(panierVisitor);
            }

            Console.WriteLine($"\nTotal : {coutTotal.ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
