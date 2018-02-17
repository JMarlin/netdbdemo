using System;

namespace netdbdemo.Models {

    public class DemoDBContext : DbContext {

        public DemoDBContext(DbContextOptions<DemoDBContext> options) : base(options) {}

        public DbSet<Parent> Parents { get; set; }
        //public DbSet<Child> Children { get; set; }
    }
}