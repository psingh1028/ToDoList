using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult ListOfItems()
        {
            TaskToDo task = new TaskToDo("clean", "Dec_3rd", "Dec_4th");
            return View(task);

        }
    }
}
