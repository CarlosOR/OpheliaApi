using Autofac;
using Ophelia.Dominio.Clientes;
using Ophelia.Dominio.Facturas;
using Ophelia.Dominio.Productos;
using Ophelia.DominioInterfaces.Clientes;
using Ophelia.DominioInterfaces.Facturas;
using Ophelia.DominioInterfaces.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Resolver.Dominio
{
    public static class ResolverDominio
    {
        public static void RegistrarServicios(ContainerBuilder builder)
        {
            builder.RegisterType<ClienteService>().As<IClienteService>().InstancePerRequest();
            builder.RegisterType<ProductoService>().As<IProductoService>().InstancePerRequest();
            builder.RegisterType<FacturaService>().As<IFacturaService>().InstancePerRequest();
        }
    }
}
