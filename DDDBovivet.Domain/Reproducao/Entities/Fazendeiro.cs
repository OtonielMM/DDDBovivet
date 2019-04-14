using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class Fazendeiro
    {
        public Nome Nome { get; private set; }
        public Email Email { get; set; }
        public string Cnpj { get; set; }
    }
}
