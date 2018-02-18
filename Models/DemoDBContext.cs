using System;
using Microsoft.EntityFrameworkCore;

namespace netdbdemo.Models {

    public class DemoDBContext : DbContext {

        public DemoDBContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseNpgsql("Server=localhost;Database=netdbdemo;Username=netdbdemo;Password=dbdemopass");
        }

        public DbSet<Parent> Parents { get; set; }
        //public DbSet<Child> Children { get; set; }
    }
}