using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Repositories;

namespace Xp.Tests
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

        private void ValidateClienteListing()
        {
            List<Cliente> clientes = _clienteRepository.GetAll();

            foreach (Cliente cliente in clientes)
                Console.WriteLine($"Id: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        private void ValidateSearchByIdCliente()
        {
            int id = 1;
            Cliente cliente = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        private void ValidateRegistrationCliente()
        {
            int id = 85;

            Cliente cliente = new Cliente
            {
                CodCliente = id,
                Nome = "Benjamin D.",
                CodAtivo = 99,
                Cpf = "19283918284",
                Idade = 35,
                qtAtivo = 32944.10f
            };

            _clienteRepository.Save(cliente);

            Cliente searchObject = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        private void ValidateUpdateCliente()
        {
            int id = 1;
            Cliente cliente = _clienteRepository.SearchById(id);
            cliente.Nome = "Diogo F.";
            _clienteRepository.Update(cliente);

            Cliente searchObject = _clienteRepository.SearchById(id);
            Console.WriteLine($"Id: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        private void ValidateDeleteCliente()
        {
            int id = 99;
            _clienteRepository.Delete(id);

            Cliente cliente = _clienteRepository.SearchById(id);
        }
    }
}
