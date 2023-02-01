using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Domain.Enums;
using Xp.Domain.Setup;
using Xp.Infra.Contexts;

namespace Xp.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly IContextCliente _context;

        public ClienteRepository()
        {
            if (ConfigApp.SELECTED_DATABASE.Equals(DatabaseType.Fake))
                _context = new FakeContextCliente();
        }

        public void Save(Cliente cliente)
        {
            _context.CreateCliente(cliente);
        }

        public void Update(Cliente cliente)
        {
            _context.UpdateCliente(cliente);
        }

        public void Delete(int id)
        {
            _context.DeleteCliente(id);
        }

        public List<Cliente> GetAll()
        {
            return _context.GetClientes();
        }

        public Cliente SearchById(int id)
        {
            return _context.GetCliente(id);
        }

    }
}
