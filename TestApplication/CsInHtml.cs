using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Controllers;

namespace TestApplication
{
    public static class CsInHtml
    {
        public static int Increment(int i) => i + 1;
        public static int IncrementByCountRightTask()
        {
            return ++TestsController.CountOfRightAsnwers;
        }
        public static int DecrementByCountRightTask()
        {
            return --TestsController.CountOfRightAsnwers;
        }
    }
}
