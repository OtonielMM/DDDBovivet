using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDDBovivet.Domain.Reproducao.Enums;
using DDDBovivet.Shared.Entities;

namespace DDDBovivet.Domain.Reproducao.Entities
{
    public class Exame : Entity
    {
        private IList<ExameItem> _items { get; set; }

        public Exame(Veterinario veterinario)
        {
            Veterinario = veterinario;
            CreateDate = DateTime.Now;
            Status = ExameStatus.Criado;
            _items = new List<ExameItem>();
        }

        public Veterinario Veterinario { get; private set; }
        public string Numero { get; private set; }
        public DateTime CreateDate { get; private set; }
        public ExameStatus Status { get; private set; }
        public ICollection<ExameItem> Items => _items.ToArray();

        public void AddItem(ExameItem exameItem)
        {
            if (exameItem.Valid)
            {
                _items.Add(exameItem);
            }

        }
    }
}
