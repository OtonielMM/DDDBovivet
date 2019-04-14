using DDDBovivet.Domain.Reproducao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Reproducao.Repositories
{
    public interface IExameRepository
    {
        void Save(Exame exame);
        IEnumerable<Exame> GetExames();
        Exame GetExameById(Guid exameId);
        IEnumerable<Exame> GetExamesByVeterinario(Guid id); //Pedidos de um Veterinario
    }
}
