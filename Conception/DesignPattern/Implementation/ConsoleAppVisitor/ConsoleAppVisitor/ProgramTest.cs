using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Carre carre = new Carre();
            Triangle triangle = new Triangle();
            Dessin dessin = new Dessin(carre, triangle);

            AffichageVisitor affichageVisitor = new AffichageVisitor();
            DessinVisitor dessinVisitor = new DessinVisitor();

            dessin.Triangle.Accept(affichageVisitor);
            dessin.Carre.Accept(dessinVisitor);

        }
    }
}
