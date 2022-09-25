using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voiting_App.Objects;

namespace Voiting_App.Data
{
    class Users
    {
        public List<User> kullanicilar {get {return Kullanicilar;}}

        public static List<User> Kullanicilar = new();
        public Users()
        {
            User user = new User(0, "Ahmet", "123");
            User user1 = new User(1, "Veli", "9154");
            User user2 = new User(2, "Elif", "0000");

            Kullanicilar.Add(user);
            Kullanicilar.Add(user1);
            Kullanicilar.Add(user2);
        }

        public static bool Dogrumu(string username, string sifre)
        {
            User user = Kullanicilar.FirstOrDefault(x => x._Username == username);
            if (user._Password!=sifre) return false;
            else return true;
        }

        public void NewUser()
        {
            Console.WriteLine("Yeni kayıt ekranına hoşgeldiniz");
            Console.WriteLine("Kullanıcı adı giriniz");
            string kullan = Console.ReadLine().Trim();
            Console.WriteLine("Şifre giriniz");
            string sifre = Console.ReadLine().Trim();
            User yenikayit = new User(Kullanicilar.Count, kullan, sifre);
            Kullanicilar.Add(yenikayit);
            Voiting.Voiting.Oylama();
        }

        public bool IsThere(string username)
        {
            User user = Kullanicilar.FirstOrDefault(x => x._Username == username);
            if (user == null) return false;
            else return true;
        }
     }
}

    

