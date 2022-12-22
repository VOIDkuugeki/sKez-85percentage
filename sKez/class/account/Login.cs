using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Login
    {
        private String username;
        private String password;

        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        private bool checkValidiate(String username, String password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password)) return false;

            if (username.Length < 6 || password.Length < 8) return false;

            return true;
        }
    }
}
