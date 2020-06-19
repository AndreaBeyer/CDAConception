using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public class Carre : Figure
    {
        public void Accept(FigureVisitor figureVisitor)
        {
            figureVisitor.Visit(this);
        }
    }
}
