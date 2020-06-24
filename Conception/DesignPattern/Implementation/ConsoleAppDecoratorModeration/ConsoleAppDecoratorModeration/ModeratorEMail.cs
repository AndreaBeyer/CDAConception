using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorModeration
{
    public class ModeratorEMail : IDecoratorModerator
    {
        IModerator myModerator;

        public ModeratorEMail(IModerator myModerator)
        {
            this.myModerator = myModerator;
        }

        public void Moderate()
        {
            myModerator.Moderate();
            Console.WriteLine("Je modere les emails");
        }
    }
}
