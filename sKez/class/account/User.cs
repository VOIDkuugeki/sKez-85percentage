using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    class User
    {
        public static int id { get; set; }
        public static String username { get; set; }
        public static String password { get; set; }
        public static String email;
        public static Profile info; //Composition

        static User()
        {
            id = 0;
        }

    }
}
