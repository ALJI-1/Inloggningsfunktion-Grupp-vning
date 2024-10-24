using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    internal class Admin
    {
        public void MetodAdminMeny()
        {
            Console.WriteLine("Välkommen Admin!");
            Console.WriteLine("1. Skapa användare");
            Console.WriteLine("2. Inställningar");
            Console.WriteLine("6. Avsluta programmet");
            Console.Write("Välj ett alternativ: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Skapa användare");
                    break;
                case "2":
                    Console.WriteLine("Inställningar");
                    break;
                case "6":
                    Console.WriteLine("Avsluta programmet");
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
            }
        }

    }
    }
}
