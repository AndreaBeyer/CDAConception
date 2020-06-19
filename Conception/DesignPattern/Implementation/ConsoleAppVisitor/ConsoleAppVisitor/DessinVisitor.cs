using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public class DessinVisitor : FigureVisitor
    {
        public void Visit(Carre carre)
        {
            //implementter propriété
            Console.WriteLine("Dessin d'un carré");
        }

        public void Visit(Triangle triangle)
        {
            Console.WriteLine("Dessin d'un triangleq");
        }
    }
}
