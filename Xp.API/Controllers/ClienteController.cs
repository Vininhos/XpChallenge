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

        public ClienteController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public List<ClienteDto> Get()
        {
            try
            {
                List<Cliente> clientes = _clienteService.GetAll();
                List<ClienteDto> clientesDto = clientes != null ? Cliente.ConvertToDto(clientes) : null;
                return clientesDto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }

        [HttpGet]
        [Route("{id}")]
        public ClienteDto Get(int id)
        {
            try
            {
                Cliente cliente = _clienteService.SearchById(id);
                ClienteDto dto = cliente != null ? cliente.ConvertToDto() : null;

                return dto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public string Post([Bind("nome, idade, cpf, codativo, qtativo")]ClienteDto clienteDto)
        {
            try
            {
                Cliente cliente = clienteDto.ConvertToEntity();
                _clienteService.Save(cliente);

                return $"Cliente {cliente.Nome} successfully added. His ID is: {cliente.CodCliente}";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
