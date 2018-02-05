class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the text from which you want to get the longest word:");
            string input = Console.ReadLine();
            Console.WriteLine(LongestWord(input));
            Console.ReadLine();
            Console.WriteLine("Bye!");
        }

        static string LongestWord(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwyz";
            string[] words = text.Split(' ');
            string biggestWord = "";

            for (int index = 0; index < words.Length; index++)
            {
                string word = words[index];
                for (int i = 0; i < word.Length; i++)
                {
                    if (!alphabet.Contains("" + char.ToLower(word[i])))
                    {
                        word = word.Remove(i);
                    }
                }
                biggestWord = biggestWord.Length < word.Length ? word : biggestWord;
            }
            return biggestWord;
        }
    }
