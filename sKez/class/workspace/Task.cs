using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sKez
{
    public class Task : ITask
    {
        private DateTime startTime;
        private DateTime endTime;
        private Boolean status;
        private String note;

        //Create
        public Task()
        {
            this.name = "new task";
            this.status = false;
        }
        public Task(String input)
        {
            this.name = input;
            this.status = false;
        }
        
        //Name
        public void changeName(String newname)
        {
            this.name = newname;
        }

        //Time
        public void setStartTime(DateTime startTime) 
        {
            this.startTime = startTime;
        }
        public void setEndTime(DateTime endTime)
        {
            this.endTime = endTime;
        }
        public void setTime(DateTime startTime, DateTime endTime) 
        {
            setStartTime(startTime);
            setEndTime(endTime);
        }

        public DateTime getStartTime()
        {
            return this.startTime;
        }
        public DateTime getEndTime()
        {
            return this.endTime;
        }

        //Status
        public void changeStatus()
        {
            if(this.status == false) this.status = true;
            else this.status = false;
        }
        public Boolean getStatus()
        {
            return this.status;
        }

        //Note
        public void writeNote(String input)
        {
            this.note = input;
        }
        public String getNote()
        {
            return this.note;
        }
    }
}
