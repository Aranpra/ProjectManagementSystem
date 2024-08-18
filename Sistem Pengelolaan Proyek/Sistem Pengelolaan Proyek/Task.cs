using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Pengelolaan_Proyek
{
    public class Task
    {
        public string TaskName { get; set; }
        public int Duration { get; set; }

        public Task(string taskName, int duration)
        {
            TaskName = taskName;
            Duration = duration;
        }
    }
}
