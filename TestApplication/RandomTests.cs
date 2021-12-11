using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication
{
    public static class RandomTests
    {
        public static List<Test> GetRandomTests(List<Test> tests)
        {
            List<Test> randomTests = new List<Test>();

            int count = RandomFigures.RandomNumber(1, tests.Count() - 1);

            for (int i = 0; i < count; i++)
                randomTests.Add(GetRandomTest(tests));

            return randomTests;
        }

        private static Test GetRandomTest(List<Test> tests)
        {
            return tests[RandomFigures.RandomNumber(0, tests.Count() - 1)];
        }
    }
    public static class RandomFigures
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();

            int index = random.Next(min, max);

            return index;
        }

    }
}
