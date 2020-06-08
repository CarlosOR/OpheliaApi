using Ophelia.DTO.Clientes;
using Persistencia.Contexto;
using System.Collections.Generic;

namespace Ophelia.DominioInterfaces.Clientes
{
    public interface IClienteService
    {
        List<DTOCliente> ObtenerClientes();
        Cliente Crear(DTOCliente cliente);
        Cliente Modificar(DTOCliente cliente);
        bool Eliminar(int id);
        
    }
}
