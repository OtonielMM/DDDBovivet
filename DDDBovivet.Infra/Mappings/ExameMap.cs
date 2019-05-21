using DDDBovivet.Domain.Reproducao.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Infra.Mappings
{
   public  class ExameMap : EntityTypeConfiguration<Exame>
    {
        public ExameMap()
        {
            ToTable("Exame");
            HasKey(x => x.Id);
            HasRequired(x => x.Veterinario);
            Property(x => x.Numero).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.CreateDate).IsRequired();
            Property(x => x.Status).IsRequired();
            HasMany(x => x.Items);

            //Property(x => x.Items[]).IsRequired().HasMaxLength(11).IsFixedLength();
        }

    }
}
