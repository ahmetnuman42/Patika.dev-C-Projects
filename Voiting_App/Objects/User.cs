using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiting_App.Objects
{
    class User
    {
        private int ID;
        private string Username;
        private string Password;
        public int _ID { get { return ID; } set { this.ID = value; } }
        public string _Username { get { return Username; } set { this.Username = value; } }

       

        public string _Password { get { return Password; } set { this.Password = value; } }
        public User(int id,string username,string passwd)
        {
            this._ID = id;
            this._Username = username;
            this._Password = passwd;
        }
    }
}
