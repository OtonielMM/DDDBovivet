using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Infra.Contexts;

namespace DDDBovivet.Infra.Repositories
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly DDDBovivet_ReproducaoDataContext _context;

        public AnimalRepository(DDDBovivet_ReproducaoDataContext context)
        {
            _context = context;
        }

        public Animal Get(Guid id)
        {
            return _context.Animais.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Animal> GetAnimais(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
