using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fodbold (F)");

            Console.WriteLine("Dans (D)");

            Console.WriteLine("Password (P)");

            Console.WriteLine("Vælg funktion: ");

            string tast = Convert.ToString(Console.ReadKey().KeyChar);

            Console.Clear();

            switch (tast)
            {
                case "f":
                    var football = new FootballView();
                    break;
                case "d":
                    string danser1 = "";
                    string danser2 = "";
                    int point1 = 0;
                    int point2 = 0;
                    int pointsamlet = 0;

                    Console.WriteLine("Danser 1: ");
                    danser1 = Console.ReadLine();
                    Console.WriteLine("indtast point: ");
                    point1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Danser 2: ");
                    danser2 = Console.ReadLine();
                    Console.WriteLine("indtast point: ");
                    point2 = Convert.ToInt32(Console.ReadLine());

                    pointsamlet = point1 + point2;

                    Console.WriteLine("{0} & {1} {2}", danser1, danser2, pointsamlet);

                    Console.ReadKey();
                    //var dans = new Dans();
                    break;

                case "p":
                    //var password = new Passwords();
                    break;

            }

            Console.ReadKey();
        }
    }
}
