using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLogicClassLibraryDotNetFramework;
using System.IO;

namespace Fodbold
{
    public class ReadWriteToFileView
    {
        public ReadWriteToFileView()
        {
            string brugernavn;
            string password;
            string[] datafil = File.ReadAllLines(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", Encoding.Unicode);
            PasswordLogic passlog = new PasswordLogic();
            string nyBruger;
            string fundet = "";

            Console.WriteLine("Vælg funktion");
            Console.WriteLine("(O) Opret bruger");
            Console.WriteLine("(L) Login med nyt password");
            
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
                    nyBruger = ($"{brugernavn} /// {password}");


                    if (!passlog.pwconditions(password, 12))
                    {
                        Console.WriteLine("Ugyldigt password");
                        Console.ReadKey();
                    }
                    else
                    {
                        File.AppendAllText(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", nyBruger + Environment.NewLine, Encoding.Unicode);
                        datafil = File.ReadAllLines(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", Encoding.Unicode);
                        Console.WriteLine("bruger oprettet");
                        Console.ReadKey();
                    }


                    Console.ReadKey();
                    break;

                case "l":
                    Console.WriteLine("brugernavn: ");
                    brugernavn = Console.ReadLine();
                    brugernavn = brugernavn.ToLower();


                    foreach (var item in datafil)
                    {
                        if (!item.Contains(brugernavn))
                        {
                            Console.WriteLine("bruger ikke fundet");
                            Console.ReadKey();
                            fundet = "fundet";
                        }
                        if (fundet != "fundet")
                        {
                            Console.WriteLine("indtast nyt password: ");
                            password = Console.ReadLine();
                            nyBruger = ($"{brugernavn} /// {password}");


                            if (item.Contains(password))
                            {
                                Console.WriteLine("password allerede i brug");
                                Console.ReadKey();
                            }
                            else
                            {
                                if (!passlog.pwconditions(password, 12))
                                {
                                    Console.WriteLine("Ugyldigt password");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    File.AppendAllText(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", nyBruger + Environment.NewLine, Encoding.Unicode);
                                    datafil = File.ReadAllLines(@"C:\Skole\cases-i-csharp\treCases\fodbold\trecases\Password\datafil.txt", Encoding.Unicode);
                                    Console.WriteLine("bruger oprettet");
                                    Console.ReadKey();
                                }

                            }
                        }
                    }
                    break;
            }
        }
    }
}
