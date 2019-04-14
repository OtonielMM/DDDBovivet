using DDDBovivet.Domain.Fazenda.ValueObjects;
using DDDBovivet.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Fazenda.Entities
{
    public class Propriedade : Entity
    {

        public Propriedade(string nome, Endereco endereco, string fone)
        {
            Nome = nome;
            Endereco = Endereco;
            Fone = fone;
        }


        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Fone { get; private set; }


    }
}
