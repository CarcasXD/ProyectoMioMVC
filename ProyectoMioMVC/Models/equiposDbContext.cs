using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace ProyectoMioMVC.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options) 
        {

        }
        public DbSet<marcas> marcas { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<Equipo> Equipo { get; set; }
    }
}
