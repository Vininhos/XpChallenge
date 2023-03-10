using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Repositories;
using Xp.Services.Service;
using Xp.Tests.Helpers;

namespace Xp.Tests.Services
{
    public class ServiceTest
    {
        private readonly ClienteService _clienteService;

        public ServiceTest(ClienteService clienteService)
        {
            _clienteService = clienteService;
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
            List<Cliente> clientes = _clienteService.GetAll();

            foreach (Cliente cliente in clientes)
                Console.WriteLine($"\nId: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        public void ValidateSearchByIdCliente()
        {
            int id = 1;
            Cliente cliente = _clienteService.SearchById(id);
            Console.WriteLine($"\nId: {cliente.CodCliente}, Nome: {cliente.Nome}");
        }

        public void ValidateRegistrationCliente()
        {
            Cliente cliente = ClienteFactory.GetNewCliente();

            int id = cliente.CodCliente;

            _clienteService.Save(cliente);

            Cliente searchObject = _clienteService.SearchById(id);
            Console.WriteLine($"\nId: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        public void ValidateUpdateCliente()
        {
            int id = 1;
            Cliente cliente = _clienteService.SearchById(id);
            cliente.Nome = "Diogo F.";
            _clienteService.Update(cliente);

            Cliente searchObject = _clienteService.SearchById(id);
            Console.WriteLine($"\nId: {searchObject.CodCliente}, Nome: {searchObject.Nome}");
        }

        public void ValidateDeleteCliente()
        {
            int id = 99;
            _clienteService.Delete(id);

            Cliente cliente = _clienteService.SearchById(id);
        }
    }
}
