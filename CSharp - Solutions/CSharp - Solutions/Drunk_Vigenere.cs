using System;
using System.Linq;

namespace CSharp___Solutions
{
    class Drunk_Vigenere
    {
        static void Old_Main(string[] args)
        {
            char[] messagge = Console.ReadLine().ToCharArray();
            char[] key = Console.ReadLine().ToCharArray();

            char[] decoded_message_even = messagge.Zip(key, (m, k) => (char)(65+((26 + (int)m - (int)k) % 26))).ToArray();
            char[] decoded_message_odd = messagge.Zip(key, (m, k) => (char)(65 + (((int)m + (int)k) % 26))).ToArray();

            messagge.Select(item => (int)item).ToArray();
            key.Select(item => (int)item).ToArray();

            string decoded_message_result =
                messagge
                    .Select((crke, index) => index % 2 == 0 ? decoded_message_even[index] : decoded_message_odd[index])
                    .Select(crka => crka.ToString())
                    .Aggregate((partialPhrase, word) => partialPhrase.ToString() + word.ToString());

            Console.WriteLine(String.Format("{0}", decoded_message_result));
        }

    }
}
