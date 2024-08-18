using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pengelolaan_Proyek
{
    public abstract class Project : IManagement
    {
        public string ProjectName { get; set; }
        public DateTime Deadline { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string projectName, DateTime deadline)
        {
            ProjectName = projectName;
            Deadline = deadline;
            Tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Proyek: {ProjectName}, Tenggat Waktu: {Deadline:dd/MM/yyyy}");
            Console.WriteLine("Tugas:");
            foreach (var task in Tasks)
            {
                Console.WriteLine($"- {task.TaskName} (Durasi: {task.Duration} hari)");
            }
        }
    }
}
