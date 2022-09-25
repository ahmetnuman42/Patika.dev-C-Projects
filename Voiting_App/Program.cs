using System;
using Voiting_App.Data;
using Voiting_App.Objects;

namespace Voiting_App
{
    class Program
    {
        static void Main()
        {
            Users user = new Users();
            Console.WriteLine("Lütfen giriş yapınız :");
            Console.WriteLine("Kullanıcı Adı :");
            string username = Console.ReadLine().Trim();
            bool gelis=user.IsThere(username);
            if (gelis == true)
            {
                Login.Loginscreen(username);                
            }
            else
            {
                Console.WriteLine("Tanımlı olmayan kullanıcı");
                user.NewUser();
            }
        }
    }
}
