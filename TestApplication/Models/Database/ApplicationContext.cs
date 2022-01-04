using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApplication.Models.Database
{
    public class ApplicationContext : /*DbContext:*/ IdentityDbContext<User>
    {
        public DbSet<Test> Tests { get; set; }
        public DbSet<Task> Tasks { get; set; }
        //public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
