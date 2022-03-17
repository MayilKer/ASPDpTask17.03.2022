using ASPDbTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDbTask.DAL
{
    public class DbContextTask : DbContext
    {
        public DbContextTask(DbContextOptions<DbContextTask> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
