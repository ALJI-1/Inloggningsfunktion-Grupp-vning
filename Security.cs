using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    public class Security
    {
        

        public int Password { get; set; }
        public string AnvändarNamn { get; set; }
        public bool IsAdmin { get; set; }


        public Security()
        {
        }   
        public Security(int password, string användarNamn, bool isAdmin)
        {
            Password = password;
            AnvändarNamn = användarNamn;
            IsAdmin = isAdmin;
        }

        public void Login()
        {
            while (true)
            {
                Console.WriteLine("Ange lösenord: ");
                int inputPassword = int.Parse(Console.ReadLine());

                // Hitta användare baserat på lösenord
                Security currentUser = Program.users.FirstOrDefault(u => u.Password == inputPassword);

                if (currentUser != null)
                {
                    // Kontrollera om användaren är admin
                    if (currentUser.IsAdmin)
                    {
                        Användare användare = new Användare();
                        användare.MetodAdminMeny();
                    }
                    else
                    {
                        Användare användare = new Användare();
                        användare.MetodAnvändareMeny();
                    }
                    break;  // Avsluta loopen efter lyckad inloggning
                }
                else
                {
                    Console.WriteLine("Felaktigt lösenord, försök igen.");
                }
            }
        }


        public void ShowPassword()
        {
            Console.WriteLine($"Ditt lösenord är: {Password}");
        }
    }
}
