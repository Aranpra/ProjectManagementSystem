using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pengelolaan_Proyek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                          ===================================");
            Console.WriteLine("                                               Sistem Pengelolaan Proyek     ");
            Console.WriteLine("                                          ===================================\n");
            Console.WriteLine();

            Console.Write("Nama proyek                          : ");
            string projectName = Console.ReadLine();
            
            Console.Write("Tenggat waktu (format: yyyy-MM-dd)   : ");
            DateTime projectDeadline = DateTime.Parse(Console.ReadLine());

            Console.Write("Nama Manajer                         : ");
            string managerName = Console.ReadLine();

            Console.Write("Posisi Manajer                       : ");
            string managerPosition = Console.ReadLine();

            Manager manager = new Manager(projectName, projectDeadline, managerName, managerPosition);

            Console.Write("Banyak tugas                         : ");
            int taskCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < taskCount; i++)
            {
                Console.Write($"Nama tugas ke-{i + 1}                      : ");
                string taskName = Console.ReadLine();

                Console.Write("urasi tugas (dalam hari)             : ");
                int taskDuration = int.Parse(Console.ReadLine());

                Task task = new Task(taskName, taskDuration);
                Console.WriteLine();
                manager.AddTask(task);
            }
            
            Console.Write("\nData Proyek : ");
            manager.DisplayInfo();
            Console.WriteLine();
        }
    }
}
