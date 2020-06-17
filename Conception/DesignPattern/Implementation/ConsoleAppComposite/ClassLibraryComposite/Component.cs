using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public abstract class Component
    {
        protected string nom;

        public int niveau;

        public Component(string nom)
        {
            this.nom = nom;
        }

        

        public abstract void Operation();
    }
}
