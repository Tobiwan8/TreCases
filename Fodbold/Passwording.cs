using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyLogicClassLibraryDotNetFramework;
using System.IO;

namespace Fodbold
{
    public class Passwording
    {
        public Passwording()
        {
            string brugernavn = "";
            string password = "";
            //bool pwcondition = true;
            string[] datafil = File.ReadAllLines(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", Encoding.Unicode);

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
                    brugernavn = brugernavn.ToLower();
                    Console.WriteLine("Vælg password: ");
                    password = Console.ReadLine();
                    //pwcondition = password.Contains();
                    string nyBruger = ($"{brugernavn} {password}");
                    File.AppendAllText(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", nyBruger + Environment.NewLine, Encoding.Unicode);

                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "l":

                    break;
            }

            Console.ReadKey();
        }
    }
}
