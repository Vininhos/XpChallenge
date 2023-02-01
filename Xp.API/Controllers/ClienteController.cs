using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using Xp.Infra.Repositories;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Xp.Services.Service;
using Xp.Domain.Entities;
using Xp.Domain.Dtos;

namespace Xp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        ClienteService _clienteService;

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public List<ClienteDto> GetIsRunning()
        {
            try
            {
                List<Cliente> clientes = _clienteService.GetAll();
                List<ClienteDto> clientesDto = clientes != null ? Cliente.ConvertToDto(clientes) : null;
                return clientesDto;
                //return JsonSerializer.Serialize(clientesDto, options);
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
