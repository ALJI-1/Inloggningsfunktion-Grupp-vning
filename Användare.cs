using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    public class Användare  // En class för både admin och användare
    {
        public void MetodAnvändareMeny() // Meny för användare
        {
            Security användare = new Security();
            Console.Clear();
            Console.WriteLine("Välkommen Användare!");
            TimeOut(TimeSpan.FromSeconds(5));  // Används för att avsluta programmet efter en viss tid
            Console.WriteLine("1. Visa lösenord");
            Console.WriteLine("2. Gå tillbaka till login");
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
                case "2":
                    Console.Clear();
                    användare.Login();
                    break;
                case "6":
                    ExitProgram(ref användare);
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
            }
        }

        public void ExitProgram(ref Security användare)
        {
            
            Console.WriteLine("Programmet avslutas...");
            Environment.Exit(0);
        }

        public void MetodAdminMeny() // Meny för admin
        {
            Security användare = new Security();
            Console.Clear();
            Console.WriteLine("Välkommen Admin!");
            TimeOut(TimeSpan.FromSeconds(10));  // Används för att avsluta programmet efter en viss tid
            Console.WriteLine("1. Skapa användare");
            Console.WriteLine("2. Inställningar");
            Console.WriteLine("3. Gå tillbaka till login");
            Console.WriteLine("4. Skriv ut användarelista");
            Console.WriteLine("6. Avsluta programmet");
            Console.Write("Välj ett alternativ: ");
            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddUser();
                    break;
                case "2":
                    Settings();
                    break;
                case "3":
                    Console.Clear();
                    användare.Login();
                    break;
                case "4":
                    Console.Clear();
                    foreach (Security security in Program.users)
                    {
                        Console.WriteLine($"Lösenord: {security.Password}\nAnvändarnamn: {security.AnvändarNamn}\nAdmin: {security.IsAdmin}\n============");
                    }
                    Console.WriteLine("Tryck på Enter för att återgå till menyn.");
                    Console.ReadLine();
                    MetodAdminMeny();
                    break;
                case "6":
                    Console.WriteLine("Avsluta programmet");
                    ExitProgram(ref användare);
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
            }
        }

        public void AddUser()
        {
            Console.WriteLine("Ange användarnamn: ");
            string? userName = Console.ReadLine();
            Console.WriteLine("Ange lösenord (siffror): ");
            string? password = Console.ReadLine();
            Console.WriteLine("1. Admin\n2. Användare");  // Ange ifall ny användare är Admin eller inte.
            int isAdminOrNot = int.Parse(Console.ReadLine());

            Security user = new Security();

            if (isAdminOrNot == 1)   // Om ny användare är Admin
            {
                user.IsAdmin = true;
                if (int.TryParse(password, out int passwordSafe))
                {
                    user.Password = passwordSafe;
                    user.AnvändarNamn = userName!;
                    Security newUser = new Security(passwordSafe, userName!, user.IsAdmin);
                    Program.users.Add(newUser);

                    Console.WriteLine("Admin skapad!");
                    MetodAdminMeny();
                }
                else
                {
                    Console.WriteLine("Felaktigt lösenord, försök igen");
                    AddUser();
                }
            }
            else
            {
                user.IsAdmin = false;  // Om ny användare inte är Admin
                if (int.TryParse(password, out int passwordSafe))
                {
                    user.Password = passwordSafe;
                    user.AnvändarNamn = userName!;
                    Security newUser = new Security(passwordSafe, userName!, user.IsAdmin);
                    Program.users.Add(newUser);

                    Console.WriteLine("Användare skapad!");
                    MetodAdminMeny();
                }
                else
                {
                    Console.WriteLine("Felaktigt lösenord, försök igen");
                    AddUser();
                }
            }
        }

        public void Settings()
        {
            Console.WriteLine("Inställningar\n1. Byt till slumpmässig färg på texten\n2. Ändra konsolfönstrets titel");
            int choice = int.Parse(Console.ReadLine()!);
            if (choice == 1)
            {
                ChangeFontRGB();
            }
            if (choice == 2)
            {
                Console.WriteLine("Ändra titel för programmet.\nTitel?");
                string? titel = Console.ReadLine();
                Console.Title = titel!;
                Console.WriteLine($"Ny titel: {titel}");
            }
        }
        public static void ChangeFontRGB()
        {
            Random random = new Random();

            // Array med tillgängliga konsolfärger (16st)
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            // Välj en slumpmässig färg från konsolfärgerna
            ConsoleColor randomColor = colors[random.Next(colors.Length)];

            // Sätter consolens font-färg till den slumpmässiga färgen
            Console.ForegroundColor = randomColor;
            Console.WriteLine($"Färgen ändrad till: {randomColor}. Tryck enter.");
            Console.ReadLine();
        }

        public static void TimeOut(TimeSpan timeoutTid)  // Metod för att avsluta programmet efter en viss tid
        {
            Task.Run(() =>  // Starta en ny "Task" för att räkna ner tiden
            {
                DateTime slutTid = DateTime.Now + timeoutTid; // Räkna ut när tiden är ute baserat på nuvarande tid och timeout-tiden

                while (DateTime.Now < slutTid) // Loopar tills tiden är ute
                {
                    Thread.Sleep(1000);
                }

                Console.WriteLine("\nTiden är ute! Programmet avslutas.");
                Environment.Exit(0);
            });
        }
    }
}
