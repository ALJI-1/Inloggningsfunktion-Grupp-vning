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
                var security = new Security(1234, "Admin");
                security.Login();
            }
            else if (input == 2)
            {
                var security = new Security(5678, "User");
                security.Login();
            }
            else
            {
                Console.WriteLine("Felaktigt val, försök igen");
            }
        }
    }
}
