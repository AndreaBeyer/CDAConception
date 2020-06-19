using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitor
{
    public interface Figure
    {
        void Accept(FigureVisitor figureVisitor);
    }
}
