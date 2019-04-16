using System;
using System.Collections.Generic;
using DDDBovivet.Domain.Reproducao.Entities;

namespace DDDBovivet.Domain.Reproducao.Repositories
{
    public interface IAnimalRepository
    {
        Animal Get(Guid id);
        IList<Animal> GetAnimals(List<Guid> ids);
    }
}
