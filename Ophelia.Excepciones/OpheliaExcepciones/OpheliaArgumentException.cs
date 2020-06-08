using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Excepciones.OpheliaExcepcion
{
    class OpheliaArgumentException: OpheliaExcepcio
    {
        public OpheliaArgumentException(string mensaje) : base(mensaje, System.Net.HttpStatusCode.BadRequest)
        {

        }

        public OpheliaArgumentException(string mensaje, List<string> errores) : base(mensaje, System.Net.HttpStatusCode.BadRequest)
        {
          
        }
    }
}
