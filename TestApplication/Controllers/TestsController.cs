using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TestApplication.Models.Database;
using TestApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using TestApplication.ViewModels;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace TestApplication.Controllers
{
    [Authorize]
    public class TestsController : Controller
    {
        ApplicationContext db;
        public TestsController(ApplicationContext context)
        {
            db = context;
        }

        public IActionResult Tests()
        {
            string name = User.Identity.Name;

            List<Test> tests = db.Tests
                .Include(t => t.Tasks)
                .Where(t => t.User.UserName == name).ToList();

            return View(tests);
        }

        [HttpGet]
        public IActionResult Test(int? id)
        {
            if (id != null)
            {
                Test test = db.Tests.Include(t => t.Tasks)
                    .FirstOrDefault(t => t.Id == id);
                if (test != null)
                    return View(test);
            }
            return RedirectToAction("Tests");
        }
        [HttpPost]
        public IActionResult Test(bool can, int id)
        {
            if (can)
                return RedirectToAction("Task", new { idTest = id });
            return RedirectToAction("Test", new { id = id });
        }

        public IActionResult Task(int idTest, int idTask, int result)
        {
            Test test = db.Tests
            .Include(t => t.Tasks)
            .FirstOrDefault(t => t.Id == idTest);

            if (test == null)
                return RedirectToAction("Tests");

            int countOfTest = test.Tasks.Count;

            if (idTask < countOfTest)
            {
                Models.Task task = test.Tasks[idTask];
                TaskAndResult taskAndResult = new TaskAndResult
                {
                    Result = result,
                    Task = task,
                    IdTask = idTask
                };
                return View(taskAndResult);
            }
            return RedirectToAction("Result", new { result = result, countOfTest = countOfTest });
        }
        public IActionResult Result(int? result, int? countOfTest)
        {
            if (result != null && countOfTest != null)
                return View(new ResultAndCount
                {
                    Result = (int)result,
                    CountOfTest = (int)countOfTest
                });
            return RedirectToAction("Tests");
        }
    }

}
