using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskToDo
    {

        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public TaskToDo(string taskName, string startDate, string endDate)
        {
            TaskName = taskName;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
