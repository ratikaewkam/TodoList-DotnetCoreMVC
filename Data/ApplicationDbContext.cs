using TodoList_DotnetCoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoList_DotnetCoreMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
    }
}
