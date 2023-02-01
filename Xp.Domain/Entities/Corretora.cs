using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xp.Domain.Entities
{
    public class Corretora
    {
        public int CodCorretora { get; set; }
        public string NomeCorretora { get; set; }
        public int QtAtivo { get; set; }

        public Corretora(int codCorretora, string nomeCorretora, int qtAtivo)
        {
            CodCorretora = codCorretora;
            NomeCorretora = nomeCorretora;
            QtAtivo = qtAtivo;
        }
    }
}
