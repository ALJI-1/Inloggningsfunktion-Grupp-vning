using System.Security.Cryptography.X509Certificates;

namespace Inloggningsfunktion_Gruppövning
{
    internal class Program
    {
        public static List<Security> Användare = new List<Security>();
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ange 1 för Admin. Eller 2 för Användare.");
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                
            }
            if (input == 2)
            {

            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen");
            }
        }
    }
}
