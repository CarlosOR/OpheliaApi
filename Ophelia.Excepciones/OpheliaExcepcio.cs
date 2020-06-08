using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Excepciones
{
    public class OpheliaExcepcio:Exception
    {
        public HttpStatusCode statusCode;
        public List<string> Errores;

        public OpheliaExcepcio(string mensaje, HttpStatusCode _statusCode) : base(mensaje)
        {
            statusCode = _statusCode;
        }

        public OpheliaExcepcio(string mensaje, HttpStatusCode _statusCode, List<string> errores) : base(mensaje)
        {
            this.statusCode = _statusCode;
            this.Errores = errores;
        }
    }
}
