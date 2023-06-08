using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("voer een zin in doe snel:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string[] translatedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];

            if (word.StartsWith("a") || word.StartsWith("e") || word.StartsWith("i") || word.StartsWith("o") || word.StartsWith("u"))
            {
                word += "ibus";
            }
            else if (word.EndsWith("a") || word.EndsWith("i") || word.EndsWith("u"))
            {
                word += "nt";
            }
            else
            {
                string temp = word;
                int index = 0;
                while (index < temp.Length && !IsVowel(temp[index]))
                {
                    index++;
                }
                if (index < temp.Length)
                {
                    word = temp.Substring(index) + "itum";
                }
            }

            word = word.Replace("j", "i").Replace("y", "").Replace("z", "");

            translatedWords[i] = word;
        }

        string translatedSentence = string.Join(" ", translatedWords);
        Console.WriteLine(translatedSentence);
    }

    static bool IsVowel(char c)
    {
        return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
    }
}

