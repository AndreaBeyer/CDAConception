using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorModeration
{
    public class Moderator : IModerator
    {
        public Moderator()
        {
        }

        public void Moderate()
        {
            Console.WriteLine("Je realise la modération générale");
        }
    }
}
