using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    //Concrete vivitor 1
    public class AffichageVisitor : FigureVisitor
    {
        public void Visit(Carre carre)
        {
            Console.WriteLine("Je suis un carre");
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Je suis un triangle");
        }
    }
}
