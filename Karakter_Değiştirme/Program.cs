using System;

namespace Karakter_Değiştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            var metin = Console.ReadLine().Split(' ');

            foreach (var i in metin)
            {
                int boyut = i.Length;
                string ters = i;
                string basharf = ters[0].ToString();
                string sonharf = ters[i.Length - 1].ToString();
                ters = ters.Remove(0, 1);
                ters = ters.Remove(boyut-2,1);
                ters = sonharf+ters + basharf;
                Console.Write(ters + " ");
            }

        }
    }
}
