using System;
using System.Collections.Generic;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime ve kaçıncı karakterini çıkartmak istiyorsanız indexini yazınız. ===>>> (kelime,index): ");
                var entry = Console.ReadLine().Split(',');           
                string name = entry[0];
                int index = Convert.ToInt32(entry[1]);   
                name=name.Remove(index-1,1);
                Console.WriteLine(name);
            }
        }
    }
}
