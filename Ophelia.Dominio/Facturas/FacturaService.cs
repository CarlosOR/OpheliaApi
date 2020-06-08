using Ophelia.DominioInterfaces.Facturas;
using Ophelia.DTO.Facturas;
using Ophelia.DTO.Productos;
using Persistencia.Contexto;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ophelia.Dominio.Facturas
{
    public class FacturaService : IFacturaService
    {
        private OpheliaEntities db = new OpheliaEntities();
        readonly IRepositorio<Factura> _repoFactura;

        public FacturaService(IRepositorio<Factura> repoFactura)
        {
            this._repoFactura = repoFactura;
        }

        public bool Facturar(DTOFactura factura)
        {
            try
            {
                Factura newFactura = new Factura();
                newFactura.idCliente = factura.cliente.id;
                newFactura.fechaFactura = System.DateTime.Now;
                db.Factura.Add(newFactura);
                db.SaveChanges();

                foreach (var producto in factura.productos)
                {
                    db.Venta.Add(new Venta() { idFactura = newFactura.id, idProducto = producto.Id  });
                    if (db.Inventario.Any(i => i.idProducto == producto.Id))
                    {
                        Inventario inventario = db.Inventario.Where(i => i.idProducto == producto.Id).First();
                        inventario.cantidad -= 1;
                        db.Entry<Inventario>(inventario).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                db.SaveChanges();
                return true;
            }
            catch (System.Exception e)
            {
                throw new ArgumentException("Erro al facturar", "", e);
            }
        }

        //public void ActualizarInventatio(int idFactura, List<DTOProducto> productos)
        //{
        //    Factura factura = _repoFactura.PorId(idFactura);
        //    foreach (var producto in productos)
        //    {
        //        if (_repoInventario.Algun(i => i.idProducto == producto.Id))
        //        {
        //            Inventario inventario = _repoInventario.BuscarPor(i => i.idProducto == producto.Id).First();
        //            inventario.cantidad -= 1;
        //            _repoInventario.Editar(inventario);
        //        }
        //    }
        //    _repoInventario.GuardarCambios();
        //}
    }
}
