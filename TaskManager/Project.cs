using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Project
    {
        public enum Status { InProject, InProgress, Completed}
        public readonly DateTime deadLine;
        private string clientName;
        public readonly string description;
        private TeamLead lead;
        private Status status;
        public List <Task> tasks;
        public Project(string client, DateTime date, string descr, TeamLead lead)
        {
            clientName = client;
            deadLine = date;
            description = descr;
            this.lead = lead;
            status = Status.InProject;
        }
        public void CreateTasks(List <Task> tasks)
        {
            this.tasks = new List<Task>();
            if (tasks != null )
            {
                this.tasks = tasks;
            }
        }
        public void ChangeStatus()
        {
            if (status != Status.Completed)
            {
                status++;
                Console.WriteLine("proect"+status);
            }
        }
        public void CloseProject()
        {
            ChangeStatus();
            if (deadLine < DateTime.Now)
            {
                Console.WriteLine("Проект просрочен");

            }
            else
            {
                Console.WriteLine("Проект успешно завершен");
            }
        }
    }
}
