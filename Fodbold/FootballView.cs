using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogicClassLibraryDotNetFramework;

namespace Fodbold
{
    public class FootballView
    {
        public FootballView()
        {
            int result = 0;
            string goal = "";
            bool succes = true;
            int passes = 0;

            do
            {
                Console.WriteLine("Indtast afleveringer: ");
                succes = int.TryParse(Console.ReadLine(), out result);


                Console.WriteLine("Skriv mål, hvis mål: ");
                goal = Console.ReadLine();
                goal = goal.ToLower();

                if (!succes) Console.WriteLine("Ikke gyldig værdi, prøv igen...");

            } while (!succes);

            var football = new Football();

            if (goal == "mål")
            {
                Console.WriteLine(football.WeCelebrateIfGoal(goal));
            }
            else
            {
                Console.WriteLine(football.HowMuchDoWeCheer(passes));
            }
            
            Console.ReadKey();
        }
    }
}
