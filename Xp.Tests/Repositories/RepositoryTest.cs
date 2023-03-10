using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Repositories;
using Xp.Tests.Helpers;

namespace Xp.Tests.Repositories
{
    public class RepositoryTest
    {
        private readonly IClienteRepository _clienteRepository;

        public RepositoryTest(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Execute()
        {
            try
            {
                ValidateClienteListing();
                ValidateRegistrationCliente();
                ValidateSearchByIdCliente();
                ValidateUpdateCliente();
                ValidateDeleteCliente();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void ValidateClienteListing()
        {
            List<Cliente> clientes = _clienteRepository.GetAll();

            foreach (Cliente cliente in clientes)
                Console.WriteLine($"Id: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        public void ValidateSearchByIdCliente()
        {
            int id = 1;
            Cliente cliente = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        public void ValidateRegistrationCliente()
        {
            Cliente cliente = ClienteFactory.GetNewCliente();

            int id = cliente.CodCliente;

            _clienteRepository.Save(cliente);

            Cliente searchObject = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        public void ValidateUpdateCliente()
        {
            int id = 1;
            Cliente cliente = _clienteRepository.SearchById(id);
            cliente.Nome = "Diogo F.";
            _clienteRepository.Update(cliente);

            Cliente searchObject = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        public void ValidateDeleteCliente()
        {
            int id = 99;
            _clienteRepository.Delete(id);
        }
    }
}
