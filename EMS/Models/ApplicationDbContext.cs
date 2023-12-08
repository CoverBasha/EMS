using System.Data.Entity;
namespace EMS.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
