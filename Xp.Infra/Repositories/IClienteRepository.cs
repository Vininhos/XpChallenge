using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;

namespace Xp.Infra.Repositories
{
    public interface IClienteRepository
    {
        public void Save(Cliente cliente);

        public void Update(Cliente cliente);

        public void Delete(int id);

        public Cliente SearchById(int id);

        public List<Cliente> GetAll();

    }
}
