using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class stickPaper
    {
        private int id;
        private String name;
        private List<ITask> list;
        private Decimal status;

        //Create
        public stickPaper()
        {
            this.name = "new paper";
        }
        public stickPaper(String name)
        {
            this.name = name;
        }

        //Edit
        public void changeName(String name)
        {
            this.name = name;
        }

        //List
        public void addTask(Task task)
        {
            list.Add(task);
        }
        public void removeTask(Task task)
        {
            list.Remove(task);
        }
        public void addGroupTask(GroupTask groupTask)
        {
            list.Add(groupTask);
        }
        public void removeGroupTask(GroupTask groupTask)
        {
            list.Remove(groupTask);
        }
        public List<ITask> getList()
        {
            return list;
        }
        
        //Status
        public Decimal getStatus()
        {
            if (this.list == null) return 0;

            Decimal progress = 0;
            int count = 0;
            foreach(Task t in list)
            {
                if (t.getStatus() == true) count++;
            }
            foreach(GroupTask t in list)
            {
                progress += t.getStatus();
            }

            Decimal status = progress + (count / list.OfType<Task>().Count());
            return status;
        }
    }
}
