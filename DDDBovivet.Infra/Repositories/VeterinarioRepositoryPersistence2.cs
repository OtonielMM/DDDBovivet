using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Infra.Contexts;
using System.Data.Entity;

namespace DDDBovivet.Infra.Repositories
{
    public class VeterinarioRepositoryPersistence2 : IVeterinarioRepository
    {
        private readonly DDDBovivet_ReproducaoAlternativo _context;

        public VeterinarioRepositoryPersistence2(DDDBovivet_ReproducaoAlternativo context)
        {
            _context = context;
        }

        public Veterinario GetById(Guid id)
        {
            return _context.Veterinarios.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //AsNoTracking não faz Cache dos dados da entidade no EF, não fica fazendo histórico 
            //das mudanças da entidade, somente faz a leitura e pronto, performance.
        }

        public void Save(Veterinario veterinario)
        {
            if (!veterinario.Valid) return;
            _context.Veterinarios.Add(veterinario);
            _context.SaveChanges();
        }

        public Task<List<Veterinario>> GetVeterinarios()
        {

            return _context.Veterinarios.ToListAsync();
        }
    }
}