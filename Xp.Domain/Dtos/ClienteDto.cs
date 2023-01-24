using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xp.Domain.Entities;

namespace Xp.Domain.Dtos
{
    public class ClienteDto
    {
        public int CodCliente { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cpf { get; set; }
        public int CodAtivo { get; set; }
        public float qtAtivo { get; set; }

        public Cliente ConvertToEntity()
        {
            return new Cliente
            {
                CodCliente = CodCliente,
                CodAtivo = CodAtivo,
                qtAtivo = qtAtivo
            };
        }
    }
}
