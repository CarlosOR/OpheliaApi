using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.DTO.Clientes
{
    public class DTOCliente
    {
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
