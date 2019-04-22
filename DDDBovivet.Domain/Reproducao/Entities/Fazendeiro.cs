using DDDBovivet.Domain.Reproducao.ValueObjects;
using DDDBovivet.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class Fazendeiro : Entity

    {
        public Nome Nome { get; private set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; private set; }
        public string Cnpj { get; set; }
    }
}
