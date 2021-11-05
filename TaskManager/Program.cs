using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            TeamLead teamLead = new TeamLead("Aleksey");
            Project project1 = new Project("Vasya",DateTime.Now.AddDays(100),"proect",teamLead);
            teamLead.project = project1;
            List<Task> projTasks = new List<Task>();
            int n = 16;
            for (int i = 0; i < n-1; i++)
            {
                Task task = new Task(DateTime.Now.AddDays(5),rnd.Next(2), teamLead);
                projTasks.Add(task);
            }
            project1.CreateTasks(projTasks);
            foreach (var item in project1.tasks)
            {
                Console.WriteLine(item.description);
            }
            teamLead.team.Add(new Employee("Atos", teamLead));
            teamLead.team.Add(new Employee("Partos", teamLead));
            teamLead.team.Add(new Employee("Aramis", teamLead));
            teamLead.team.Add(new Employee("Ararat", teamLead));
            teamLead.team.Add(new Employee("Shrek", teamLead));
            teamLead.team.Add(new Employee("Miledy", teamLead));
            teamLead.team.Add(new Employee("D'artanyan", teamLead));
            teamLead.team.Add(new Employee("MarkAvreliy", teamLead));
            teamLead.team.Add(new Employee("Sonya", teamLead));
            teamLead.team.Add(new Employee("Marmeladova", teamLead));
            foreach (var item in teamLead.team)
            {
                Console.WriteLine(item.name);
            }
            teamLead.GiveTask();
            foreach (Employee employee in teamLead.team)
            {
                
                employee.SubmitReport();
            }
            teamLead.CloseProject(project1.tasks);
        }
    }
}
