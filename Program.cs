sing System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace LongestWordExtracter
{
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
            char[] alphabet = "abcdefghijklmnopqrstuvwyz".ToCharArray();
            string[] words = text.Split(' ');
            string biggestWord = "";                       

            foreach (string word in words)
            {
                IEnumerable<char> letters = word.Where(letter => alphabet.Contains(char.ToLower(letter)));
                string currentWord = string.Join("", letters);
                biggestWord = biggestWord.Length < currentWord.Length ? currentWord : biggestWord;                
            }           
            return biggestWord;
        }
    }
}
