using BlazorServerApp.EmpCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.EmpCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
