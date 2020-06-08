using Ophelia.DTO.Clientes;
using Ophelia.DTO.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.DTO.Facturas
{
    public class DTOFactura
    {
        public DTOCliente cliente { get; set; }
        public List<DTOProducto> productos {get;set;}
        public decimal precio {get;set;}
    }
}
