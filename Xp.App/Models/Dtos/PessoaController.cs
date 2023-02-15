using Microsoft.AspNetCore.Mvc;

namespace Xp.App.Models.Dtos
{
    public class PessoaController : Controller
    {
        private static List<PessoaDto> _pessoas;

        public PessoaController()
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
    }
}
