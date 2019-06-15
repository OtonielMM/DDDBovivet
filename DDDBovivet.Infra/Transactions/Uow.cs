using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDCommerce.Infra.Contexts;

namespace DDDBovivet.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly DDDBovivet_ReproducaoDataContext _context;

        public Uow(DDDBovivet_ReproducaoDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            
        }
    }
}