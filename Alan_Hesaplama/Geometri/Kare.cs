using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama.Geometri
{
    class Kare : IGenericHesaplar
    {
        public void Hesapla()
        {
            bas:
            Console.WriteLine("Karenin neyini hesaplamak istiyorsunuz : Alan(1) Çevre(2)");
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
            Console.WriteLine("Bir kenar uzunluğu giriniz :");
            int kenar = Convert.ToInt32(Console.ReadLine());
            int sonuc = kenar * kenar;
            Console.WriteLine("Karenin alanı :{0}",sonuc);           
        }

        public void CevreHesapla()
        {
            Console.WriteLine("Bir kenar uzunluğu giriniz :");
            int kenar = Convert.ToInt32(Console.ReadLine());
            int sonuc = kenar * 4;
            Console.WriteLine("Karenin Çevresi :{0}", sonuc);
        }

       
    }
}
