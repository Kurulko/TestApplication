using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApplication.Models
{
    public class Test
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        [NotMapped]
        public List<Task> Tasks { get; set; }
    }
}
