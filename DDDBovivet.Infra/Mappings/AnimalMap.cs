using DDDBovivet.Domain.Reproducao.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Infra.Mappings
{
    public class AnimalMap : EntityTypeConfiguration<Animal>
    {
        public AnimalMap()
        {
            ToTable("Animal");
            HasKey(x => x.Id);
            Property(x => x.Brinco).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Raca).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Sexo).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Valor).IsRequired();
            Property(x => x.QtdeOnHand).IsRequired();
            

        }
    }
}
