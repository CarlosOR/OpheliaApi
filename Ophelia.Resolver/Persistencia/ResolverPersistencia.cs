using Autofac;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Resolver.Persistencia
{
    public static class ResolverPersistencia
    {
        public static void RegistrarAccesoDatos(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repositorio<>)).As(typeof(IRepositorio<>)).SingleInstance();
        }
    }
}
