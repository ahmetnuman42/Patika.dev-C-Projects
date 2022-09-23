using System;

namespace Ucgen_Cizme
{
    class Program
    {
        static void Main()
        {  
            Console.WriteLine("Üçgenin boyutunu giriniz.");
             int boyut = Convert.ToInt32(Console.ReadLine());
            Cisim.UcgenCiz(boyut);           
        }
    }
    class Cisim
    {
        public static void UcgenCiz(int boyut)
        {
            for (int i = 1; i < boyut + 1; i++)
            {
                for (int j = i; j < boyut + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
