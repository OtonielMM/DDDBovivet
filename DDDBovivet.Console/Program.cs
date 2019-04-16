using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Domain.Reproducao.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDBovivet.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Para gerar um exame iremos precisar: veterinario, animal...

            var fakeVeterinarioRepository = new FakeVeterinarioRepository();
            var fakeAnimalRepository = new FakeAnimalRepository();
            var animal1 = new Dictionary<Guid, int> { { Guid.NewGuid(), 5 } };
            var animal2 = new Dictionary<Guid, int> { { Guid.NewGuid(), 2 } };
            var animal3 = new Dictionary<Guid, int> { { Guid.NewGuid(), 3 } };
            var selectedAnimals = new List<Dictionary<Guid, int>> { animal1, animal2, animal3 };
            GenerateExame(fakeVeterinarioRepository, fakeAnimalRepository, selectedAnimals, Guid.NewGuid());


        }

        public static void GenerateExame(
           IVeterinarioRepository veterinarioRepository,
           IAnimalRepository animalRepository,
           List<Dictionary<Guid, int>> animalsGuids,
           Guid userId)
        {
            var veterinario = veterinarioRepository.GetById(userId);
            var exame = new Exame(veterinario);

            foreach (var animalGuid in animalsGuids)
            {
                var animal = animalRepository.Get(animalGuid.First().Key);
                var exameItem = new ExameItem(animal);
                exame.AddItem(exameItem);
            }

        }
    }

    public class FakeAnimalRepository : IAnimalRepository
    {
        public Animal Get(Guid id)
        {
            //É somente um teste, portanto, retornaremos um mesmo animal e sem vínculo de Id(Guid)
            return new Animal("123", "Mimosa", "Nelore","", 1200, 12);
        }

        public IList<Animal> GetAnimals(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeVeterinarioRepository : IVeterinarioRepository
    {

        //Vamos criar um Veterinario Fake para fazermos testes
        public Veterinario GetById(Guid id)
        {
            var veterinarioFake = new Veterinario
            (
                new Nome("Tony", "Monteiro"),
                "21",
                new Email("teste@teste.gmail.com"),
                "12345678"
            );
            return veterinarioFake;
        }

        public void Save(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veterinario> GetVeterinarios()
        {
            throw new NotImplementedException();
        }
    }
}
