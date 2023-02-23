using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Board
    {
        private int id;
        private string name;

        //Create 
        public Board()
        {

        }
        public Board(int id, String name)
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
