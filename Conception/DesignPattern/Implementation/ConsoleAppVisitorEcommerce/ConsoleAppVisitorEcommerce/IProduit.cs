using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVisitorEcommerce
{
    public interface IProduit
    {
        double Accept(IPanierVisitor visitor);
    }
}
