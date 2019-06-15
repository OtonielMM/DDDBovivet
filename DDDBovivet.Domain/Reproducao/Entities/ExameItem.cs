using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Shared.Entities;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class ExameItem : Entity
    {

        public ExameItem(Animal animal)
        {
            Animal1 = animal;
            Valor = animal.Valor;
            //Qtde = qtde;

            /* if (animal.QtdeOnHand < qtde)
                 AddNotification("Qtde", "Animal não sem cadastro");

             animal.DecreaseQtde(qtde);
             */
        }

        public Animal Animal1 { get; private set; }
        public decimal Valor { get; private set; }
        //public decimal Qtde { get; private set; }


    }
}
