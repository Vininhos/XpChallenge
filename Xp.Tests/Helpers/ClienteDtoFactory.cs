using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Dtos;

namespace Xp.Tests.Helpers
{
    public class ClienteDtoFactory
    {
        public static ClienteDto GetClienteDto()
        {
            ClienteDto clienteDTO = new ClienteDto
            {
                CodCliente = 1,
                Nome = "Vinícius",
                qtAtivo = 105
            };

            return clienteDTO;
        }
    }
}
