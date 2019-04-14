using DDDBovivet.Domain.Reproducao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Reproducao.Repositories
{
    public interface IVeterinarioRepository
    {
        Veterinario GetById(Guid id);
        void Save(Veterinario veterinario);
        IEnumerable<Veterinario> GetVeterinarios();
    }
}
