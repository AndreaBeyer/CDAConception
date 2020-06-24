using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorModeration
{
    public class ModeratorAdultContent : IModerator
    {
        IModerator myModerator;

        public ModeratorAdultContent(IModerator myModerator)
        {
            this.myModerator = myModerator;
        }

        public void Moderate()
        {
            myModerator.Moderate();
            Console.WriteLine("Je modere le contenu pour adulte");
        }
    }
}
