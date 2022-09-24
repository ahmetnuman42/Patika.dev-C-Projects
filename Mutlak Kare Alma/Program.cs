using System;
using System.Collections.Generic;

namespace Mutlak_Kare_Alma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arada boşluklar bırakarak sayi giriniz :");
            var dizi = Console.ReadLine().Split(' ');
            List<int> buyukolanlardizisi = new();
            List<int> kucukolanlardizisi = new();
            for (int i = 0; i <dizi.Length; i++)
            {
                int a = int.Parse(dizi[i]);
                if (a<67)
                {
                    int temp =67-a;
                    kucukolanlardizisi.Add(temp);
                }
                else if(a>67)
                {
                    int o = (a - 67)* (a - 67);                    
                    buyukolanlardizisi.Add(o);
                }
            }
            int toplamkucuk = 0;
            foreach (var a in kucukolanlardizisi)
            {
                toplamkucuk = toplamkucuk + a;
                
            }Console.Write(toplamkucuk + " ");
            int toplambuyuk = 0;
            foreach (var a in buyukolanlardizisi)
            {
                toplambuyuk = toplambuyuk + a;
                
            }Console.Write(toplambuyuk + " ");
        }
    }
}
