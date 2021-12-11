using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models.Database;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class TestsController : Controller
    {
        ApplicationContext db;
        public TestsController(ApplicationContext context)
        {
            db = context;
        }
        static List<Test> tests = new List<Test>();
        public static int CountOfRightAsnwers { get; set; }
        public static int CountOfTask { get;}

        static TestsController()
        {
            //for (int i = 0; i < 50; ++i)
            //{
            //    db.Tests.Add(new Test() { Description = $"Краткое описание теста №{i}", Name = $"Test №{i}" });
            //    db.SaveChanges();
            //}
            for (int i = 0; i < 50; ++i)
                tests.Add(new Test()
                {
                    Description = $"Краткое описание теста №{i}",
                    Name = $"Test №{i}",
                    Id = i,
                    Tasks = new List<Models.Task>() {
                        new Models.Task()
                        {
                            Answer = 2 + i,
                            Question = $"#1: 2+{i} = ?",
                            Id = 0
                        },
                        new Models.Task()
                        {
                            Answer = 3 + i,
                            Question = $"#2: 3+{i} = ?",
                            Id = 1
                        },
                        new Models.Task()
                        {
                            Answer = 4 + i,
                            Question = $"#3: 4+{i} = ?",
                            Id = 2
                        }
                    }
                });
            CountOfTask = tests[0].Tasks.Count;
        }
        public IActionResult Tests()
        {
            return View(RandomTests.GetRandomTests(/*db.Tests.ToList()*/tests));
        }
        public IActionResult Test(int id)
        {
            return View(tests[id]);
        }
        public IActionResult Task(int id,int number)
        {
            return View(new TaskAndIdOfTest() { Task = tests[id].Tasks[number], IdOfTest = id });
        }
        public IActionResult Result()
        {
            return View(CountOfRightAsnwers);
        }
    }
    public class TaskAndIdOfTest
    {
        public Models.Task Task { get; set; }
        public int IdOfTest { get; set; }
    }
}
