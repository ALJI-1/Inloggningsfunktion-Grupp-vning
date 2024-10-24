using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inloggningsfunktion_Gruppövning
{
    public class Security
    {
        
        public int Password { get; set; }
        public string AnvändarNamn { get; set; }

        public Security(int password, string användarNamn)
        {
            Password = password;
            AnvändarNamn = användarNamn;
        }

        public void Login()
        {
            Console.WriteLine("Ange lösenord: ");
            Password = int.Parse(Console.ReadLine());
            if (Password == 1234)
            {
                Console.WriteLine("Välkommen Admin!");
                Admin admin = new Admin();
                admin.MetodAdminMeny();
            }
            else if (Password == 5678)
            {
                Console.WriteLine("Välkommen Användare!");
                Användare användare = new Användare();
                användare.MetodAnvändareMeny();
            }
            else
            {
                Console.WriteLine("Felaktigt lösenord, försök igen");
                Login();
            }
        }
    }
}
