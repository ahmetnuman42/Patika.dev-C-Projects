using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derinlik giriniz");
            int girilen = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int[] fibo = new int[girilen];
            fibo[0] = 1;
            fibo[1] = 1;
            for(int i = 2; i < girilen; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                toplam = toplam + fibo[i];
            }
            toplam = toplam + 2;
            Console.WriteLine("Girdiğiniz derinliğe kadar olan sayıların ortalaması :"+toplam/girilen);
        }
    }
}
