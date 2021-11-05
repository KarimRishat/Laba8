using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Employee
    {
        public string name;
        public TeamLead lead;
        public List <Task> tasks = new List<Task>();
        public Employee(string name, TeamLead lead)
        {
            this.name = name;
            this.lead = lead;
        }
        public void SubmitReport()
        {
            Random rnd = new Random();
            foreach (Task item in tasks)
            {
                
                item.ChangeStatus();
                bool check = false;
                while (!check)
                {
                    int text = rnd.Next(2);
                    Report report = new Report(item, name, DateTime.Now, text);
                    if (lead.CheckReport(report, item))
                    {
                        check = true;
                    }
                }
                
                lead.DeleteTask(item);
            }
            
        }
    }
}
