using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Dtos;
using Xp.Domain.Entities;

namespace Xp.Tests
{
    public class DomainTests
    {
        public void TestEntity()
        {
            Cliente cliente = new Cliente
            {
                CodCliente = 1,
                Nome = "Vinícius",
                Cpf = "07036305983",
                qtAtivo = 105.40f
            };

            string message = $"CodCliente: {cliente.CodCliente}\nNome do cliente: {cliente.Nome}\nCPF do cliente: {cliente.Cpf}\nQuantidade de ativo: {cliente.qtAtivo}";
            Console.Write(message);
        }

        public void TestDto()
        {
            ClienteDto clienteDTO = new ClienteDto
            {
                CodCliente = 1,
                Nome = "Vinícius",
                qtAtivo = 105.40f
            };

            string message = $"\nCodCliente: {clienteDTO.CodCliente}\nNome do cliente: {clienteDTO.Nome}\nQuantidade de ativo: {clienteDTO.qtAtivo}";
            Console.Write(message);
        }

        public void TestConvertionEntityToDto()
        {
            Cliente cliente = new Cliente
            {
                CodCliente = 1,
                Nome = "Vinícius",
                Cpf = "07036305983",
                qtAtivo = 105.40f
            };

            ClienteDto dto = cliente.ConvertToDto();

            string message = $"CodCliente: {dto.CodCliente}\nNome do cliente: {dto.Nome}\nCPF do cliente: {dto.Cpf}\nQuantidade de ativo: {dto.qtAtivo}";
            Console.Write(message);
        }

        public void TestConvertionDtoToEntity()
        {
            ClienteDto clienteDTO = new ClienteDto
            {
                CodCliente = 1,
                Nome = "Vinícius",
                qtAtivo = 105.40f
            };

            Cliente cliente = clienteDTO.ConvertToEntity();

            string message = $"\nCodCliente: {cliente.CodCliente}\nNome do cliente: {cliente.Nome}\nQuantidade de ativo: {cliente.qtAtivo}";
            Console.Write(message);
        }
    }
}
