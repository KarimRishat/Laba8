using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Task
    {
        enum Status {Assigned, InProgress, UnderReview, Completed}
        public readonly int description;
        public readonly DateTime deadLine;
        public TeamLead lead;
        public Employee performer = null;
        public Report report;
        private Status status = Status.Assigned;
        public Task (DateTime date, int descr, TeamLead teamLead)
        {
            deadLine = date;
            description = descr;
            lead = teamLead;
            
        }
        public void ChangeStatus()
        {
            if (status != Status.Completed)
            {
                status++;
                
            }
            else
            {
                Console.WriteLine("Задача уже выполнена");
            }
        }
    }
}
