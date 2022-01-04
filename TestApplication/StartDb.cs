using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using TestApplication.Models;
using TestApplication.Models.Database;

namespace TestApplication
{
    public class StartDb
    {
        public static void Initialize(ApplicationContext db)
        {
            if (!db.Tasks.Any() || !db.Tests.Any())
            {

                #region Tests

                Test[] tests;

                Test test1 = new Test
                {
                    Description = "Information about test1",
                    Name = "Test #1",
                };
                Test test2 = new Test
                {
                    Description = "Information about test2",
                    Name = "Test #2",
                };
                Test test3 = new Test
                {
                    Description = "Information about test3",
                    Name = "Test #3",
                };
                Test test4 = new Test
                {
                    Description = "Information about test4",
                    Name = "Test #4",
                };
                Test test5 = new Test
                {
                    Description = "Information about test5",
                    Name = "Test #5",
                };

                tests = new Test[]{ test1,test2,test3,test4,test5};
                for (int i = 0; i < tests.Length; i++)
                {
                    db.Tests.Add(tests[i]);
                    db.SaveChanges();
                }

                #endregion

                #region Tasks
                Task[] tasksForTest1 = new Task[5];
                for (int i = 0; i < tasksForTest1.Length; i++)
                {
                    tasksForTest1[i] = new Task { Question = $"{i} + 1 = ?", Answer = i + 1, FakeAnswer = RandomFigures.RandomNumber(0, 50), Test = tests[0] };
                }
                for (int i = 0; i < tasksForTest1.Length; i++)
                {
                    db.Tasks.Add(tasksForTest1[i]);
                    db.SaveChanges();
                }

                Task[] tasksForTest2 = new Task[2];
                for (int i = 0; i < tasksForTest2.Length; i++)
                {
                    tasksForTest2[i] = new Task { Question = $"{i} + 2 = ?", Answer = i + 2, FakeAnswer = RandomFigures.RandomNumber(0, 50), Test = tests[1] };
                }
                for (int i = 0; i < tasksForTest2.Length; i++)
                {
                    db.Tasks.Add(tasksForTest2[i]);
                    db.SaveChanges();
                }

                Task[] tasksForTest3 = new Task[4];
                for (int i = 0; i < tasksForTest3.Length; i++)
                {
                    tasksForTest3[i] = new Task { Question = $"{i} + 3 = ?", Answer = i + 3, FakeAnswer = RandomFigures.RandomNumber(0, 50), Test = tests[2] };
                }
                for (int i = 0; i < tasksForTest3.Length; i++)
                {
                    db.Tasks.Add(tasksForTest3[i]);
                    db.SaveChanges();
                }

                Task[] tasksForTest4 = new Task[2];
                for (int i = 0; i < tasksForTest4.Length; i++)
                {
                    tasksForTest4[i] = new Task { Question = $"{i} + 4 = ?", Answer = i + 4, FakeAnswer = RandomFigures.RandomNumber(0, 50), Test = tests[3] };
                }
                for (int i = 0; i < tasksForTest4.Length; i++)
                {
                    db.Tasks.Add(tasksForTest4[i]);
                    db.SaveChanges();
                }

                Task[] tasksForTest5 = new Task[3];
                for (int i = 0; i < tasksForTest5.Length; i++)
                {
                    tasksForTest5[i] = new Task { Question = $"{i} + 5 = ?", Answer = i + 5, FakeAnswer = RandomFigures.RandomNumber(0, 50), Test = tests[4] };
                }
                for (int i = 0; i < tasksForTest5.Length; i++)
                {
                    db.Tasks.Add(tasksForTest5[i]);
                    db.SaveChanges();
                }

                #endregion

            }
        }
    }
}
