using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Inloggningsfunktion_Gruppövning
{
    public class Program
    {
        public static List<Security> users = new List<Security>();

        static void Main(string[] args)
        {
            Security användare1 = new Security(1234, "Admin", true);
            Security användare2 = new Security(5678, "Användare", false);

            Program.users.Add(användare1);
            Program.users.Add(användare2);

            Security loginHandler = new Security();
            loginHandler.Login();
        }
    }
}
