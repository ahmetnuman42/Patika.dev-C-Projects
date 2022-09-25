using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiting_App.Voiting
{
    class Voiting
    {
        public static int Film;
        public static int Oyun;
        public static int Muzik;
        public static int Eglence;
        public static void Oylama()
        {
            tekrar:
            Console.WriteLine("Aşagıdaki Kategorilerden birini tercih ediniz:");
            Console.WriteLine("--> Film    (1)");
            Console.WriteLine("--> Oyun    (2)");
            Console.WriteLine("--> Müzik   (3)");
            Console.WriteLine("--> Eğlence (4)");
            string secim = Console.ReadLine().Trim();
            switch (secim)
            {
                case "1":
                    Film++;
                    break;
                case "2":
                    Oyun++;
                    break;
                case "3":
                    Muzik++;
                    break;
                case "4":
                    Eglence++;
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli seçim yapınız:");
                    goto tekrar;                   
            }
            Listeleme();
        }
        public static void Listeleme()
        {
            Console.WriteLine("Oylama Sonuçları");
            Console.WriteLine("--> Film    {0}",Film);
            Console.WriteLine("--> Oyun    {0}",Oyun);
            Console.WriteLine("--> Müzik   {0}",Muzik);
            Console.WriteLine("--> Eğlence {0}",Eglence);

            Console.WriteLine("**TEŞEKKÜRLER**");
        }
    }
}
