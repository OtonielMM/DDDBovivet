using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Infra.Mappings;

namespace DDDCommerce.Infra.Contexts
{
    public class DDDBovivet_ReproducaoDataContext : DbContext
    {

        public DDDBovivet_ReproducaoDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BancoDDDTeste1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            //Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VeterinarioMap());
            modelBuilder.Configurations.Add(new ExameItemMap());
            modelBuilder.Configurations.Add(new ExameMap());
            modelBuilder.Configurations.Add(new AnimalMap());
        }
    }
}
