
    static void Main(string[] args)
    {
        string[] words = { "LINGO", "ZWERK", "VEGER", "GROEN", "GOEDE" };
        bool allWordsGuessed = true;

        foreach (string word in words)
        {
            Console.WriteLine("Raad het woord van 5 letters:");
            string guess = Console.ReadLine().ToUpper();

            if (guess.Length != 5)
            {
                Console.WriteLine("Ongeldige invoer. Het woord moet 5 letters bevatten.");
                continue;
            }

            Console.WriteLine("Resultaat:");
            for (int i = 0; i < 5; i++)
            {
                ConsoleColor color = word[i] == guess[i] ? ConsoleColor.Green : (word.Contains(guess[i]) ? ConsoleColor.Red : ConsoleColor.White);
                Console.ForegroundColor = color;
                Console.Write(word[i] == guess[i] ? guess[i] : ".");
            }
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine();

            if (word != guess)
            {
                allWordsGuessed = false;
            }
        }

        if (allWordsGuessed)
        {
            Console.WriteLine("Alle woorden geraden!");
        }
        else
        {
            Console.WriteLine("Niet alle woorden correct geraden.");
        }
    }
