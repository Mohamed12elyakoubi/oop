class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Voer een woord in:");
        string woord = Console.ReadLine();

        if (IsPalindroom(woord))
        {
            Console.WriteLine("Het woord is een palindroom.");
        }
        else
        {
            Console.WriteLine("Het woord is geen palindroom.");
        }
    }

    static bool IsPalindroom(string woord)
    {
        int lengte = woord.Length;

        for (int i = 0; i < lengte / 2; i++)
        {
            if (woord[i] != woord[lengte - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}

