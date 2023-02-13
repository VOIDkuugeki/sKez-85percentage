using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Workspace
    {
        private List<UCBoard> list;

        public Workspace()
        {

        }

        //List
        public void addBoard(UCBoard board)
        {
            this.list.Add(board);
        }
        public void removeBoard(UCBoard board)
        {
            this.list.Remove(board);
        }
        public List<UCBoard> getList()
        {
            return this.list;
        }
    }
}
