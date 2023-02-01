using Xp.Domain.Entities;

namespace Xp.Infra.Contexts
{
    public interface IContextCliente
    {
        public List<Cliente> GetClientes(); 

        public Cliente GetCliente(int id);

        public void CreateCliente(Cliente cliente);

        public void UpdateCliente(Cliente cliente);

        public void DeleteCliente(int id);
    }
}
