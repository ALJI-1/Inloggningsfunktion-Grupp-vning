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
        public void MetodAnvändareMeny(Security security)
        {
            Console.WriteLine("Välkommen Användare!");
            Console.WriteLine("1. Visa lösenord");
            Console.WriteLine("6. Avsluta programmet");
            Console.Write("Välj ett alternativ: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine($"Ditt lösenord är: {security.Password}");
                    break;
                case "6":
                    Console.WriteLine("Avsluta programmet");
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
            }
        }
        //Avsulata och Vissa löserord.
    


    }
}
