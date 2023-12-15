using Microsoft.EntityFrameworkCore;

namespace EMS.Models
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<Employee> Employees { get; set; }

		public ApplicationDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLSERVER; Database=EMS; Trusted_Connection=true; TrustServerCertificate=true;");
        }
    }
}
