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
            string danser1 = "";
            string danser2 = "";
            int point1 = 0;
            int point2 = 0;
            //int pointsamlet = 0;

            Console.WriteLine("Danser 1: ");
            danser1 = Console.ReadLine();
            Console.WriteLine("indtast point: ");
            point1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danser 2: ");
            danser2 = Console.ReadLine();
            Console.WriteLine("indtast point: ");
            point2 = Convert.ToInt32(Console.ReadLine());

            //pointsamlet = point1 + point2;
            var dans = new DansLogic();

            Console.WriteLine(dans.NamesTogether(danser1, danser2) + dans.Pointsadded(point1, point2));
                    //Console.WriteLine("{0} & {1} {2}", danser1, danser2, pointsamlet);

            Console.ReadKey();

        }
    }
}
