using Xp.Domain.Entities;

namespace Xp.Infra.Contexts
{
    public class FakeContextCorretora : IContextCorretora
    {
        private List<Corretora> _corretoras;

        public FakeContextCorretora()
        {
            LoadData();
        }

        private void LoadData()
        {
            _corretoras = new List<Corretora>
            {
                new Corretora(1, "Maltisxfx", 3000)
            };
        }

        public void CreateCorretora(Corretora corretora)
        {
            _corretoras.Add(corretora);
        }

        public void DeleteCorretora(int id)
        {
            Corretora result = GetCorretora(id);
            if (result != null)
                _corretoras.Remove(result);
        }

        public Corretora GetCorretora(int id)
        {
            Corretora result = _corretoras.FirstOrDefault(x => x.CodCorretora == id);
            return result;
        }

        public List<Corretora> GetCorretoras()
        {
            return _corretoras.OrderBy(x => x.CodCorretora).ToList();
        }

        public void UpdateCorretora(Corretora corretora)
        {
            Corretora result = GetCorretora(corretora.CodCorretora);
            _corretoras.Remove(corretora);

            _corretoras.Add(result);
        }
    }
}
