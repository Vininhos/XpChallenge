﻿using Xp.Domain.Entities;
using Xp.Infra.Contexts;

namespace Xp.Tests
{
    public class FakeContextTests
    {
        private readonly IContextCliente _contextCliente;

        public FakeContextTests()
        {
            _contextCliente = new FakeContextCliente();
        }

        public void Execute()
        {
            TestList();
            TestInclusion();
        }

        private void TestList()
        {
            List<Cliente> clientes = _contextCliente.GetClientes();

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"CodCliente: {cliente.CodCliente}\n" +
                    $"Nome do cliente: {cliente.Nome}\n" +
                    $"Idade do cliente: {cliente.Idade}\n" +
                    $"CPF do cliente: {cliente.Cpf}\n" +
                    $"Código de ativo: {cliente.CodAtivo}\n" +
                    $"Quantidade de ativo: {cliente.qtAtivo}\n");
            }
        }

        private void TestInclusion()
        {
            Cliente cliente = new Cliente
            {
                CodCliente = 4,
                Nome = "Douglas F.",
                Idade = 27,
                Cpf = "98435348921",
                CodAtivo = 4,
                qtAtivo = 12105
            };

            _contextCliente.CreateCliente(cliente);
        }

        private async Task GetRandomPeopleAsync()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://randomuser.me/api");

            if(response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
