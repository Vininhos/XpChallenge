using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;

namespace Xp.Infra.Contexts
{
    public interface IContext
    {
        public List<Cliente> GetClientes(); 

        public Cliente GetCliente(int id);

        public void CreateCliente(Cliente cliente);

        public void UpdateCliente(Cliente cliente);

        public void DeleteCliente(int id);
    }
}
