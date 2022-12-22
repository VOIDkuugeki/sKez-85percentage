using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Workspace
    {
        private List<Board> list;

        public Workspace()
        {

        }

        //List
        public void addBoard(Board board)
        {
            this.list.Add(board);
        }
        public void removeBoard(Board board)
        {
            this.list.Remove(board);
        }
        public List<Board> getList()
        {
            return this.list;
        }
    }
}
