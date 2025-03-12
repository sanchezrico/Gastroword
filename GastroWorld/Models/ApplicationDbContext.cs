using Microsoft.EntityFrameworkCore;
using Gastroworld.Models;
using Gastroworld.Models.Model;
using GastroWorld.Models.Model;

namespace Gastroworld.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<RecetaIngrediente> RecetaIngredientes { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Interaccion> Interacciones { get; set; }
        public DbSet<Mensaje> Mensajes { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Reseña> Reseñas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Receta>().ToTable("Receta");
            modelBuilder.Entity<Ingrediente>().ToTable("Ingrediente");
            modelBuilder.Entity<RecetaIngrediente>().ToTable("RecetaIngrediente");
            modelBuilder.Entity<Publicacion>().ToTable("Publicacion");
            modelBuilder.Entity<Comentario>().ToTable("Comentario");
            modelBuilder.Entity<Interaccion>().ToTable("Interaccion");
            modelBuilder.Entity<Mensaje>().ToTable("Mensaje");
            modelBuilder.Entity<Restaurante>().ToTable("Restaurante");
            modelBuilder.Entity<Plato>().ToTable("Plato");
            modelBuilder.Entity<Reseña>().ToTable("Reseñas");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //  base.OnModelCreating(modelBuilder);

        // Configuración para relaciones de Mensajes
        //modelBuilder.Entity<Mensaje>()
        ////      .HasOne(m => m.UsuarioEmisor)
        //  .WithMany()
        //.HasForeignKey(m => m.UsuarioEmisorId)
        //.OnDelete(DeleteBehavior.Restrict);

        //modelBuilder.Entity<Mensaje>()
        //        .HasOne(m => m.UsuarioReceptor)
        //        .WithMany()
        //        .HasForeignKey(m => m.UsuarioReceptorId)
        //        .OnDelete(DeleteBehavior.Restrict);
        //}
    }
}
