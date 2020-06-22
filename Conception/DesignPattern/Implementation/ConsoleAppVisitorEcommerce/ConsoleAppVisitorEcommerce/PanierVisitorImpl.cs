using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorEcommerce
{
    public class PanierVisitorImpl : IPanierVisitor
    {
        double IPanierVisitor.Visit(Livre livre)
        {
            double cout = livre.Prix;
            if(livre.Prix > 30)
            {
                cout = livre.Prix - 5;
            }
            Console.WriteLine($"Livre : {livre.Titre} prix : {livre.Prix}");
            return cout;
        }

        double IPanierVisitor.Visit(Fruit fruit)
        {
            double cout = fruit.PrixAuKg * fruit.Poids;
            Console.WriteLine($"Fruit : {fruit.Nom} prix : {cout.ToString("#.##")}");
            return cout;
        }
    }
}
