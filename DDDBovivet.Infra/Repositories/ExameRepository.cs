
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Entities;
using DDDBovivet.Domain.Reproducao.Repositories;
using DDDBovivet.Infra.Contexts;

namespace DDDBovivet.Infra.Repositories
{
    public class ExameRepository : IExameRepository
    {
        private readonly DDDBovivet_ReproducaoDataContext _context;

        public ExameRepository(DDDBovivet_ReproducaoDataContext context)
        {
            _context = context;
        }

        public void Save(Exame exame)
        {
            _context.Exames.Add(exame);
            _context.SaveChanges();
        }

        public IEnumerable<Exame> GetExames()
        {
            return _context.Exames.ToList();
        }

        public Exame GetExameById(Guid exameId)
        {
            var exame = _context.Exames.FirstOrDefault(c => c.Id == exameId);

            return exame;
        }

        public IEnumerable<Exame> GetExamesByExame(Guid id)
        {
            var exames = _context.Exames.Include("Veterinario").ToList().Where(c => c.Veterinario.Id == id);
            return exames;
        }
    }
}