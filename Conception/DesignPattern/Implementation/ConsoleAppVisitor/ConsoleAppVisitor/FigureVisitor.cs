using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public interface FigureVisitor
    {
        void Visit(Carre carre);
        void Visit(Triangle triangle);
    }
}
