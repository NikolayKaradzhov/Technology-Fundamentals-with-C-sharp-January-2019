using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                word = word.Replace(wordToRemove, "");
            }
            Console.WriteLine(word);
        }
    }
}
