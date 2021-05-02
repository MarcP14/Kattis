using System;

namespace CSharp___Solutions
{
    class Hangman
    {
        static void Old_Main (string[] args)
        {
            string word = Console.ReadLine();
            string char_order = Console.ReadLine();

            int napacni_poskusi = 0;
            int indeks = 0;

            while(word != "" && napacni_poskusi<10)
            {
                int dolzina = word.Length;
                word = word.Replace(char_order[indeks].ToString(), "");
                if (dolzina == word.Length)
                    napacni_poskusi += 1;
                indeks += 1;
            }

            if (word == "")
                Console.WriteLine("WIN");
            else
                Console.WriteLine("LOSE");
        }

    }


}
