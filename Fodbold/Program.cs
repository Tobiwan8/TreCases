using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold
{
    class Program
    {
        static void Main(string[] args)
        {
            Jubel kamp = new Jubel()
            {
                mål = "",
                afleveringer = 0
            };
            string huh = "Huh! ";
            int i = 0;

            Console.WriteLine("Indtast afleveringer: ");
            kamp.afleveringer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast mål: ");
            kamp.mål =  Console.ReadLine();
            string mål = kamp.mål.ToLower();

            if (mål == "mål")
            {
                Console.WriteLine("Olé Olé Olé");
            }
            else
            {
                if (kamp.afleveringer < 1)
                {
                    Console.WriteLine("Shh");
                }
                else if (kamp.afleveringer >= 10)
                {
                    Console.WriteLine("High Five - Jubel!!!");
                }
                else
                {
                    do
                    {
                        Console.Write(huh);
                    }
                    while (i++ <= kamp.afleveringer);
                }
            }

            Console.ReadKey();
        }
    }
}
