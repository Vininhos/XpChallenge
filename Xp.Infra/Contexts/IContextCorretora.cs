using Xp.Domain.Entities;

namespace Xp.Infra.Contexts
{
    public interface IContextCorretora
    {
        public List<Corretora> GetCorretoras();

        public Corretora GetCorretora(int id);

        public void CreateCorretora(Corretora corretora);

        public void UpdateCorretora(Corretora corretora);

        public void DeleteCorretora(int id);
    }
}
