using Microsoft.AspNetCore.Mvc;
using Xp.App.Models.Dtos;

namespace Xp.App.Controllers
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

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            PessoaDto pessoa = _pessoas.FirstOrDefault(p => p.Id.Equals(Id));
            return View(pessoa);
        }

        [HttpPost]
        public IActionResult DeletePost(string Id)
        {
            PessoaDto pessoa = _pessoas.FirstOrDefault(p => p.Id.Equals(Id));
            if (pessoa != null)
                _pessoas.Remove(pessoa);

            return RedirectToAction("ListAll");
        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
			PessoaDto pessoa = _pessoas.FirstOrDefault(p => p.Id.Equals(Id));
			return View();
        }

		[HttpPost]
		public IActionResult Edit([Bind("Id, Nome, Email")]PessoaDto pessoa)
		{
			PessoaDto pessoaSearch = _pessoas.FirstOrDefault(p => p.Id.Equals(pessoa.Id));
            if (pessoaSearch != null)
            {
                _pessoas.Remove(pessoaSearch);
                _pessoas.Add(pessoa);
            }

			return RedirectToAction("ListAll");
		}
	}
}
