using System;

namespace Karakter_Tersten_Yazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            var metin=Console.ReadLine().Split(' ');

            foreach(var i in metin)
            {
                string ters = i;
                string basharf = ters[0].ToString();
                ters = ters.Remove(0, 1);
                ters = ters+basharf;
                Console.Write(ters+" ");
            }
        }
    }
}
