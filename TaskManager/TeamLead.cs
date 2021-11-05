using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class TeamLead
    {
        string name;
        public Project project;
        public List<Employee> team;
        public TeamLead(string name)
        {
            this.name = name;
            team = new List<Employee>();
        }
        public void GiveTask()
        {
            Random rnd = new Random();
            int count = project.tasks.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < team.Count; i++)
                {
                    int flag = rnd.Next(10);
                    Console.WriteLine("flag: "+flag);
                    if (flag / 2 == 0)
                    {
                        team[i].tasks.Add(project.tasks[j]);
                        project.tasks[j].ChangeStatus();
                        Console.WriteLine($"{team[i]} получил {project.tasks[j].description}");
                        i = team.Count;
                    }
                }
                
            }
            List<Task> delete = new List<Task>();
            foreach (var item in project.tasks)
            {
                if (item.performer == null)
                {
                    delete.Add(item);
                }
            }
            foreach (var item in delete)
            {
                DeleteTask(item);
            }
            project.ChangeStatus();
            
        }
        
        public void DeleteTask(Task task)
        {
            project.tasks.Remove(task);
        }
        public bool CheckReport(Report report, Task task)
        {
            if (report.reportText == task.description)
            {
                task.ChangeStatus();
                Console.WriteLine("Отчет принят");
                return true;
            }
            else
            {
                Console.WriteLine("Отчет не принят");
                return false;
            }
        }
        public void CloseProject(List <Task> tasks)
        {
            if (tasks.Count == 0)
            {
                project.CloseProject();
            }
            else
            {
                Console.WriteLine("Остались еще задачи");
                foreach (var item in tasks)
                {
                    Console.WriteLine(item.description);
                }
                
            }
        }
    }
}
