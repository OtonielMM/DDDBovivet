using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.ValueObject;

namespace DDDBovivet.Domain.Reproducao.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string rua, string bairro, string cidade, string estado, decimal numero)
        {
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Numero = numero;

            AddNotifications(
                new Contract()
                    .Requires()
                .IsTrue(Validate(), "rua", "nome não deve ser vazio")
                );
        }

        private bool Validate()
        {
            throw new NotImplementedException();
        }

        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public decimal Numero { get; set; }

        public override string ToString()
        {
            return Rua + " " + Numero + " " + Cidade;
        }
    }
}
