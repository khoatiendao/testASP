using Microsoft.EntityFrameworkCore;
using testASP.Models.Entities;

namespace testASP.Data
{
    public class AppliactionDbContext : DbContext
    {
        public AppliactionDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
