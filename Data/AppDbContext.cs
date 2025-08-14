using Microsoft.EntityFrameworkCore;
using TaskManagementApp.Backend.Models;

namespace TaskManagementApp.Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TaskItem> Tasks { get; set; }
    }
}
