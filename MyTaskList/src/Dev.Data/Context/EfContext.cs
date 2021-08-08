using Dev.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Data.Context
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options) { }

        public DbSet<Task> Task { get; set; }

        public DbSet<TaskContext> TaskContext { get; set; }
    }
}
