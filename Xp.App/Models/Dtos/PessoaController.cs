using Microsoft.AspNetCore.Mvc;

namespace Xp.App.Models.Dtos
{
    public class PessoaController : Controller
    {
        private static List<PessoaDto> _pessoas;

        public PessoaController()
        {
            if (_pessoas == null)
                LoadConfig();
        }

        private void LoadConfig()
        {
            _pessoas = new List<PessoaDto>
            {
                new PessoaDto()
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome = "Josnei F.",
                    Email = "teste@teste.com"
                },
                new PessoaDto()
                {
                    Id = Guid.NewGuid().ToString(),
                    Nome= "Ronaldo S.",
                    Email = "teste2@teste.com"
                }
            };
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListAll()
        {
            return View(_pessoas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([Bind("Nome, Email")] PessoaDto pessoa)
        {
            try
            {
                pessoa.Id = Guid.NewGuid().ToString();
                _pessoas.Add(pessoa);

                return RedirectToAction("ListAll");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
