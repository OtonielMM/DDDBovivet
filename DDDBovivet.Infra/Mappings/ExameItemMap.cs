
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;

namespace DDDBovivet.Infra.Mappings
{
    public class ExameItemMap : EntityTypeConfiguration<ExameItem>
    {
        public ExameItemMap()
        {
            ToTable("ExameItem");
            HasKey(x => x.Id);
            Property(x => x.Valor).IsRequired();
            
        }
    }
}