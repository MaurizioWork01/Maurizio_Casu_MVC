using AcademyTest.Week8.Core.Entities;
using AcademyTest.Week8.RepositoryEF.Configuration;
using Microsoft.EntityFrameworkCore;

namespace AcademyTest.Week8.RepositoryEF
{
    internal class MasterContext : DbContext
    {
        public DbSet<Piatto> Piatti { get; set; }
        public DbSet<Menu> Menu { get; set;  }

        public MasterContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Ristorante;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Piatto>(new PiattoConfiguration());
            modelBuilder.ApplyConfiguration<Menu>(new MenuConfiguration());
        }
        
    }
}