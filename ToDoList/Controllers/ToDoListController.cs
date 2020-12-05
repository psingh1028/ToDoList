using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        [HttpGet]
        public IActionResult ListOfItems()
        {
            TaskToDo task = new TaskToDo("clean", "Dec_3rd", "Dec_4th");
            return View(task);

        }
        public IActionResult CreateTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTask(CreateTaskViewModel viewModel)
        {
            return View();
        }
    }
}
