using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.Entities;
using DDDBovivet.Domain.Reproducao.ValueObjects;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class Veterinario : Entity
    {
        public Veterinario(
            Nome nome,
            string documento,
            Email email,
            string fone)

        {
            Nome = nome;
            Documento = documento;
            Email = email;
            Fone = fone;

        }
        public Nome Nome { get; private set; }
        public string Documento { get; private set; }
        public Email Email { get; private set; }
        public string Fone { get; private set; }

    }
}
