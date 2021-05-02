using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp___Solutions
{
    class Karte
    {
        static void Old_Main (string[] args)
        {
            string card_labels = Console.ReadLine();
            string tren_card_label;

            List<string> imamo = new List<string>();
             
            int P_nimamo = 13;
            int K_nimamo = 13;
            int H_nimamo = 13;
            int T_nimamo = 13;

            while (card_labels.Length>=3)
            {
                tren_card_label = card_labels.Substring(0,3);

                if (imamo.Contains(tren_card_label))
                {
                    Console.WriteLine("GRESKA");
                    break;
                }
                else
                {
                    imamo.Add(tren_card_label);
                }
                
                switch (tren_card_label[0])
                {
                    case 'P':
                        P_nimamo -= 1;
                        break;
                    case 'K':
                        K_nimamo -= 1;
                        break;
                    case 'H':
                        H_nimamo -= 1;
                        break;
                    case 'T':
                        T_nimamo -= 1;
                        break;
                }

                card_labels = card_labels.Substring(3);
            }

            if(card_labels.Length == 0)
            {
                Console.WriteLine(P_nimamo + " " + K_nimamo + " " + H_nimamo + " " + T_nimamo );
            }
        }

    }


}
