using Xp.Domain.Entities;
using Xp.Infra.Repositories;

namespace Xp.Services.Service
{
    public class ClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente SearchById(int id)
        {
            return _clienteRepository.SearchById(id);
        }

        public void Save(Cliente cliente)
        {
            _clienteRepository.Save(cliente);
        }

        public void Update(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void Delete(int id)
        {
            _clienteRepository.Delete(id);
        }
    }
}
