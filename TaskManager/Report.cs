using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    class Report
    {
        public int reportText;
        public DateTime date;
        public string perfomer;
        public Task task;
        public Report (Task task, string perfomer,DateTime date, int text)
        {
            this.perfomer = perfomer;
            reportText = text;
            this.task = task;
            this.date = date;
        }
    }
}
