using Microsoft.EntityFrameworkCore;
using ImmesAPI.Domain;
using ImmesAPI.Data.Configurations;

namespace ImmesAPI.Data
{
    public class ImmesContext : DbContext
    {
        public DbSet<Curso> CursoSet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string conexao 
                = "server=localhost;database=Immes;port=3306;uid=root";

            optionsBuilder.UseMySql(conexao,
                ServerVersion.AutoDetect(conexao));

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
