using Ophelia.DTO.Productos;
using Persistencia.Contexto;
using System.Collections.Generic;

namespace Ophelia.DominioInterfaces.Productos
{
    public interface IProductoService
    {
        List<DTOProducto> ObtenerProductos();
        Producto Crear(DTOProducto producto);
        Producto Modificar(DTOProducto producto);
        bool Eliminar(int id);
    }
}
