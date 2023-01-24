using Xp.Domain.Dtos;

namespace Xp.Domain.Entities
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Cpf { get; set; }
        public int CodAtivo { get; set; }
        public float qtAtivo { get; set; }

        public ClienteDto ConvertToDto()
        {
            return new ClienteDto
            {
                CodCliente = CodCliente,
                CodAtivo = CodAtivo,
                qtAtivo = qtAtivo
            };
        }
    }
}
