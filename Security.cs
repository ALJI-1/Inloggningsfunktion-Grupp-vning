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
        public Security(int password, string användarNamn)
        {
            Password = password;
            AnvändarNamn = användarNamn;
        }

        public void Login()
        {
            Security security = new Security();

            while (true)
            {
                Console.WriteLine("Ange lösenord: ");
                Password = int.Parse(Console.ReadLine());
                foreach (var users in Program.users)
                {
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
                    else if (Password == users.Password)
                    {
                        Console.WriteLine("Programmet avslutas");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Felaktigt lösenord, försök igen");

                    }
                }
                   
            }
            
        }
        public void LogOutAdmin(DateTime dateTime)
        {
            if ((DateTime.Now - dateTime).TotalSeconds >= 1)
            {
                Console.WriteLine("Du har loggats ut");
                Console.ReadKey();
                this.Login();
            }       
        }
        public void LogOutUser(DateTime dateTime)
        {
            if ((DateTime.Now - dateTime).TotalSeconds >= 1)
            {
                Console.WriteLine("Du har loggats ut");
                Console.ReadKey();
                Login();
            }
        }
        public void ShowPassword()
        {
            Console.WriteLine($"Ditt lösenord är: {Password}");
        }
       
    }
}
