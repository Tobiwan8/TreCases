using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogicClassLibraryDotNetFramework;

namespace Fodbold
{
    internal class FootballView
    {
        public FootballView()
        {
            int result = 0;
            string goal = string.Empty;
            bool succes = true;

            do
            {
                Console.WriteLine("Indtast afleveringer: ");
                succes = int.TryParse(Console.ReadLine(), out result);

                Console.WriteLine("Skriv mål, hvis mål: ");
                goal = Console.ReadLine();

                if (!succes) Console.WriteLine("Ikke gyldig værdi, prøv igen...");

            } while (!succes);

            var football = new Football();
            Football.HowMuchDoWeCheer

            Console.WriteLine();

        }
    }
}
