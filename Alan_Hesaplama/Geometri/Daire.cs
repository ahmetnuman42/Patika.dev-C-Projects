using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama.Geometri
{
    class Daire : IGenericHesaplar
    {
        public void Hesapla()
        {
            bas:
            Console.WriteLine("Dairenin neyini hesaplamak istiyorsunuz : Alan(1) Çevre(2)");
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
            Console.WriteLine("Yarıçapı giriniz :");
            double yaricap = Convert.ToDouble(Console.ReadLine());            
            double sonuc = Math.PI*yaricap*yaricap;
            Console.WriteLine("Dairenin alanı :{0}",sonuc);
        }

        public void CevreHesapla()
        {
            Console.WriteLine("Yarıçapı giriniz :");
            double yaricap = Convert.ToDouble(Console.ReadLine());
            double sonuc = Math.PI * yaricap *2;
            Console.WriteLine("Dairenin Çevresi :{0}", sonuc);
        }

        
    }
}
