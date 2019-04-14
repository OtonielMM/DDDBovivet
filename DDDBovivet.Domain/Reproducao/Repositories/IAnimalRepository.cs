using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Domain.Reproducao.Repositories
{
    public interface AnimalRepository
    {
        Animal Get(Guid id);
        IList<Animal> GetAnimals(List<Guid> ids);
    }
}
