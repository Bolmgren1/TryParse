
class Program
{
    static void Main()
    {
        int resultat;
        if (!TryParse(Console.ReadLine(), out resultat))
            Console.WriteLine("Skriv in en siffra");

        static bool TryParse(string s, out int resultat)
        {
            try
            {
                resultat = int.Parse(s);
                return true;
            }

            catch
            {
                resultat = -1;
                return false;
            }
        }
    }
}