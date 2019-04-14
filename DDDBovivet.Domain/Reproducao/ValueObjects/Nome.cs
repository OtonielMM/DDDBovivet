using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.ValueObject;
using Flunt.Validations;

namespace DDDBovivet.Domain.Reproducao.ValueObjects
{
    public class Nome : ValueObject
    {
        public Nome(string nome, string sobrenome)
        {
            Nome1 = nome;
            Sobrenome = sobrenome;

            AddNotifications(
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "nome", "nome não deve ser vazio")
                );
        }

        private bool Validate()
        {
            if (!String.IsNullOrEmpty(Nome1))
                return true;

            return false;

        }

        public string Nome1 { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return Nome1 + " " + Sobrenome;
        }
    }
}
