using Ophelia.DominioInterfaces.Clientes;
using System.Web.Http;
using Ophelia.DTO.Clientes;
using System.Web.Http.Cors;

namespace Ophelia.API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ClienteController : ApiController
    {

        readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }

        [HttpGet]
        [Route("Cliente/get")]
        public IHttpActionResult Get()
        {
            return Ok(_clienteService.ObtenerClientes());
        }

        [HttpPost]
        [Route("Cliente/crear")]
        public IHttpActionResult Crear(DTOCliente cliente)
        {
            return Ok(_clienteService.Crear(cliente));
        }

        [HttpPost]
        [Route("Cliente/actualizar")]
        public IHttpActionResult Modificiar(DTOCliente cliente)
        {
            return Ok(_clienteService.Modificar(cliente));
        }

        [HttpGet]
        [Route("Cliente/Eliminar/{id}")]
        public IHttpActionResult Eliminar(int id)
        {
            return Ok(_clienteService.Eliminar(id));
        }
    }
}
