using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecoratorModeration
{
    class ProgramTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moderateur simple");
            IModerator moderator = new Moderator();
            moderator.Moderate();
           
            Console.WriteLine("\nAjout de la modération d'emails");
            moderator = new ModeratorEMail(moderator);
            moderator.Moderate();

            Console.WriteLine("\nAjout des autres modérations");
            moderator = new ModeratorTelNumber(new ModeratorAdultContent(moderator));
            moderator.Moderate();

            Console.WriteLine("\nSuper moderateur");


            IModerator superModerator = new ModeratorAdultContent(new ModeratorEMail(new ModeratorTelNumber(new Moderator())));

            superModerator.Moderate();

            Console.ReadKey();
        }
    }
}
