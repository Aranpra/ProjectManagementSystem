using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pengelolaan_Proyek
{
    public class Manager : Project
    {
        public string ManagerName { get; set; }
        public string Position { get; set; }

        public Manager(string projectName, DateTime deadline, string managerName, string position)
            : base(projectName, deadline)
        {
            ManagerName = managerName;
            Position = position;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Manajer: {ManagerName}, Posisi: {Position}");
        }
    }
}
