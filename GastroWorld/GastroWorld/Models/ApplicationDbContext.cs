using Microsoft.EntityFrameworkCore;
using System;

namespace GastroWorld.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Tucuenta> Usuarios { get; set; }
    }
}
