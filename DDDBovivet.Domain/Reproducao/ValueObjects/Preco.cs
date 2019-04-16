using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.ValueObject;

namespace DDDBovivet.Domain.Reproducao.ValueObjects
{
   public class Preco : ValueObject
   
    {
        public Preco(string moeda, string valor)
        {
            Moeda = moeda;
            Valor = valor;

            if (String.IsNullOrEmpty(Valor))
                AddNotification("Valor", "Valor não deve estar vazio");

        }

        public string Moeda { get; set; }
        public string Valor { get; set; }

    }
}
