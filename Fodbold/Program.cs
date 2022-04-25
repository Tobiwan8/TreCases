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
                    var dans = new Dans();
                    break;

                case "p":
                    //var password = new Passwords();
                    break;

            }

            Console.ReadKey();
        }
    }
}
