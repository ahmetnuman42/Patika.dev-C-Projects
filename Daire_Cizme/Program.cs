using System;
using System.Diagnostics;

namespace Daire_Cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yarıçap giriniz");
			int boyut=Convert.ToInt32(Console.ReadLine());
			Daire_Çiz(boyut);
        }		

			public static void Daire_Çiz(int boyut)
			{
            for (int i = 1; i < (boyut*2)+1; i++)
            {
                for (int j = i; j < (boyut*2) + 1; j++)
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
            for (int i = 1; i < (boyut * 2)+1; i++)
            {
               
                for (int k = i; k >= 1; k--)
                {                    
                    Console.Write(" ");
                } 
                for (int j = i; j < (boyut * 2)+1; j++)
                {                   
                    Console.Write("*");           
                     Console.Write(" ");
                }
                Console.WriteLine();
            }

            }
		}
}
