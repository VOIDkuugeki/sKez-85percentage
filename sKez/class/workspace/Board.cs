using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Board
    {
        private int id;
        private string name;
        private List<stickPaper> list;

        //Create 
        public Board()
        {
            this.name = "new board";
        }

        public Board(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Board(String input)
        {
            this.name = input;
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
        public void changeName(String input)
        {
            this.name = input;
        }

        //List
        public void addPaper(stickPaper paper)
        {
            this.list.Add(paper);
        }
        public void removePaper(stickPaper paper) 
        {
            this.list.Remove(paper);
        }
        public List<stickPaper> getPaperList()
        {
            return this.list;
        }
    }
}
