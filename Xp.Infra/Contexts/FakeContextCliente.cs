using Xp.Domain.Entities;

namespace Xp.Infra.Contexts
{
    public class FakeContextCliente : IContextCliente
    {
        private List<Cliente> _clientes;

        public FakeContextCliente()
        {
            LoadData();
        }

        private void LoadData()
        {
            _clientes = new List<Cliente>();

            Cliente cliente = new Cliente
            {
                CodCliente = 1,
                Nome = "Vinícius R.",
                Idade = 23,
                Cpf = "07036305983",
                CodAtivo = 1,
                qtAtivo = 105
            };

            _clientes.Add(cliente);

            Cliente cliente2 = new Cliente
            {
                CodCliente = 2,
                Nome = "João P.",
                Idade = 32,
                Cpf = "9239837812",
                CodAtivo = 2,
                qtAtivo = 300
            };

            _clientes.Add(cliente2);

            Cliente cliente3 = new Cliente
            {
                CodCliente = 3,
                Nome = "Anderson G.",
                Idade = 45,
                Cpf = "723786548",
                CodAtivo = 3,
                qtAtivo = 4500
            };

            _clientes.Add(cliente3);
        }

        public void CreateCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        public void DeleteCliente(int id)
        {
            Cliente result = GetCliente(id);

            if (result != null)
                _clientes.Remove(result);
        }

        public List<Cliente> GetClientes()
        {
            return _clientes.OrderBy(c => c.CodCliente).ToList();
        }

        public Cliente GetCliente(int id)
        {
            return _clientes.FirstOrDefault(c => c.CodCliente == id);
        }

        public void UpdateCliente(Cliente cliente)
        {
            Cliente objSearch = GetCliente(cliente.CodCliente);
            _clientes.Remove(objSearch);

            objSearch = new Cliente
            {
                CodCliente = cliente.CodCliente,
                Nome = !string.IsNullOrEmpty(cliente.Nome) ? cliente.Nome : objSearch.Nome,
                Cpf = !string.IsNullOrEmpty(cliente.Cpf) ? cliente.Cpf : objSearch.Cpf,
            };

            _clientes.Add(objSearch);
        }

        public int NextId()
        {
            int id = _clientes.Max(c => c.CodCliente); 
            return ++id;
        }
    }
}
