using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    public class Admin
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
                    AddUser();
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

        public void AddUser()
        {
            Console.WriteLine("Ange användarnamn: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ange lösenord: ");
            int password = int.Parse(Console.ReadLine());

            Security user = new Security(password, userName);
            Program.Användare.Add(user);
            Console.WriteLine("Användare skapad!");

            MetodAdminMeny();
        }

    }
}
