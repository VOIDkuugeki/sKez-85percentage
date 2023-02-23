using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Note
    {
        private int id;
        private String name;

        public Note()
        {

        }
        public Note(int id, String name)
        {
            this.id = id;
            this.name = name;
        }

        //Id
        public int getId()
        {
            return this.id;
        }

        //Name
        public String getName()
        {
            return this.name;
        }
    }
}