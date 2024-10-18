using Microsoft.EntityFrameworkCore;
using Minimal.api.Dominio.Entidades;

namespace Minimal.api.Infraestruturas.DB
{
    public class DBContexto : DbContext
    {
        public DBContexto(DbContextOptions<DBContexto> options) : base(options)
        {
        }

        public DbSet<Adiministrador> Adiministradores { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adiministrador>().HasData(
                new Adiministrador
                {
                    Id = 1,
                    Email = "adm",
                    Senha = "123",
                    Perfil = "Adm"
                }

            );
        }

    }
}
