using Microsoft.EntityFrameworkCore;
using Practice.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models.Contexts
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext()
        {

        }

        public DbSet<Customer> Customers { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=MASOUD-PC\MBZSERVER; Initial Catalog=StoreEF; Integrated Security=True;");
        }
    }
}
