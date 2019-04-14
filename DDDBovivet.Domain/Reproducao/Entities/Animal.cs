using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.Entities;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class Animal : Entity
    {
        public Animal(
            string brinco,
            string nome,
            string raca,
            string sexo,
            decimal valor,
            decimal crias)
        {
            Brinco = brinco;
            Nome = nome;
            Raca = raca;
            Valor = valor;
            QtdeOnHand = crias;
        }

        public string Brinco { get; private set; }
        public string Nome { get; private set; }
        public string Raca { get; private set; }
        public decimal Valor { get; private set; }
        public decimal QtdeOnHand { get; private set; }

        public override string ToString()
        {
            return Nome;
        }






        /* public void DecreaseQtde(decimal crias)
         {
             QtdeOnHand -= crias;
         }*/
    }
}
