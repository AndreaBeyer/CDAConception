using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorModeration
{
    public class ModeratorTelNumber : IDecoratorModerator
    {
        IModerator myModerator;

        public ModeratorTelNumber(IModerator myModerator)
        {
            this.myModerator = myModerator;
        }

        public void Moderate()
        {
            myModerator.Moderate();
            Console.WriteLine("Je modere les numéros de telephone");
        }
    }
}
