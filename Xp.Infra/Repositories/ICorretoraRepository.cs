using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;

namespace Xp.Infra.Repositories
{
    public interface ICorretoraRepository
    {
        public void Save(Corretora corretora);

        public void Update(Corretora corretora);

        public void Delete(int id);

        public Corretora SearchById(int id);

        public List<Corretora> GetAll();
    }
}
