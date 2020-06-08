using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.DTO.Productos
{
    public class DTOProducto
    {
        public int Id { get; set; }
        public string referencia { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
    }
}
