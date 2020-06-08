using Ophelia.Dominio.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ophelia.Controllers.Clientes
{
    public class ClienteController : ApiController
    {
        ClienteService _clienteService;
        public ClienteController(ClienteService clienteService)
        {
            this._clienteService = clienteService;
        }

        // GET: api/Cliente
        public IHttpActionResult Get()
        {
            return Ok(_clienteService.ObtenerClientes());
        }

        // GET: api/Cliente/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cliente
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cliente/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
        }
    }
}
