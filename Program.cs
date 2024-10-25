using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Inloggningsfunktion_Gruppövning
{
    public class Program
    {
        public static List<Security> users = new List<Security>();


        static void Main(string[] args)
        {
            bool onOff = true;
            do
            {
                Security användare = new Security();
                Security användare1 = new Security(1234, "Admin");
                Security användare2 = new Security(5678, "Användare");

                users.Add(användare);
                users.Add(användare1);
                users.Add(användare2);

                användare.Login();

            } while (onOff == true);



        }
        
    }
}
