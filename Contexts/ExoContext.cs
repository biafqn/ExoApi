using System.Data.SqlClient;
using Exo.WebApi.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext() { }

        public ExoContext(DbContextOptions<ExoContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "User ID=sa;Password=1234;Server=localhost;Database=ExoApi;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True;"
                );
            }
        }

        public DbSet<Projeto> Projetos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
