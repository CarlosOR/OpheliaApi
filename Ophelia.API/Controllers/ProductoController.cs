using Ophelia.DominioInterfaces.Productos;
using Ophelia.DTO.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ophelia.API.Controllers
{
    public class ProductoController : ApiController
    {
        readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            this._productoService = productoService;
        }

        [HttpGet]
        [Route("Producto/get")]
        public IHttpActionResult Get()
        {
            return Ok(_productoService.ObtenerProductos());
        }

        [HttpPost]
        [Route("Producto/crear")]
        public IHttpActionResult Crear(DTOProducto producto)
        {
            return Ok(_productoService.Crear(producto));
        }

        [HttpPost]
        [Route("Producto/actualizar")]
        public IHttpActionResult Modificiar(DTOProducto producto)
        {
            return Ok(_productoService.Modificar(producto));
        }

        [HttpGet]
        [Route("Producto/Eliminar/{id}")]
        public IHttpActionResult Eliminar(int id)
        {
            return Ok(_productoService.Eliminar(id));
        }
    }
}
