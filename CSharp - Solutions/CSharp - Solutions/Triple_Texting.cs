using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Triple_Texting

    {
        static void Old_Main(string[] args)
        {
            string word = Console.ReadLine();
            int word_len = word.Length / 3;

            if (word.Substring(0, word_len) == word.Substring(word_len, word_len))
                Console.WriteLine(word.Substring(0, word_len));
            else if (word.Substring(word_len, word_len) == word.Substring(word_len * 2 , word_len))
                Console.WriteLine(word.Substring(word_len, word_len));
            else
                Console.WriteLine(word.Substring(0, word_len));
        }

    }
}
