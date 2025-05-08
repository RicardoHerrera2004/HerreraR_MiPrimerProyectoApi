using HerreraR_MiPrimerProyectoApi.Models;
using HerreraR_MiPrimerProyectoApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerreraR_MiPrimerProyectoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClientesRepositorycs _clientesRepository;
        public ClienteController()
        {
            _clientesRepository = new ClientesRepositorycs();
        }

        [HttpGet]
        [Route("List")]

        public IEnumerable<Cliente> ObtenerListadoClientes()
        {
            return _clientesRepository.ObtenerListadoClientes();
        }

        [HttpGet]
        [Route("Info")]
        public IActionResult ObtenerInfoClientePorId(string Id)
        {
            try
            {
                var cliente = _clientesRepository.ObtenerInfoClientePorId(Id);
                return Ok(cliente);
            }
            catch (Exception)
            {
                return NotFound("No se encontró el cliente con el ID proporcionado.");
            }
        }

        [HttpPost]
        public IActionResult CrearCliente([FromBody] Cliente cliente)
        {
            var guardar = _clientesRepository.CrearCliene(cliente);
            if (guardar)
            {
                return Ok("Cliente creado correctamente");
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult ActualizarCliente([FromBody] Cliente cliente)
        {
            var actualizar = _clientesRepository.ActualizarCliente(cliente);
            if (actualizar)
            {
                return Ok("Cliente actualizado correctamente");
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpDelete]
        public IActionResult EliminarCliente(string Id)
        {
            var eliminar = _clientesRepository.EliminarCliente(Id);
            if (eliminar)
            {
                return Ok("Cliente eliminado correctamente");
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
