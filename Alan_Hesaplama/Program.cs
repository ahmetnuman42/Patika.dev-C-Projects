using Alan_Hesaplama.Geometri;
using System;

namespace Alan_Hesaplama
{
    class Program
    {
        public static void Main()
        {
            bas:
            Console.WriteLine("İşlem yapmak istediğiniz Geometrik Şekli Seçiniz");
            Console.WriteLine("* Kare(1) * Üçgen(2) * Daire(3)");
            string giris = Console.ReadLine().Trim();            
                switch (giris)
                {
                case "1":
                    Kare kare = new Kare();
                    kare.Hesapla();
                    break;
                case "2":
                    Ucgen ucgen = new Ucgen();
                    ucgen.Hesapla();
                    break;
                case "3":
                    Daire daire = new Daire();
                    daire.Hesapla();
                    break;
                default:
                    Console.WriteLine("Lütfen geçerli bir giriş yapınız!");
                    goto bas;                        
                }
            
        }
    }
}
