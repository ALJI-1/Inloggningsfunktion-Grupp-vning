﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
                    Console.WriteLine("Skapa användare");
                    break;
                case "2":
                    Console.WriteLine("Inställningar\n1. Byt till slumpmässig färg på texten\n2.  Ändra konsolfönstrets titel");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        ChangeFontRGB();
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Ändra titel för programmet.\nTitel?");
                        String? titel = Console.ReadLine();
                        Console.Title = titel;
                        Console.WriteLine($"Ny titel: {titel}");
                    }
                    break;

                case "6":
                    Console.WriteLine("Avsluta programmet");
                    break;
                default:
                    Console.WriteLine("Felaktigt val, försök igen");
                    break;
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

    }
}
