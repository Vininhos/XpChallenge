using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;
using Xp.Infra.Contexts;

namespace Xp.Tests
{
    public class FakeContextTests
    {
        private readonly IContext _context;

        public FakeContextTests()
        {
            _context = new FakeContext();
        }

        public void TestList()
        {
            List<Cliente> clientes = _context.GetClientes();

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

        public void TestInclusion()
        {
            Cliente cliente = new Cliente
            {
                CodCliente = 4,
                Nome = "Douglas F.",
                Idade = 27,
                Cpf = "98435348921",
                CodAtivo = 4,
                qtAtivo = 12105.70f
            };

            _context.CreateCliente(cliente);
        }

        public async Task GetRandomPeopleAsync()
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
