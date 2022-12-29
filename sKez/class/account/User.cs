using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class User
    { 
        private String username;
        private String password { get; set; }
        protected String email;
        private Profile info; //Composition

        //Create
        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
            this.info = new Profile();
        }

        //Password
        public bool checkStrongPassword(String password)
        {
            //Length
            if(password.Length < 8) return false;

            //Number
            int count = 0;
            foreach(char c in password)
            {
                if (char.IsDigit(c)) count++;
            }
            if (count < 1) return false;

            //Uppercase
            count = 0;
            foreach(char c in password)
            {
                if(char.IsUpper(c)) count++;
            }
            if (count < 1) return false;

            //Lowercase
            count = 0;
            foreach(char c in password)
            {
                if(char.IsLower(c)) count++;
            }
            if(count < 1) return false;

            return true;
        }
        public void changePassword(String input, String newpwd)
        {
            if (input == this.password)
            {
                if(checkStrongPassword(newpwd)) this.password = newpwd;
            }
            else throw new InvalidOperationException();
        }

        //Email
        public void changeEmail(String input, String newemail)
        {
            if(input == this.password)
            {
                this.email = newemail;    
            }
            else throw new InvalidOperationException();
        }

        //Info
        public void editInfo(String first, String last)
        {
            if(first == null) this.info.setLastName(last);
            if(last == null) this.info.setFirstName(first);
            this.info.setName(first, last);
        }
        public void editImg(Image input)
        {
            this.info.setImg(input);
        }
    }
}
