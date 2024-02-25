using System.Data.Entity;
using ToDoPlanner.BL.Model;

namespace ToDoPlanner.BL.Controller.DB
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
