using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryComposite
{
    public class Composite : Component
    {
        private List<Component> components;

        public List<Component> Components { get => components; }

        public Composite(string nom) : base(nom)
        {
            components = new List<Component>();
        }

        public override void Operation()
        {
            string tempS = "";

            for (int i = 0; i < niveau; i++)
            {
                tempS += "--";
            }

            Console.WriteLine($"{tempS} Element conteneur : {nom}");

            foreach(Component c in components)
            {
                c.Operation();
            }
        }

        public void AddComponent(Component _component)
        {
            _component.niveau = this.niveau + 1;
            components.Add(_component);
        }

        public void RemoveComponant(Component _component)
        {
            components.Remove(_component);
        }
    }
}
