using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Fazenda.Entities
{
    public class Atividades
    {

        public Atividades(DateTime? expireDate)
        {
            Criado = DateTime.Now;
            DataAtualizacao = DateTime.Now;
            DataExpirar = expireDate;
            Active = true;
        }

        public DateTime Criado { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public DateTime? DataExpirar { get; set; }
        public bool Active { get; set; }
    }
}
