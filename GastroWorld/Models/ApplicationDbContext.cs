using Microsoft.EntityFrameworkCore;


namespace GastroWorld.Models
{
   
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<"">  "" { get; set; }
    }
}
