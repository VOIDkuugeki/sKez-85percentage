using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sKez
{
    public class GroupTask : ITask
    {
        private String description;
        private Decimal status;
        private List<Task> list;

        //Create
        public GroupTask()
        {
            this.name = "new group";
        }
        public GroupTask(String input)
        {
            this.name = input; 
        }

        //Edit
        public void changeName(String input)
        {
            this.name = input;
        }
        public void editDesc(string input)
        {
            this.description = input;
        }
        //List
        public void addTask(Task task)
        {
            this.list.Add(task);
        }
        public void removeTask(Task task)
        {
            this.list.Remove(task);
        }
        public List<Task> getList()
        {
            return this.list;
        }

        //Status
        public Decimal getStatus()
        {
            if (this.list == null) return 0;

            int count = 0;
            foreach(Task t in this.list)
            {
                if (t.getStatus() == true) count++;
            }
            return count/(this.list.Count());
        }
    }
}
