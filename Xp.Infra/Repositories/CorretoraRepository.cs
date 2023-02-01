using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Contexts;

namespace Xp.Infra.Repositories
{
    public class CorretoraRepository : ICorretoraRepository
    {
        IContextCorretora _context;

        public CorretoraRepository(IContextCorretora context)
        {
            _context = new FakeContextCorretora();
        }

        public void Delete(int id)
        {
            _context.DeleteCorretora(id);
        }

        public List<Corretora> GetAll()
        {
            return _context.GetCorretoras();
        }

        public void Save(Corretora corretora)
        {
            _context.CreateCorretora(corretora);
        }

        public Corretora SearchById(int id)
        {
            return _context.GetCorretora(id);
        }

        public void Update(Corretora corretora)
        {
            _context.UpdateCorretora(corretora);
        }
    }
}
