using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.ViewModels
{
    public class CreateTaskViewModel
    {
        public string TaskName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
