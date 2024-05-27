using System.Data.Entity;

namespace WebApplication2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Insuree> Insurees { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}
