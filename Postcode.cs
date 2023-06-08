
Console.WriteLine("Voer een postcode in:");
    string postcode = Console.ReadLine();

    postcode = postcode.Replace(" ", "").ToUpper();
        if (postcode.Length == 6)
        {
            bool firstFournumbers = true;
            for (int i = 0; i < 4; i++)
            {
                if (!Char.IsDigit(postcode[i]))
                {
                    firstFournumbers= false;
                    break;
                }
            }

            // Controleer of de laatste 2 tekens letters zijn
            bool lastTwoLetters = true;
            for (int i = 4; i < 6; i++)
            {
                if (!Char.IsLetter(postcode[i]))
                {
                    lastTwoLetters = false;
                    break;
                }
            }

            // Geef het resultaat weer
            if (firstFournumbers && lastTwoLetters)
            {
                Console.WriteLine("De postcode is correct.");
            }
            else
            {
                Console.WriteLine("De postcode is onjuist.");
            }
        }
        else
        {
            Console.WriteLine("De postcode is onjuist.");
        }