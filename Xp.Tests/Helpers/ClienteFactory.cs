using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;

namespace Xp.Tests.Helpers
{
    public class ClienteFactory
    {
        public static Cliente GetCliente()
        {
            Cliente cliente = new Cliente
            {
                CodCliente = 1,
                Nome = "Vinícius",
                Cpf = "07036305983",
                qtAtivo = 105
            };

            return cliente;
        }

        public static Cliente GetNewCliente()
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

            return cliente;
        }
    }
}
