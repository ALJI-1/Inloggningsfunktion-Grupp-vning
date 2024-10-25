using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    public class Användare
    {
        Security användare = new Security();
        public void MetodAnvändareMeny()
        {
            Console.WriteLine("Välkommen Användare!");
            Console.WriteLine("1. Visa lösenord");
            Console.WriteLine("6. Avsluta programmet");
            Console.Write("Välj ett alternativ: ");
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Felaktigt val, försök igen");
                return;
            }
            switch (input)
            {
                case "1":
                    användare.ShowPassword();
                    break;
                case "6":
                    ExitProgram(ref användare);
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
            }
        }

        private void ExitProgram(ref Security användare)
        {
            
            Console.WriteLine("Programmet avslutas...");
            Environment.Exit(0);
        }
    }
}
