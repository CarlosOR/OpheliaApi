using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Excepciones
{
    public class InterceptorExceptciones 
    {
        //private readonly IHostingEnvironment _entorno;
        //protected event Action<Exception> OnError = ex => { };
        //public ManejoExcepcionesAttribute(IHostingEnvironment entorno)
        //{
        //    _entorno = entorno;
        //}

        //public override void OnException(ExceptionContext context)
        //{
        //    //if (_entorno.IsDevelopment())
        //    //    return;

        //    if (context.Exception is SincoException sincoException)
        //    {
        //        context.Exception = null;
        //        context.HttpContext.Response.StatusCode = (int)sincoException.statusCode;
        //        if (sincoException.Errores != null)
        //        {
        //            context.Result = new ObjectResult(new
        //            {
        //                Mensaje = sincoException.Message,
        //                Errores = sincoException.Errores
        //            });
        //        }
        //        else
        //            context.Result = new ObjectResult(sincoException.Message);
        //    }
        //    else
        //    {
        //        OnError(context.Exception);

        //        context.HttpContext.Response.StatusCode = 500;

        //        context.Result = new ObjectResult(new
        //        {
        //            Mensaje = $"Error no controlado {context.Exception.Message}.",
        //            Errores = new List<string>(){
        //            context.Exception?.Message,
        //            context.Exception?.InnerException?.Message
        //            },
        //            ErrorInterno = context.Exception.StackTrace
        //        });
        //    }
        //}
    }
}
