using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Excepciones.OpheliaExcepciones
{
    public class OpheliaNotFoundException:OpheliaExcepcio
    {
        public OpheliaNotFoundException(string mensaje):base(mensaje, System.Net.HttpStatusCode.NotFound)
        {

        }
    }
}
