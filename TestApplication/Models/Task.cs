﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class Task
    {
        public string Question { get; set; }
        public int Answer { get; set; }
        public int FakeAnswer { get; set; }
        public int Id { get; set; }
        public Test Test { get; set; }
        public int TestId { get; set; }
    }
}
