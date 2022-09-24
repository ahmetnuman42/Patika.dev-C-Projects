using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama.Geometri
{
    class Ucgen : IGenericHesaplar
    {
        public void Hesapla()
        {
            bas:
            Console.WriteLine("Üçgenin neyini hesaplamak istiyorsunuz : Alan(1) Çevre(2)");
            string secilen = Console.ReadLine().Trim();
            switch (secilen)
            {
                case "1":
                    AlanHesapla();
                    break;
                case "2":
                    CevreHesapla();
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir seçim yapınız!");
                    goto bas;
            }
        }
        public void AlanHesapla()
        {
            Console.WriteLine("yüksekliği giriniz :");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Taban uzunluğunu giriniz");
            int taban = Convert.ToInt32(Console.ReadLine());
            int sonuc = (yukseklik*taban)/2;
            Console.WriteLine("Üçgenin alanı :{0}", sonuc);
        }

        public void CevreHesapla()
        {
            Console.WriteLine("Birinci kenarı giriniz :");
            int kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci kenarı giriniz :");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçüncü kenarı giriniz :");
            int kenar3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üçgenin Çevresi : {0}",kenar1+kenar2+kenar3);
        }

       
    }
}
