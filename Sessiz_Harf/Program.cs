using System;
using System.Collections.Generic;

namespace Sessiz_Harf
{
    class Program
    {
        static void Main()
        {
            var metin = Console.ReadLine().Split(' ');
            string sesliharfler = "aeıioöuü";
            int trusayac = 0;
            List<bool> sonuc = new();
            //int falssayac = 0;
            for(int i = 0; i < metin.Length; i++)
            {
                string kelime = metin[i].Trim();
                for(int j = 0; j <kelime.Length; j++) 
                {                     
                      if(sesliharfler.Contains(kelime[j]))
                        {
                            trusayac = 0;
                        }
                        else
                        {
                            trusayac++;
                            if (trusayac == 2)
                            {                               
                                sonuc.Add(true);
                                break;
                            }
                        }                    
                }                    
            }
            foreach (var item in sonuc)
            {
                Console.Write(item + " ");
            }
        }
    }
}
