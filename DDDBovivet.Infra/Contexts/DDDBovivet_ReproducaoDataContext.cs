using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Infra.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Infra.Contexts
{
   public class DDDBovivet_ReproducaoDataContext : DbContext

    {
        public DDDBovivet_ReproducaoDataContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBBovivet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Exame> Exames { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // sobreescrever o metodo de criação das tabelas
        {
            modelBuilder.Configurations.Add(new VeterinarioMap());
            modelBuilder.Configurations.Add(new AnimalMap());
            modelBuilder.Configurations.Add(new ExameMap());
        }


    }
}
