using Ophelia.DominioInterfaces.Productos;
using Ophelia.DTO.Productos;
using Persistencia.Contexto;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dominio.Productos
{
    public class ProductoService : IProductoService
    {
        readonly IRepositorio<Producto> _repoProducto;

        public ProductoService(IRepositorio<Producto> repoProducto)
        {
            this._repoProducto = repoProducto;
        }

        public Producto Crear(DTOProducto producto)
        {
            Producto newProducto= new Producto
            {
                Id = producto.Id,
                referencia= producto.referencia,
                nombre = producto.nombre,
                precio = producto.precio
            };
            _repoProducto.Crear(newProducto);
            _repoProducto.GuardarCambios();
            return newProducto;
        }

        public bool Eliminar(int id)
        {
            Producto producto = _repoProducto.PorId(id);
            _repoProducto.Eliminar(producto);
            _repoProducto.GuardarCambios();
            return true;
        }

        public Producto Modificar(DTOProducto producto)
        {
            Producto updatedProducto = new Producto
            {
                Id = producto.Id,
                referencia = producto.referencia,
                nombre = producto.nombre,
                precio = producto.precio
            };
            _repoProducto.Editar(updatedProducto);
            _repoProducto.GuardarCambios();
            return updatedProducto;
        }

        public List<DTOProducto> ObtenerProductos()
        {
            List<Producto> productos = _repoProducto.Todos().ToList();
            List<DTOProducto> dtoClientes = new List<DTOProducto>();
            foreach (var producto in productos)
            {
                dtoClientes.Add(new DTOProducto
                {
                    Id = producto.Id,
                    referencia = producto.referencia,
                    nombre = producto.nombre,
                    precio = producto.precio
                });
            }

            return dtoClientes;
        }
    }
}
