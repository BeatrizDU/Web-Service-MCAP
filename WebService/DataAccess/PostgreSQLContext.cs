using Microsoft.EntityFrameworkCore;
using WebService.Models;

namespace WebService.DataAccess
{
    /// <summary>
    /// BDOMINGUEZ 24/05/2023
    /// Clase para el manejo de la base de datos en PostgreSQL
    /// </summary>
    public class PostgreSQLContext : DbContext 
    {
        public DbSet<catalumno> catalumno { get; set; }
        
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options) 
        {    
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
