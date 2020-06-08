using Ophelia.DominioInterfaces.Clientes;
using Ophelia.DTO.Clientes;
using Persistencia.Contexto;
using Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ophelia.Dominio.Clientes
{
    public class ClienteService : IClienteService
    {
        readonly IRepositorio<Cliente> _repoCliente;

        public ClienteService(IRepositorio<Cliente> repoCliente)
        {
            this._repoCliente = repoCliente;
        }

        public Cliente Crear(DTOCliente cliente)
        {
            Cliente newCliente = new Cliente
            {
                identificacion = cliente.identificacion,
                nombre = cliente.nombre,
                telefono = cliente.telefono,
                fechaNacimiento = cliente.fechaNacimiento
            };
            _repoCliente.Crear(newCliente);
            _repoCliente.GuardarCambios();
            return newCliente;

        }

        public bool Eliminar(int id)
        {
            Cliente cliente = _repoCliente.PorId(id);
            _repoCliente.Eliminar(cliente);
            _repoCliente.GuardarCambios();
            return true;
        }

        public Cliente Modificar(DTOCliente cliente)
        {
            Cliente updatedCliente = _repoCliente.PorId(cliente.id);
            updatedCliente.identificacion = cliente.identificacion;
            updatedCliente.nombre = cliente.nombre;
            updatedCliente.telefono = cliente.telefono;
            updatedCliente.fechaNacimiento = cliente.fechaNacimiento;
            _repoCliente.Editar(updatedCliente);
            _repoCliente.GuardarCambios();
            return updatedCliente;
        }

        public List<DTOCliente> ObtenerClientes()
        {
            List<Cliente> clientes =  _repoCliente.Todos().ToList();
            List<DTOCliente> dtoClientes = new List<DTOCliente>();
            foreach(var cliente in clientes)
            {
                dtoClientes.Add(new DTOCliente
                {
                    id = cliente.id,
                    identificacion = cliente.identificacion,
                    nombre = cliente.nombre,
                    telefono = cliente.telefono,
                    fechaNacimiento = cliente.fechaNacimiento
                });
            }

            return dtoClientes;

        }
    }
}
