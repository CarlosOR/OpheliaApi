using Ophelia.DominioInterfaces.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ophelia.API.Controllers
{
    public class FacturaController : ApiController
    {
        readonly IFacturaService _facturaService;

        public FacturaController(IFacturaService facturaService)
        {
            this._facturaService = facturaService;
        }


        [HttpPost]
        [Route("Factura/Facturar")]
        public IHttpActionResult Facturar(DTO.Facturas.DTOFactura factura)
        {
            return Ok(_facturaService.Facturar(factura));
        }
    }
}
