using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold
{
    public class Passwording
    {
        public Passwording()
        {

            Console.WriteLine("Vælg funktion");
            Console.WriteLine("(O) Opret bruger");
            Console.WriteLine("(L) Login");
            
            string tast = Convert.ToString(Console.ReadKey().KeyChar);

            switch (tast)
            {
                case "o":

                    break;
                case "l":

                    break;
            }

            Console.ReadKey();
        }
    }
}
