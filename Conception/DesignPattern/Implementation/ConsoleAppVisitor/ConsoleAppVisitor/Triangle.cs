using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public class Triangle : Figure
    {
        //ajouter des propriétés, d'autres visitors...
        //Enrichir l'application
        public void Accept(FigureVisitor figureVisitor)
        {
            figureVisitor.Visit(this);
        }
    }
}
