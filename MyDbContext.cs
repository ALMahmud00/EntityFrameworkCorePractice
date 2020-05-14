using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCorePractice
{
    class MyDbContext : DbContext
    {
        

        public DbSet<Book> bookList { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = dbLibrary; Integrated Security = True");
        }

    }
}
