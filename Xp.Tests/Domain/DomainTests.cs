using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Dtos;
using Xp.Domain.Entities;
using Xp.Tests.Helpers;

namespace Xp.Tests.Domain
{
    public class DomainTests
    {

        public void Execute()
        {
            TestEntity();
            TestDto();
            TestConvertionEntityToDto();
            TestConvertionDtoToEntity();
        }

        private void TestEntity()
        {
            Cliente cliente = ClienteFactory.GetCliente();

            string message = $"CodCliente: {cliente.CodCliente}\nNome do cliente: {cliente.Nome}\nCPF do cliente: {cliente.Cpf}\nQuantidade de ativo: {cliente.qtAtivo}";
            Console.Write(message);
        }

        private void TestDto()
        {
            ClienteDto clienteDTO = ClienteDtoFactory.GetClienteDto();

            string message = $"CodCliente: {clienteDTO.CodCliente}\nNome do cliente: {clienteDTO.Nome}\nQuantidade de ativo: {clienteDTO.qtAtivo}";
            Console.Write(message);
        }

        private void TestConvertionEntityToDto()
        {
            ClienteDto clienteDTO = ClienteDtoFactory.GetClienteDto();

            string message = $"CodCliente: {clienteDTO.CodCliente}\nNome do cliente: {clienteDTO.Nome}\nCPF do cliente: {clienteDTO.Cpf}\nQuantidade de ativo: {clienteDTO.qtAtivo}";
            Console.Write(message);
        }

        private void TestConvertionDtoToEntity()
        {
            ClienteDto clienteDTO = ClienteDtoFactory.GetClienteDto();

            Cliente cliente = clienteDTO.ConvertToEntity();

            string message = $"\nCodCliente: {cliente.CodCliente}\nNome do cliente: {cliente.Nome}\nQuantidade de ativo: {cliente.qtAtivo}";
            Console.Write(message);
        }
    }
}
