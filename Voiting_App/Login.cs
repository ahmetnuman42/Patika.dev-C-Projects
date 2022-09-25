using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voiting_App.Data;
using Voiting_App.Objects;

namespace Voiting_App
{
    class Login
    {
        public static void Loginscreen(string username) { 
                tekrargiris:
                Console.WriteLine("Şifre :");
                string sifre = Console.ReadLine().Trim();
                bool donus = Users.Dogrumu(username, sifre);
                if (donus == true)
                {
                    Voiting_App.Voiting.Voiting.Oylama();
                }
                else
                {
                    Console.WriteLine("Yanlış Şifre girdiniz.Tekrar deneyiniz!");
                    goto tekrargiris;
                }
        }
    }
}
