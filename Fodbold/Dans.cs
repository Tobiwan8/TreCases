using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogicClassLibraryDotNetFramework;

namespace Fodbold
{
    public class Dans
    {
        public Dans ()
        {
            string navn1 = "";
            int point1 = 0;
            string navn2 = "";
            int point2 = 0;

            Console.WriteLine("Danser 1: ");
            navn1 = Console.ReadLine();
            Console.WriteLine("indtast point: ");
            point1 = Convert.ToInt32(Console.ReadLine());
            DanceLogic danser1 = new DanceLogic(navn1, point1);
            Console.WriteLine("Danser 2: ");
            navn2 = Console.ReadLine();
            Console.WriteLine("indtast point: ");
            point2 = Convert.ToInt32(Console.ReadLine());
            var danser2 = new DanceLogic(navn2, point2);

            DanceLogic object3 = danser1 + danser2;

            Console.WriteLine(object3.Navn + object3.Point);                  

            Console.ReadKey();
        }
    }
}
