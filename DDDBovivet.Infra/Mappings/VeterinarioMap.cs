using DDDBovivet.Domain.Reproducao.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Infra.Mappings
{
   public class VeterinarioMap : EntityTypeConfiguration<Veterinario>
    {
        public VeterinarioMap()
        {
            ToTable("Veterinario");
            HasKey(x => x.Id);
            Property(x => x.Documento).IsRequired().HasMaxLength(11).IsFixedLength();
           // Property(x => x.Email.MailAdress).HasmaxLength(60);
            Property(x => x.Nome.Nome1).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Nome.Sobrenome).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.EndEmail).IsRequired().HasMaxLength(45).IsFixedLength();
            Property(x => x.Fone).IsRequired().HasMaxLength(15).IsFixedLength();
        }
    }
}
