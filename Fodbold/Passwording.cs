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
            string brugernavn = "";
            string password = "";

            Console.WriteLine("Vælg funktion");
            Console.WriteLine("(O) Opret bruger");
            Console.WriteLine("(L) Login");
            
            string tast = Convert.ToString(Console.ReadKey().KeyChar);
            Console.Clear();

            switch (tast)
            {
                case "o":
                    Console.WriteLine("Vælg brugernavn: ");
                    brugernavn = Console.ReadLine();
                    Console.WriteLine("Password skal indeholde minimum 12 karakterer. Der skal varieres mellem store og små bogstaver, indeholde tal (ikke først eller sidst) og specialtegn.");
                    Console.WriteLine("Vælg password: ");
                    password = Console.ReadLine();
                    break;
                case "l":

                    break;
            }

            Console.ReadKey();
        }
    }
}
