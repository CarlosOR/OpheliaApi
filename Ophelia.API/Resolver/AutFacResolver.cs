using Autofac;
using Autofac.Integration.WebApi;
using Ophelia.Dominio.Clientes;
using Ophelia.Resolver.Dominio;
using Ophelia.Resolver.Persistencia;
using System.Reflection;
using System.Web.Http;

namespace Ophelia.API.Resolver
{
    public class AutFacResolver
    {

        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            ResolverDominio.RegistrarServicios(builder);
            ResolverPersistencia.RegistrarAccesoDatos(builder);


            Container = builder.Build();

            return Container;
        }

    }
}