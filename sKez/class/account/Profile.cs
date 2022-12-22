using sKez.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Profile
    {
        private String firstname { get; set; }
        private String lastname { get; set; }
        private Image img { get; set; }

        //Create
        public Profile() 
        {
            this.img = Resources.user;
        }
        public Profile(String firstname, String lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        //Edit
        public void setFirstName(String firstName)
        {
            this.firstname = firstName;
        }
        public void setLastName(String lastName)
        {
            this.lastname = lastName;
        }
        public String getFirstname()
        {
            return this.firstname;
        }
        public String getLastname()
        {
            return this.lastname;
        }
        public void setName(String first, String last)
        {
            setFirstName(first); setLastName(last);
        }
        public String getName()
        {
            return getFirstname() + " " + getLastname();
        }

        public void setImg(Image img)
        {
            this.img = img;
        }
        public Image getImg()
        {
            return this.img;
        }
    }
}
