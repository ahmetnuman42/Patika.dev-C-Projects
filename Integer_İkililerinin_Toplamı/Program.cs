using System;
using System.Collections.Generic;

namespace Integer_İkililerinin_Toplamı
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Arada boşluklar bırakarak Sayi giriniz :");
            var dizi = Console.ReadLine().Split(' ');
            List<int> yenidizi = new();
            for(int i=1;i<dizi.Length;i=i+2)
            {
                if (dizi[i - 1] != dizi[i])
                {
                    int a=int.Parse(dizi[i]);
                    int b= int.Parse(dizi[i - 1]);
                    int temp = a+b;
                    yenidizi.Add(temp);
                }
                else
                {
                    int o = int.Parse(dizi[i]);
                    int sonuc = o * o * o * o;
                    yenidizi.Add(sonuc);
                }
            }
            foreach(var a in yenidizi)
            {
                Console.Write(a+" ");
            }
        }
    }
}
